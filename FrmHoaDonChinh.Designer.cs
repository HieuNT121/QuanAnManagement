namespace QuanLyQuanAn
{
    partial class FrmHoaDonChinh
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.btDatDon = new System.Windows.Forms.Button();
            this.btCapNhatThongTin = new System.Windows.Forms.Button();
            this.btHoaDonThanhToan = new System.Windows.Forms.Button();
            this.btHoaDonNhap = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gray;
            this.panel_top.Controls.Add(this.btDatDon);
            this.panel_top.Controls.Add(this.btCapNhatThongTin);
            this.panel_top.Controls.Add(this.btHoaDonThanhToan);
            this.panel_top.Controls.Add(this.btHoaDonNhap);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1034, 110);
            this.panel_top.TabIndex = 0;
            // 
            // btDatDon
            // 
            this.btDatDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDatDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatDon.Location = new System.Drawing.Point(32, 17);
            this.btDatDon.Name = "btDatDon";
            this.btDatDon.Size = new System.Drawing.Size(146, 78);
            this.btDatDon.TabIndex = 2;
            this.btDatDon.Text = "Đặt đơn";
            this.btDatDon.UseVisualStyleBackColor = false;
            this.btDatDon.Click += new System.EventHandler(this.btDatDon_Click);
            // 
            // btCapNhatThongTin
            // 
            this.btCapNhatThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCapNhatThongTin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhatThongTin.Location = new System.Drawing.Point(567, 17);
            this.btCapNhatThongTin.Name = "btCapNhatThongTin";
            this.btCapNhatThongTin.Size = new System.Drawing.Size(162, 78);
            this.btCapNhatThongTin.TabIndex = 1;
            this.btCapNhatThongTin.Text = "Cập nhật thông tin";
            this.btCapNhatThongTin.UseVisualStyleBackColor = false;
            this.btCapNhatThongTin.Click += new System.EventHandler(this.btCapNhatHoaDon_Click);
            // 
            // btHoaDonThanhToan
            // 
            this.btHoaDonThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btHoaDonThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoaDonThanhToan.Location = new System.Drawing.Point(396, 17);
            this.btHoaDonThanhToan.Name = "btHoaDonThanhToan";
            this.btHoaDonThanhToan.Size = new System.Drawing.Size(149, 78);
            this.btHoaDonThanhToan.TabIndex = 1;
            this.btHoaDonThanhToan.Text = "Hóa đơn thanh toán";
            this.btHoaDonThanhToan.UseVisualStyleBackColor = false;
            this.btHoaDonThanhToan.Click += new System.EventHandler(this.btHoaDonThanhToan_Click);
            // 
            // btHoaDonNhap
            // 
            this.btHoaDonNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btHoaDonNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoaDonNhap.Location = new System.Drawing.Point(213, 17);
            this.btHoaDonNhap.Name = "btHoaDonNhap";
            this.btHoaDonNhap.Size = new System.Drawing.Size(152, 78);
            this.btHoaDonNhap.TabIndex = 0;
            this.btHoaDonNhap.Text = "Hóa đơn nhập ";
            this.btHoaDonNhap.UseVisualStyleBackColor = false;
            this.btHoaDonNhap.Click += new System.EventHandler(this.btHoaDonNhap_Click);
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 110);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1034, 600);
            this.panel_body.TabIndex = 1;
            // 
            // FrmHoaDonChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 710);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 40);
            this.Name = "FrmHoaDonChinh";
            this.Text = "FrmHoaDonChinh";
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btHoaDonThanhToan;
        private System.Windows.Forms.Button btHoaDonNhap;
        private System.Windows.Forms.Button btCapNhatThongTin;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btDatDon;
    }
}