using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BaiGiuXe_HaVanNua_1911080070.FormLogin;

namespace BaiGiuXe_HaVanNua_1911080070
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            Phanquyen();
        }
        void Phanquyen()
        {
            if (KiemTra.check == false)
            {
                quanLyNhânViênToolStripMenuItem1.Enabled = false;
            }
        }
        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Có Muốn Đăng Xuất Khỏi Hệ Thống Không", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }

            Form x = new FormLogin();
            x.Show();
            this.Hide();
        }

        private void quanLyNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form x = new FormQLTK();
            x.Show();
            this.Hide();
        }

        private void quanLyKhachHangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form x = new FormKhachHang();
            x.Show();
            this.Hide();
        }

        private void quanLyVeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form x = new FormBangGia();
            x.Show();
            this.Hide();
        }

        private void quanLyBaiĐôToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormBai();
            x.Show();
            this.Hide();
        }

        private void quanLyXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormXeRaVao();
            x.Show();
            this.Hide();
        }

        private void quanLyTheXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormTheXe();
            x.Show();
            this.Hide();
        }

        private void thôngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormThongKeDT();
            x.Show();
            this.Hide();
        }

        private void thôngKêSôLươngXeTrongBaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormThongKeBX();
            x.Show();
            this.Hide();
        }
    }
}
