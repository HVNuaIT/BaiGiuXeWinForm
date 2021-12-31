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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        QuanLyBaiGiuXe db = new QuanLyBaiGiuXe();


        private void bntDN_Click(object sender, EventArgs e)
        {

            try
            {
                var ds = db.Users.Where(x => x.TaiKhoan == txtTK.Text).FirstOrDefault();


                if (ds.TaiKhoan == txtTK.Text && ds.MatKhau == txtMK.Text && ds.IdChucVu ==1)
                {
                    MessageBox.Show("Chúc Mừng Đã Đăng Nhập Thành Công Với Quyền Admin !!");
                    Form admin = new FormTrangChu();
                    admin.Show();
                    KiemTra.check = true;
                    this.Hide();
                }
                else if (ds.TaiKhoan == txtTK.Text && ds.MatKhau == txtMK.Text && ds.IdChucVu != 1)
                {
                    MessageBox.Show("Chúc Mừng Đã Đăng Nhập Thành Công Quyền User !!");
                    Form nv = new FormTrangChu();
                    KiemTra.check = false;
                    nv.Show();
                    this.Hide();
                }


            }
                catch (Exception )
            {
                MessageBox.Show("Đăng Nhập Thất Bại Rồi !!");
            }
        }
        public static class KiemTra
        {
            public static bool check { get; set; } = true;

        }

        private void cbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThi.Checked)
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Có Muốn Thoát Khỏi Chương Trình Không ?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void lbQuenMk_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Có Muốn Lấy Lại Mật Khẩu Không?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }

            Form x = new FormLayLaiMK();
            x.Show();
            this.Hide();
        }

        private void lbDK_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Có Muốn Đăng Kí Tài Khoản Mới Không ?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }

            Form x = new FormDK();
            x.Show();
            this.Hide();
        }
    }

}


