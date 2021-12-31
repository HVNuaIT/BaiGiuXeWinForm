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
    public partial class FormDK : Form
    {
        public FormDK()
        {
            InitializeComponent();
        }
        QuanLyBaiGiuXe db = new QuanLyBaiGiuXe();
        private void bntĐK_Click(object sender, EventArgs e)
        {
            User s = new User();
            s.TenNguoiDung = txtTen.Text;
            s.GioiTinh = txtGT.Checked;
            s.MatKhau = txtMk.Text;
            s.TaiKhoan = txtTK.Text;
            if (txtTK.Text == String.Empty)
            {
                MessageBox.Show("Tài Khoản Trống"); return;
            }
             else if (txtMk.Text == String.Empty)
            {
                MessageBox.Show("Mật Khẩu Trống"); return;
            }
            if (txtMk.Text != txtMK1.Text)
            {
                MessageBox.Show("Mật Khẩu Không Trùng Khớp"); return;
            }
   
            s.NgaySinh = dtngay.Value;
            s.SDT = Convert.ToInt32(txtSDT.Text);
            s.IdChucVu = 2;
            var ds = db.Users.Where(a => a.TaiKhoan.Equals(txtTK.Text)).ToList();
            if (ds.Count > 0)
            {
                MessageBox.Show("Tài Khoản Đã Tồn Tại"); return;
            }

            db.Users.Add(s);
            db.SaveChanges();
            MessageBox.Show("Đăng Kí Thành Công", "Thông Báo");
            reset();
        }
        void reset()
        {
            txtGT.Text = String.Empty;
            txtMk.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtTen.Text = String.Empty;
            txtTK.Text = String.Empty;
            dtngay.Text = String.Empty;
            txtMK1.Text = String.Empty;
        }
        private void bntQuayLại_Click(object sender, EventArgs e)
        {
            Form x = new FormLogin();
            x.Show();
            this.Hide();
        }

        private void bntThoát_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Có Muốn Thoát Khỏi Chương Trình Không ?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked)
            {
                txtMk.PasswordChar = '\0'; 
                txtMK1.PasswordChar = '\0';
            }
            else
            {
                txtMk.PasswordChar = '*';
                txtMK1.PasswordChar = '*';
            }
        }

       
    }
}
