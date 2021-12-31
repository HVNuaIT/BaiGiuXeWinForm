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
    public partial class FormQLTK : Form
    {
        public FormQLTK()
        {
            InitializeComponent();
        }
        QuanLyBaiGiuXe db = new QuanLyBaiGiuXe();

        private void FormQLTK_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
        void Loaddata()
        {
            dataGridView1.DataSource = db.Users.ToList();
            List<ChucVu> dsCV = db.ChucVus.ToList();
            cbChucVu.DisplayMember = "ChucVu1";
            cbChucVu.ValueMember = "IdChucVu";
            cbChucVu.DataSource = dsCV;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {

            User s = new User();
            s.IdUser = Convert.ToInt32(txtIDUser.Text);
            s.TenNguoiDung = txtTen.Text;
            s.GioiTinh = txtGT.Checked;
            s.IdChucVu = Convert.ToInt32(cbChucVu.SelectedValue);
            s.MatKhau = txtMk.Text;
            s.TaiKhoan = txtTK.Text;
            s.NgaySinh = dtngay.Value;
            s.Tuoi = Convert.ToInt32(txtTuoi.Text);
            s.SDT = Convert.ToInt32(txtSDT.Text);
            s.CMND = Convert.ToInt32(txtCMND.Text);
            db.Users.Add(s);
            db.SaveChanges();
           Loaddata();
            reset();
            MessageBox.Show(" Thêm Thành Công"+" "+ s.TenNguoiDung+" "+"Vào Danh Sách");
        }

      

        private void bntXoa_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(txtIDUser.Text);
            var s = db.Users.Where(a => a.IdUser == ma).First();
            DialogResult dt = MessageBox.Show("Bạn Có Muốn Xóa Không ", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            db.Users.Remove(s);
            db.SaveChanges();
            Loaddata();
            reset();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(txtIDUser.Text);
            var s = db.Users.Where(a => a.IdUser == ma).First();
            s.IdUser = Convert.ToInt32(txtIDUser.Text);
            s.TenNguoiDung = txtTen.Text;
            s.GioiTinh = txtGT.Checked;
            s.IdChucVu = Convert.ToInt32(cbChucVu.SelectedValue);
            s.MatKhau = txtMk.Text;
            s.TaiKhoan = txtTK.Text;
            s.NgaySinh = dtngay.Value;
            s.Tuoi = Convert.ToInt32(txtTuoi.Text);
            s.SDT = Convert.ToInt32(txtSDT.Text);
            s.CMND = Convert.ToInt32(txtCMND.Text);
            db.SaveChanges();
            Loaddata();
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

        private void bntTim_Click(object sender, EventArgs e)
        {
            String a = txtTim.Text.Trim();
           
            
            var ds  = db.Users.Where(s => s.TenNguoiDung.Contains(a)).ToList();
           if (ds.Count > 0)
            {
                MessageBox.Show("Đã Tìm Thấy");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy "+txtTim.Text.ToString());
                dataGridView1.DataSource = null;
            }
           
            
        }

        private void BntLamMoi_Click(object sender, EventArgs e)
        {
            Loaddata();
        }
        void reset()
        {
            txtIDUser.Text = String.Empty;
            txtGT.Text = String.Empty;
            txtMk.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtTen.Text = String.Empty;
            txtTK.Text = String.Empty;
            dtngay.Text = String.Empty;
            cbChucVu.Text = String.Empty;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.Users.Where(s => s.IdUser == ma).First();
            txtIDUser.Text = obj.IdUser.ToString();
            txtGT.Checked = Convert.ToBoolean(obj.GioiTinh);
            txtMk.Text = obj.MatKhau;
            txtSDT.Text = obj.SDT.ToString();
            txtTen.Text = obj.TenNguoiDung;
            txtTK.Text = obj.TaiKhoan;
            dtngay.Text = obj.NgaySinh.ToString();
            cbChucVu.SelectedValue = obj.IdChucVu;
            txtTuoi.Text = obj.Tuoi.ToString();
            txtCMND.Text = obj.CMND.ToString();
        
        }

       
    }
}
