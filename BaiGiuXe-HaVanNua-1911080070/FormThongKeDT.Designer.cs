
namespace BaiGiuXe_HaVanNua_1911080070
{
    partial class FormThongKeDT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.Ngay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bntLamMoi = new System.Windows.Forms.Button();
            this.bntThoát = new System.Windows.Forms.Button();
            this.bntQuayLại = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtDoanhThu);
            this.groupBox1.Controls.Add(this.Ngay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 100);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Thống Kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tháng Cần Thống Kê";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(369, 26);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 33;
            this.btnTim.Text = "Thống Kê";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(122, 64);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(222, 20);
            this.txtDoanhThu.TabIndex = 34;
            // 
            // Ngay
            // 
            this.Ngay.Location = new System.Drawing.Point(122, 25);
            this.Ngay.Name = "Ngay";
            this.Ngay.Size = new System.Drawing.Size(222, 20);
            this.Ngay.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Doanh Thu";
            // 
            // bntLamMoi
            // 
            this.bntLamMoi.Location = new System.Drawing.Point(157, 342);
            this.bntLamMoi.Name = "bntLamMoi";
            this.bntLamMoi.Size = new System.Drawing.Size(75, 23);
            this.bntLamMoi.TabIndex = 45;
            this.bntLamMoi.Text = "Làm Mới";
            this.bntLamMoi.UseVisualStyleBackColor = true;
            this.bntLamMoi.Click += new System.EventHandler(this.bntLamMoi_Click);
            // 
            // bntThoát
            // 
            this.bntThoát.Location = new System.Drawing.Point(437, 342);
            this.bntThoát.Name = "bntThoát";
            this.bntThoát.Size = new System.Drawing.Size(75, 23);
            this.bntThoát.TabIndex = 43;
            this.bntThoát.Text = "Thoát";
            this.bntThoát.UseVisualStyleBackColor = true;
            this.bntThoát.Click += new System.EventHandler(this.bntThoát_Click);
            // 
            // bntQuayLại
            // 
            this.bntQuayLại.Location = new System.Drawing.Point(295, 342);
            this.bntQuayLại.Name = "bntQuayLại";
            this.bntQuayLại.Size = new System.Drawing.Size(75, 23);
            this.bntQuayLại.TabIndex = 42;
            this.bntQuayLại.Text = "Quay Lại";
            this.bntQuayLại.UseVisualStyleBackColor = true;
            this.bntQuayLại.Click += new System.EventHandler(this.bntQuayLại_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // bntExcel
            // 
            this.bntExcel.Location = new System.Drawing.Point(12, 342);
            this.bntExcel.Name = "bntExcel";
            this.bntExcel.Size = new System.Drawing.Size(75, 23);
            this.bntExcel.TabIndex = 40;
            this.bntExcel.Text = "&Excel";
            this.bntExcel.UseVisualStyleBackColor = true;
            this.bntExcel.Click += new System.EventHandler(this.bntExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 47;
            // 
            // FormThongKeDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 380);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntLamMoi);
            this.Controls.Add(this.bntThoát);
            this.Controls.Add(this.bntQuayLại);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntExcel);
            this.Name = "FormThongKeDT";
            this.Text = "FormThongKeDT";
            this.Load += new System.EventHandler(this.FormThongKeDT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.DateTimePicker Ngay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntLamMoi;
        private System.Windows.Forms.Button bntThoát;
        private System.Windows.Forms.Button bntQuayLại;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}