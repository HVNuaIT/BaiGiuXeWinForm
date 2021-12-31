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
    public partial class FormTheXe : Form
    {
        public FormTheXe()
        {
            InitializeComponent();
        }
        QuanLyBaiGiuXe db = new QuanLyBaiGiuXe();
        private void bntThem_Click(object sender, EventArgs e)
        {
            TheXe s = new TheXe();
            s.MaTheXe = txtMaThe.Text;
            s.KichHoat = CBKichHoat.Checked;
            s.MaKhach = "";
            s.MaXe = "";
            s.GioVao = null;
            db.TheXes.Add(s);
            db.SaveChanges();
            loadData();
        }

        private void FormTheXe_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            dataGridView1.DataSource = db.TheXes.ToList();
            List<KhachHang> dsKhach = db.KhachHangs.ToList();
            cbKH.DisplayMember = "TenKhach";
            cbKH.ValueMember = "MaKhachHang";
            cbKH.DataSource = dsKhach;
            cbKH.Enabled = false;
            txtMaxe.Enabled = false;

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbKH.Enabled = true;
            String ma = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.TheXes.Where(s => s.MaTheXe.Contains(ma)).First();
            txtMaThe.Text = obj.MaTheXe;
            txtMaxe.Text = obj.MaXe;
            cbKH.ValueMember = obj.MaKhach;
            CBKichHoat.Checked = obj.KichHoat.Value;
           
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            
            String ma = txtMaxe.Text;
            var s = db.TheXes.Where(a => a.MaXe.Contains(ma)).First();
            s.MaTheXe = txtMaThe.Text;
            s.KichHoat = CBKichHoat.Checked;
            s.MaKhach = cbKH.ValueMember;
            db.SaveChanges();
            loadData();
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            String a = txtTim.Text.Trim();


            var ds = db.TheXes.Where(s => s.MaTheXe.Contains(a)).ToList();
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
    }
}
