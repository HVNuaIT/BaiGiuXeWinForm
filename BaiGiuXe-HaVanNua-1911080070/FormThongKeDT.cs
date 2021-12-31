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
    public partial class FormThongKeDT : Form
    {
        public FormThongKeDT()
        {
            InitializeComponent();
        }
        QuanLyBaiGiuXe db = new QuanLyBaiGiuXe();
        private void btnTim_Click(object sender, EventArgs e)
        {
            DateTime a = Ngay.Value;
            var ds = db.PhieuThanhToans.Where(s => s.NgayVao.Value.Month == a.Month).ToList();
            dataGridView1.DataSource = ds;
            if(ds.Count <= 0)
            {
                MessageBox.Show("Không Có Doanh Thu Trong Tháng " + a.Month + " Này ");

                dataGridView1.DataSource = null;
                return;
            }
            MessageBox.Show("Đã Thống Kê Doanh Thu trong Tháng :" + a.Month);
            var dsDH = db.PhieuThanhToans.Where(s => s.NgayVao.Value.Month == a.Month).Select(s => s.ThanhTien);
            double kq = (double)dsDH.Sum();
            txtDoanhThu.Text = kq.ToString();
        }

        private void bntExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        } 

        private void bntLamMoi_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void bntQuayLại_Click(object sender, EventArgs e)
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

        private void bntThoát_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Ban Có Muốn Thoát Chương Trình ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormThongKeDT_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            dataGridView1.DataSource = db.PhieuThanhToans.ToList();
        }
    }
}
