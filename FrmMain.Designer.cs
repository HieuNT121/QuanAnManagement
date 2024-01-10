namespace QuanLyQuanAn
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btQuantriHeThong = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btQuanLyDanhMuc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btQuanLyKho = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btQuanlyHoaDon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBaoCaoThongKe = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_top = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.sideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.Teal;
            this.sideBar.Controls.Add(this.panel1);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Controls.Add(this.panel6);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(266, 750);
            this.sideBar.MinimumSize = new System.Drawing.Size(52, 610);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(266, 750);
            this.sideBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 169);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý quán ăn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::QuanLyQuanAn.Properties.Resources.restaurant;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(80, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btQuantriHeThong);
            this.panel5.Location = new System.Drawing.Point(3, 178);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(263, 101);
            this.panel5.TabIndex = 5;
            // 
            // btQuantriHeThong
            // 
            this.btQuantriHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btQuantriHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuantriHeThong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuantriHeThong.Location = new System.Drawing.Point(9, 33);
            this.btQuantriHeThong.Name = "btQuantriHeThong";
            this.btQuantriHeThong.Size = new System.Drawing.Size(250, 45);
            this.btQuantriHeThong.TabIndex = 1;
            this.btQuantriHeThong.Text = "  1.  Quản trị Hệ thống";
            this.btQuantriHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuantriHeThong.UseVisualStyleBackColor = false;
            this.btQuantriHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btQuanLyDanhMuc);
            this.panel6.Location = new System.Drawing.Point(3, 285);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(263, 93);
            this.panel6.TabIndex = 2;
            // 
            // btQuanLyDanhMuc
            // 
            this.btQuanLyDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btQuanLyDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuanLyDanhMuc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanLyDanhMuc.Location = new System.Drawing.Point(7, 21);
            this.btQuanLyDanhMuc.Name = "btQuanLyDanhMuc";
            this.btQuanLyDanhMuc.Size = new System.Drawing.Size(250, 45);
            this.btQuanLyDanhMuc.TabIndex = 3;
            this.btQuanLyDanhMuc.Text = "  2.  Quản lý Danh mục";
            this.btQuanLyDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuanLyDanhMuc.UseVisualStyleBackColor = false;
            this.btQuanLyDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btQuanLyKho);
            this.panel3.Location = new System.Drawing.Point(3, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 102);
            this.panel3.TabIndex = 5;
            // 
            // btQuanLyKho
            // 
            this.btQuanLyKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btQuanLyKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuanLyKho.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanLyKho.Location = new System.Drawing.Point(7, 26);
            this.btQuanLyKho.Name = "btQuanLyKho";
            this.btQuanLyKho.Size = new System.Drawing.Size(250, 45);
            this.btQuanLyKho.TabIndex = 4;
            this.btQuanLyKho.Text = "  3.  Quản lý Kho";
            this.btQuanLyKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuanLyKho.UseVisualStyleBackColor = false;
            this.btQuanLyKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btQuanlyHoaDon);
            this.panel4.Location = new System.Drawing.Point(3, 492);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 94);
            this.panel4.TabIndex = 5;
            // 
            // btQuanlyHoaDon
            // 
            this.btQuanlyHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btQuanlyHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuanlyHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanlyHoaDon.Location = new System.Drawing.Point(7, 23);
            this.btQuanlyHoaDon.Name = "btQuanlyHoaDon";
            this.btQuanlyHoaDon.Size = new System.Drawing.Size(250, 45);
            this.btQuanlyHoaDon.TabIndex = 5;
            this.btQuanlyHoaDon.Text = "  4.  Quản lý Hóa đơn";
            this.btQuanlyHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuanlyHoaDon.UseVisualStyleBackColor = false;
            this.btQuanlyHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btBaoCaoThongKe);
            this.panel2.Location = new System.Drawing.Point(3, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 85);
            this.panel2.TabIndex = 1;
            // 
            // btBaoCaoThongKe
            // 
            this.btBaoCaoThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btBaoCaoThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaoCaoThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaoCaoThongKe.Location = new System.Drawing.Point(7, 17);
            this.btBaoCaoThongKe.Name = "btBaoCaoThongKe";
            this.btBaoCaoThongKe.Size = new System.Drawing.Size(250, 45);
            this.btBaoCaoThongKe.TabIndex = 2;
            this.btBaoCaoThongKe.Text = "  5.  Báo cáo thống kê";
            this.btBaoCaoThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBaoCaoThongKe.UseVisualStyleBackColor = false;
            this.btBaoCaoThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.btnExit);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(266, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1072, 40);
            this.panel_top.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(987, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(266, 40);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1072, 710);
            this.panel_body.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.sideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btQuantriHeThong;
        private System.Windows.Forms.Button btBaoCaoThongKe;
        private System.Windows.Forms.Button btQuanLyDanhMuc;
        private System.Windows.Forms.Button btQuanLyKho;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btQuanlyHoaDon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btnExit;
    }
}

