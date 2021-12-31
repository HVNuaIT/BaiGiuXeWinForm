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
    public partial class FormBangGia : Form
    {
        public FormBangGia()
        {
            InitializeComponent();
        }

        QuanLyBaiGiuXe db = new QuanLyBaiGiuXe();

        private void bntThem_Click(object sender, EventArgs e)
        {

            BangGia s = new BangGia();
            s.LoaiXe = txtLoaiXe.Text;
            s.DonGia = Convert.ToDouble(txtGia.Text);
            s.Khu = txtKhu.Text;
            s.SoCho = Convert.ToInt32(txtCho.Text);
          
            db.BangGias.Add(s);
            db.SaveChanges();
            Loaddata();
            reset();
            MessageBox.Show(" Thêm Thành Công" + " " + s.LoaiXe + " " + "Vào Danh Sách");
        }
        void reset()
        {
            txtLoaiXe.Text = String.Empty;
            txtGia.Text = String.Empty;
            txtCho.Text = String.Empty;
            txtKhu.Text = String.Empty;
        }
        void Loaddata()
        {
            dataGridView1.DataSource = db.BangGias.ToList();
        }
        private void bntSua_Click(object sender, EventArgs e)
        {
            String ma = txtLoaiXe.Text;
            var s = db.BangGias.Where(a => a.LoaiXe.Contains(ma)).First();
            s.LoaiXe = txtLoaiXe.Text;
            s.DonGia = Convert.ToDouble(txtGia.Text);
            s.Khu = txtKhu.Text;
            s.SoCho = Convert.ToInt32(txtCho.Text);
            db.SaveChanges();
            Loaddata();
            MessageBox.Show("Sửa Thành Công", "Thống Báo");
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            String ma = txtLoaiXe.Text;
            var s = db.BangGias.Where(a => a.LoaiXe.Contains(ma)).First();
            DialogResult dt = MessageBox.Show("Bạn Có Muốn Xóa Không ", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            db.BangGias.Remove(s);
            db.SaveChanges();
            Loaddata();

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String  ma = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.BangGias.Where(s => s.LoaiXe.Contains(ma)).First();
            txtCho.Text = obj.SoCho.ToString();
            txtGia.Text = obj.DonGia.ToString();
            txtKhu.Text = obj.Khu;
            txtLoaiXe.Text = obj.LoaiXe;
        }

        private void FormBangGia_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            String a = txtTim.Text.Trim();
            

            var ds = db.BangGias.Where(s => s.LoaiXe.Contains(a)).ToList();
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
            Loaddata();
        }
    }
}
