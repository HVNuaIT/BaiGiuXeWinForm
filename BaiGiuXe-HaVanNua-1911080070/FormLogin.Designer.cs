
namespace BaiGiuXe_HaVanNua_1911080070
{
    partial class FormLogin
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
            this.txtTK = new System.Windows.Forms.TextBox();
            this.bntDN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntThoat = new System.Windows.Forms.Button();
            this.cbHienThi = new System.Windows.Forms.CheckBox();
            this.lbQuenMk = new System.Windows.Forms.Label();
            this.lbDK = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(172, 50);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(92, 20);
            this.txtTK.TabIndex = 0;
            // 
            // bntDN
            // 
            this.bntDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntDN.Location = new System.Drawing.Point(88, 139);
            this.bntDN.Name = "bntDN";
            this.bntDN.Size = new System.Drawing.Size(75, 23);
            this.bntDN.TabIndex = 1;
            this.bntDN.Text = "Đăng Nhập ";
            this.bntDN.UseVisualStyleBackColor = true;
            this.bntDN.Click += new System.EventHandler(this.bntDN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(85, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Khoản";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(172, 87);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(92, 20);
            this.txtMK.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(85, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ĐĂNG NHẬP HỆ THỐNG QUẢN LÝ BÃI GIỮ XE ";
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(260, 139);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 6;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // cbHienThi
            // 
            this.cbHienThi.AutoSize = true;
            this.cbHienThi.BackColor = System.Drawing.Color.Transparent;
            this.cbHienThi.ForeColor = System.Drawing.Color.Cyan;
            this.cbHienThi.Location = new System.Drawing.Point(244, 116);
            this.cbHienThi.Name = "cbHienThi";
            this.cbHienThi.Size = new System.Drawing.Size(115, 17);
            this.cbHienThi.TabIndex = 8;
            this.cbHienThi.Text = "Hiển Thị Mật Khẩu";
            this.cbHienThi.UseVisualStyleBackColor = false;
            this.cbHienThi.CheckedChanged += new System.EventHandler(this.cbHienThi_CheckedChanged);
            // 
            // lbQuenMk
            // 
            this.lbQuenMk.AutoSize = true;
            this.lbQuenMk.BackColor = System.Drawing.Color.Transparent;
            this.lbQuenMk.ForeColor = System.Drawing.Color.Cyan;
            this.lbQuenMk.Location = new System.Drawing.Point(141, 165);
            this.lbQuenMk.Name = "lbQuenMk";
            this.lbQuenMk.Size = new System.Drawing.Size(82, 13);
            this.lbQuenMk.TabIndex = 9;
            this.lbQuenMk.Text = "Quên Mật Khẩu";
            this.lbQuenMk.Click += new System.EventHandler(this.lbQuenMk_Click);
            // 
            // lbDK
            // 
            this.lbDK.AutoSize = true;
            this.lbDK.BackColor = System.Drawing.Color.Transparent;
            this.lbDK.ForeColor = System.Drawing.Color.Cyan;
            this.lbDK.Location = new System.Drawing.Point(229, 165);
            this.lbDK.Name = "lbDK";
            this.lbDK.Size = new System.Drawing.Size(58, 13);
            this.lbDK.TabIndex = 10;
            this.lbDK.Text = "/ Đăng Kí ";
            this.lbDK.Click += new System.EventHandler(this.lbDK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BaiGiuXe_HaVanNua_1911080070.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BaiGiuXe_HaVanNua_1911080070.Properties.Resources.SSS;
            this.ClientSize = new System.Drawing.Size(397, 191);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbDK);
            this.Controls.Add(this.lbQuenMk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbHienThi);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.bntDN);
            this.Controls.Add(this.bntThoat);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button bntDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.CheckBox cbHienThi;
        private System.Windows.Forms.Label lbQuenMk;
        private System.Windows.Forms.Label lbDK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

