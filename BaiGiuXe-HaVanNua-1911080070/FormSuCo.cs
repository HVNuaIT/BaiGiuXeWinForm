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
    public partial class FormSuCo : Form
    {
        public FormSuCo()
        {
            InitializeComponent();
        }
        QuanLyBaiGiuXe db = new QuanLyBaiGiuXe();

        private void FormSuCo_Load(object sender, EventArgs e)
        {
            loadData();
        }

      void loadData()
        {
            dataGridView1.DataSource = db.SuCoes.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            String ma1 = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj1 = db.SuCoes.Where(s => s.MaSuCo.Contains(ma1)).First();
            txtMaSuCo.Text = obj1.MaSuCo;
            txtND.Text = obj1.NoiDung;
            txtTenKhach.Text = obj1.TenKhachHang;
            dtNgay.Value = obj1.NgayGhi.Value;
            txMaXe.Text = obj1.MaXe;
            txtBienSo.Text = obj1.BienSo;
        }

        private void bntXN_Click(object sender, EventArgs e)
        {
            SuCo s = new SuCo();
            s.MaSuCo = txtMaSuCo.Text;
            s.BienSo = txtBienSo.Text;
            s.MaXe = txMaXe.Text;
            s.NgayGhi = dtNgay.Value;
            s.NoiDung = txtND.Text;
            s.TenKhachHang = txtTenKhach.Text;
            db.SuCoes.Add(s);
            db.SaveChanges();
            loadData();
            reset();
        }
        void reset()
        {
            txMaXe.Text = String.Empty;
            txtBienSo.Text = String.Empty;
            txtMaSuCo.Text = String.Empty;
            txtND.Text = String.Empty;
            txtTenKhach.Text = String.Empty;
            dtNgay.Text = String.Empty;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            String ma = txtMaSuCo.Text;
            var ds = db.SuCoes.Where(s => s.MaSuCo.Contains(ma)).First();
            DialogResult dt = MessageBox.Show("Có Muốn Xóa Hay Không ", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dt == DialogResult.No)
            {
                return;
            }
            db.SuCoes.Remove(ds);
            db.SaveChanges();
            loadData();
            reset();
        }

       

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Ban Muốn Quay Lại Trang Chủ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            Form x = new FormTrangChu();
            x.Show();
            this.Hide();
        }

        private void BntLamMoi_Click(object sender, EventArgs e)
        {
            loadData();
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            String ma = txtMaSuCo.Text;
            var s = db.SuCoes.Where(a => a.MaSuCo.Contains(ma)).First();
            s.MaSuCo = txtMaSuCo.Text;
            s.BienSo = txtBienSo.Text;
            s.MaXe = txMaXe.Text;
            s.NgayGhi = dtNgay.Value;
            s.NoiDung = txtND.Text;
            s.TenKhachHang = txtTenKhach.Text;
            db.SaveChanges();
            loadData();
            reset();
            MessageBox.Show("Sửa Thành Công");
        }
    }
}
