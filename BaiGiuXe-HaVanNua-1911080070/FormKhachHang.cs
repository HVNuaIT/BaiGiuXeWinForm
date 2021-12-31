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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        QuanLyBaiGiuXe db = new QuanLyBaiGiuXe();

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            dataGridView1.DataSource = db.KhachHangs.ToList();
        }
       

        private void bntThem_Click(object sender, EventArgs e)
        {
            KhachHang s = new KhachHang();
            s.MaKhachHang = txtMaKhach.Text;
            s.GioiTinh = txtGT.Text;
            s.SDT = Convert.ToInt32(txtSDT.Text);
            s.TenKhach = txtTenKhach.Text;
            s.Tuoi = Convert.ToInt32(txtTuoi.Text);
            s.CMND = Convert.ToInt32(txtCMND.Text);
            db.KhachHangs.Add(s);
            db.SaveChanges();
            LoadData();
            MessageBox.Show(" Thêm Thành Công" + " " + s.TenKhach + " " + "Vào Danh Sách");
            reset();

        }
        void reset()
        {
            txtCMND.Text = String.Empty;
            txtGT.Text = String.Empty;
            txtMaKhach.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtTenKhach.Text = String.Empty;
            txtTuoi.Text = String.Empty;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            String ma = txtMaKhach.Text;
            var ds= db.KhachHangs.Where(a => a.MaKhachHang == ma).First();
            DialogResult dt = MessageBox.Show("Bạn Có Muốn Xóa Không ", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            db.KhachHangs.Remove(ds);
            db.SaveChanges();
            LoadData();
            reset();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            String ma = txtMaKhach.Text;
            var s= db.KhachHangs.Where(a => a.MaKhachHang == ma).First();
            s.MaKhachHang = txtMaKhach.Text;
            s.GioiTinh = txtGT.Text;
            s.SDT = Convert.ToInt32(txtSDT.Text);
            s.TenKhach = txtTenKhach.Text;
            s.Tuoi = Convert.ToInt32(txtTuoi.Text);
            s.CMND = Convert.ToInt32(txtCMND.Text);
            db.SaveChanges();
            LoadData();
            reset();
            MessageBox.Show("Sửa Thành Công", "Thống Báo");
        }

        private void bntQuayLai_Click(object sender, EventArgs e)
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


        private void BntLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            String a = txtTim.Text.Trim();


            var ds = db.KhachHangs.Where(s => s.TenKhach.Contains(a)).ToList();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String ma = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.KhachHangs.Where(s => s.MaKhachHang == ma).First();
            txtCMND.Text = obj.CMND.ToString();
            txtGT.Text = obj.GioiTinh;
            txtMaKhach.Text = obj.MaKhachHang;
            txtSDT.Text = obj.SDT.ToString();
            txtTenKhach.Text = obj.TenKhach;
            txtTuoi.Text = obj.Tuoi.ToString();
        }
    }
}
