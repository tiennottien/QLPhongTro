﻿namespace QLPhongTro.ChildForm
{
    partial class frmKH
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
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbContent = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pblBottom = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHKTT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbContent.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbExit
            // 
            this.ptbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExit.Image = global::QLPhongTro.Properties.Resources.close;
            this.ptbExit.Location = new System.Drawing.Point(518, 7);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(20, 20);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 0;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::QLPhongTro.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbContent
            // 
            this.grbContent.Controls.Add(this.txtTen);
            this.grbContent.Controls.Add(this.txtTenDem);
            this.grbContent.Controls.Add(this.label2);
            this.grbContent.Controls.Add(this.txtHKTT);
            this.grbContent.Controls.Add(this.txtQueQuan);
            this.grbContent.Controls.Add(this.label7);
            this.grbContent.Controls.Add(this.txtDienThoai);
            this.grbContent.Controls.Add(this.label6);
            this.grbContent.Controls.Add(this.txtCMND);
            this.grbContent.Controls.Add(this.label5);
            this.grbContent.Controls.Add(this.txtHo);
            this.grbContent.Controls.Add(this.label4);
            this.grbContent.Controls.Add(this.label1);
            this.grbContent.Controls.Add(this.label3);
            this.grbContent.Controls.Add(this.btnHuy);
            this.grbContent.Controls.Add(this.btnXacNhan);
            this.grbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbContent.Location = new System.Drawing.Point(10, 30);
            this.grbContent.Name = "grbContent";
            this.grbContent.Size = new System.Drawing.Size(530, 250);
            this.grbContent.TabIndex = 16;
            this.grbContent.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(260, 192);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 23);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(163, 192);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(96, 23);
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(540, 30);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(10, 250);
            this.pnlRight.TabIndex = 12;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 30);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(10, 250);
            this.pnlLeft.TabIndex = 13;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.ptbExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(550, 30);
            this.pnlTop.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(47, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Thêm mới khách hàng";
            // 
            // pblBottom
            // 
            this.pblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblBottom.Location = new System.Drawing.Point(0, 280);
            this.pblBottom.Name = "pblBottom";
            this.pblBottom.Size = new System.Drawing.Size(550, 10);
            this.pblBottom.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Họ";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(119, 44);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(68, 20);
            this.txtHo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên đệm";
            // 
            // txtTenDem
            // 
            this.txtTenDem.Location = new System.Drawing.Point(276, 44);
            this.txtTenDem.Name = "txtTenDem";
            this.txtTenDem.Size = new System.Drawing.Size(68, 20);
            this.txtTenDem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(363, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(408, 44);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(68, 20);
            this.txtTen.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(119, 70);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(357, 20);
            this.txtCMND.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(119, 96);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(357, 20);
            this.txtDienThoai.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quê quán";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(119, 122);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(357, 20);
            this.txtQueQuan.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "HKTT";
            // 
            // txtHKTT
            // 
            this.txtHKTT.Location = new System.Drawing.Point(119, 148);
            this.txtHKTT.Name = "txtHKTT";
            this.txtHKTT.Size = new System.Drawing.Size(357, 20);
            this.txtHKTT.TabIndex = 7;
            // 
            // frmKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(550, 290);
            this.Controls.Add(this.grbContent);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pblBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKH";
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbContent.ResumeLayout(false);
            this.grbContent.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbContent;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtTenDem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHKTT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pblBottom;
    }
}