using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXe_HaVanNua_1911080070
{
    public partial class FormXeRaVao : Form
    {
        public FormXeRaVao()
        {
            InitializeComponent();
        }
        QuanLyBaiGiuXe db = new QuanLyBaiGiuXe();
        private void FormXeRaVao_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            dataGridView1.DataSource = db.XeVaos.ToList();
            List<BangGia> dsBG = db.BangGias.ToList();
            cbLoaiXe.DisplayMember = "LoaiXe";
            cbLoaiXe.ValueMember = "LoaiXe";
            cbLoaiXe.DataSource = dsBG;
            List<Bai> dsBai = db.Bais.ToList();
            cbBai.DisplayMember = "ViTri";
            cbBai.ValueMember = "MaBai";
            cbBai.DataSource = dsBai;
            List<TheXe> dsthe = db.TheXes.ToList();
            cbMaThe.DisplayMember = "MaTheXe";
            cbMaThe.ValueMember = "MaTheXe";
            cbMaThe.DataSource = dsthe;

        }

        private void BntVaoBen_Click(object sender, EventArgs e)
        {
            XeVao s = new XeVao();
            s.MaXe = txtMaXe.Text;
            s.MaTheXe =Convert.ToString( cbMaThe.SelectedValue);
            s.GioVao = dtNgayVao.Value;
            s.GhiChu = txtGhiCHu.Text;
            s.LoaiXe = Convert.ToString(cbLoaiXe.SelectedValue);
            s.BienSoXe = txtBienSo.Text;
            s.MaBai = Convert.ToString(cbBai.SelectedValue);
            db.XeVaos.Add(s);
            String ma = Convert.ToString(cbBai.SelectedValue);
            var ds = db.Bais.Where(a => a.MaBai.Contains(ma)).First();
            ds.MaXe = txtMaXe.Text;
            //db.SaveChanges();
            String maThe = Convert.ToString(cbMaThe.SelectedValue);
            var dsthe = db.TheXes.Where(b => b.MaTheXe.Contains(maThe)).First();
            dsthe.GioVao = dtNgayVao.Value;
            dsthe.MaXe = txtMaXe.Text;
            String loai = Convert.ToString(cbLoaiXe.SelectedValue);
            var dsLoai = db.BangGias.Where(b => b.LoaiXe.Contains(loai)).First();
            dsLoai.SoCho -= 1;

            //db.SaveChanges();
            db.SaveChanges();
            loadData();


        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Form x = new FormTrangChu();
            DialogResult dt = MessageBox.Show("Bạn có muốn quay lại trang chủ không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            x.Show();
            this.Hide();
        }

        private void Lưu_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String ma = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.XeVaos.Where(s => s.MaXe.Contains(ma)).First();
            txtBienSo.Text = obj.BienSoXe;
            txtGhiCHu.Text = obj.GhiChu;
            txtMaXe.Text = obj.MaXe;
            dtNgayVao.Text = obj.GioVao.ToString();
            cbBai.SelectedValue = obj.MaBai;
            cbLoaiXe.SelectedValue = obj.LoaiXe;
            cbMaThe.SelectedValue = obj.MaTheXe;
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            String a = txtTim.Text.Trim();


            var ds = db.XeVaos.Where(s => s.BienSoXe.Contains(a)).ToList();
            if (ds.Count > 0)
            {
                MessageBox.Show("Đã Tìm Thấy");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy " + txtTim.Text.ToString());
                dataGridView1.DataSource = null;
            }
        }

        private void BntLamMoi_Click(object sender, EventArgs e)
        {
            loadData();
        }
        
        private void BntRaBen_Click(object sender, EventArgs e)
        {
            String ma = txtBienSo.Text;
            string str = DateTime.Now.ToString().Trim();
            var ds = db.XeVaos.Where(a => a.BienSoXe.Contains(ma)).First();
            String loai = Convert.ToString(cbLoaiXe.SelectedValue);
            var gia = db.BangGias.Where(b => b.LoaiXe.Contains(loai)).First();
              DialogResult dt =  MessageBox.Show("Phiếu Thanh Toán" + "\n"
                    + "Biển Số Xe : " + txtBienSo.Text + "\n"
                    + "Mã Thẻ Xe  : " + cbLoaiXe.SelectedValue + "\n"
                    + "Ngày Vào   :" + dtNgayVao.Text + "\n"
                    + "Ngày Ra     :" + str + "\n"
                    + "Thành Tiền  :" +gia.DonGia

                    ,"Thông Báo" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question) ;
               
            if (dt == DialogResult.Yes)
            {
                PhieuThanhToan s = new PhieuThanhToan();
                s.BienSo = txtBienSo.Text;
                s.ThanhTien = gia.DonGia;
                s.NgayVao = dtNgayVao.Value;
                s.NgayRa = DateTime.Now;
                s.LoaiXe = Convert.ToString(cbLoaiXe.SelectedValue);
                s.MaThanhToan = 1;
                s.ThoiGianGui = 2;
                db.PhieuThanhToans.Add(s);
                String maBai = Convert.ToString(cbBai.SelectedValue);
                var dsBai = db.Bais.Where(a => a.MaBai.Contains(maBai)).First();
                dsBai.MaXe = "";
                //db.SaveChanges();
                String maThe = Convert.ToString(cbMaThe.SelectedValue);
                var dsthe = db.TheXes.Where(b => b.MaTheXe.Contains(maThe)).First();
                dsthe.MaXe = "";
                dsthe.GioVao = null;
                var dsLoai = db.BangGias.Where(b => b.LoaiXe.Contains(loai)).First();
                dsLoai.SoCho += 1;
                db.XeVaos.Remove(ds);
                db.SaveChanges();
                loadData();
            }
        }
    }
}
