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
    public partial class FormBai : Form
    {
        public FormBai()
        {
            InitializeComponent();
        }
        QuanLyBaiGiuXe db = new QuanLyBaiGiuXe();
        private void bntThem_Click(object sender, EventArgs e)
        {
            Bai s = new Bai();
            s.MaBai = txtMaBai.Text;
            s.ViTri = txtViTri.Text;
            s.MaXe = "";
            db.Bais.Add(s);
            db.SaveChanges();
            MessageBox.Show("Thêm Vào Danh Sách Thành Công");
            loadData();
            reseset();
        }
        void loadData()
        {
            dataGridView1.DataSource = db.Bais.ToList();
       
        }
        
        private void FormBai_Load(object sender, EventArgs e)
        {
            loadData();
           
        }
     
        private void bntSua_Click(object sender, EventArgs e)
        {
            String ma = txtMaBai.Text;
            var s = db.Bais.Where(a=> a.MaBai.Contains(ma)).First();
            s.MaBai = txtMaBai.Text;
            s.ViTri = txtViTri.Text;
            db.SaveChanges();
            loadData();
            MessageBox.Show("Sửa Thành Công");
            reseset();

        }


        private void bntXoa_Click(object sender, EventArgs e)
        {
            String ma = txtMaBai.Text;
            var s = db.Bais.Where(a => a.MaBai.Contains(ma)).First();
            DialogResult dt = MessageBox.Show("Có Muốn Xóa Không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dt == DialogResult.No)
            {
                return;
            }
            db.Bais.Remove(s);
            db.SaveChanges();
            loadData();
            reseset();
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
           String  ma=(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.Bais.Where(s => s.MaBai.Contains(ma)).First();
            txtMaBai.Text = obj.MaBai;
            txtViTri.Text = obj.ViTri;
        }
        void reseset()
        {
            txtMaBai.Text = String.Empty;
            txtViTri.Text = String.Empty;
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            String a = txtTim.Text.Trim();


            var ds = db.Bais.Where(s => s.MaXe.Contains(a)).ToList();
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
