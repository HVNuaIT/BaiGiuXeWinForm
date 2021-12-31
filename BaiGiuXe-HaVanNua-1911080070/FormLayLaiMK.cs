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
    public partial class FormLayLaiMK : Form
    {
        public FormLayLaiMK()
        {
            InitializeComponent();
        }
        QuanLyBaiGiuXe db = new QuanLyBaiGiuXe();
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

        private void bntĐK_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = db.Users.Where(x => x.TaiKhoan == txtTK.Text).First();


                if (ds.TaiKhoan == txtTK.Text && ds.CMND == Convert.ToInt32( txtCMND.Text))
                {
                    User s = new User();
                    s.MatKhau = txtMk.Text;
                    if (txtMk.Text != txtMK1.Text)
                    {
                        MessageBox.Show("Mật Khẩu Không Chính Xác");
                        return;
                    }
                    db.SaveChanges();
                    reset();
                    MessageBox.Show("Lấy Lại Mật Khẩu Thành Công ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Láy Lại Mật Khẩu Không Thành Công!!");
            }

        }
        void reset()
        {
        
            txtMk.Text = String.Empty;
            txtCMND.Text = String.Empty;
            txtTen.Text = String.Empty;
            txtTK.Text = String.Empty;
            txtMK1.Text = String.Empty;
        }
    }
}
