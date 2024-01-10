namespace QuanLyQuanAn
{
    partial class FrmDanhMucChinh
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
            this.btDanhSachBan = new System.Windows.Forms.Button();
            this.btDanhSachMonAn = new System.Windows.Forms.Button();
            this.btDanhSachLoaiMonAn = new System.Windows.Forms.Button();
            this.btDanhSachNhaCungCap = new System.Windows.Forms.Button();
            this.btDanhSachKhachHang = new System.Windows.Forms.Button();
            this.btDanhSachNhanVien = new System.Windows.Forms.Button();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gray;
            this.panel_top.Controls.Add(this.btDanhSachBan);
            this.panel_top.Controls.Add(this.btDanhSachMonAn);
            this.panel_top.Controls.Add(this.btDanhSachLoaiMonAn);
            this.panel_top.Controls.Add(this.btDanhSachNhaCungCap);
            this.panel_top.Controls.Add(this.btDanhSachKhachHang);
            this.panel_top.Controls.Add(this.btDanhSachNhanVien);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1034, 110);
            this.panel_top.TabIndex = 0;
            // 
            // btDanhSachBan
            // 
            this.btDanhSachBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDanhSachBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDanhSachBan.Location = new System.Drawing.Point(864, 12);
            this.btDanhSachBan.Name = "btDanhSachBan";
            this.btDanhSachBan.Size = new System.Drawing.Size(132, 76);
            this.btDanhSachBan.TabIndex = 4;
            this.btDanhSachBan.Text = "Danh sách bàn";
            this.btDanhSachBan.UseVisualStyleBackColor = false;
            this.btDanhSachBan.Click += new System.EventHandler(this.btDanhSachBan_Click);
            // 
            // btDanhSachMonAn
            // 
            this.btDanhSachMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDanhSachMonAn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDanhSachMonAn.Location = new System.Drawing.Point(696, 12);
            this.btDanhSachMonAn.Name = "btDanhSachMonAn";
            this.btDanhSachMonAn.Size = new System.Drawing.Size(132, 76);
            this.btDanhSachMonAn.TabIndex = 3;
            this.btDanhSachMonAn.Text = "Danh sách món ăn";
            this.btDanhSachMonAn.UseVisualStyleBackColor = false;
            this.btDanhSachMonAn.Click += new System.EventHandler(this.btDanhSachMonAn_Click);
            // 
            // btDanhSachLoaiMonAn
            // 
            this.btDanhSachLoaiMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDanhSachLoaiMonAn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDanhSachLoaiMonAn.Location = new System.Drawing.Point(525, 12);
            this.btDanhSachLoaiMonAn.Name = "btDanhSachLoaiMonAn";
            this.btDanhSachLoaiMonAn.Size = new System.Drawing.Size(141, 76);
            this.btDanhSachLoaiMonAn.TabIndex = 2;
            this.btDanhSachLoaiMonAn.Text = "Danh sách loại món ăn";
            this.btDanhSachLoaiMonAn.UseVisualStyleBackColor = false;
            this.btDanhSachLoaiMonAn.Click += new System.EventHandler(this.btDanhSachPhanLoaiMonAn_Click);
            // 
            // btDanhSachNhaCungCap
            // 
            this.btDanhSachNhaCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDanhSachNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDanhSachNhaCungCap.Location = new System.Drawing.Point(351, 12);
            this.btDanhSachNhaCungCap.Name = "btDanhSachNhaCungCap";
            this.btDanhSachNhaCungCap.Size = new System.Drawing.Size(132, 76);
            this.btDanhSachNhaCungCap.TabIndex = 1;
            this.btDanhSachNhaCungCap.Text = "Danh sách nhà cung cấp";
            this.btDanhSachNhaCungCap.UseVisualStyleBackColor = false;
            this.btDanhSachNhaCungCap.Click += new System.EventHandler(this.btDanhSachNhaCungCap_Click);
            // 
            // btDanhSachKhachHang
            // 
            this.btDanhSachKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDanhSachKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDanhSachKhachHang.Location = new System.Drawing.Point(192, 12);
            this.btDanhSachKhachHang.Name = "btDanhSachKhachHang";
            this.btDanhSachKhachHang.Size = new System.Drawing.Size(132, 76);
            this.btDanhSachKhachHang.TabIndex = 1;
            this.btDanhSachKhachHang.Text = "Danh sách khách hàng";
            this.btDanhSachKhachHang.UseVisualStyleBackColor = false;
            this.btDanhSachKhachHang.Click += new System.EventHandler(this.btDanhSachKhachHang_Click);
            // 
            // btDanhSachNhanVien
            // 
            this.btDanhSachNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDanhSachNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDanhSachNhanVien.Location = new System.Drawing.Point(25, 12);
            this.btDanhSachNhanVien.Name = "btDanhSachNhanVien";
            this.btDanhSachNhanVien.Size = new System.Drawing.Size(141, 76);
            this.btDanhSachNhanVien.TabIndex = 0;
            this.btDanhSachNhanVien.Text = "Danh sách nhân viên";
            this.btDanhSachNhanVien.UseVisualStyleBackColor = false;
            this.btDanhSachNhanVien.Click += new System.EventHandler(this.btDanhSachNhanVien_Click);
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 110);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1034, 600);
            this.panel_body.TabIndex = 1;
            // 
            // FrmDanhMucChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 710);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 40);
            this.Name = "FrmDanhMucChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmDanhMucChinh";
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btDanhSachKhachHang;
        private System.Windows.Forms.Button btDanhSachNhanVien;
        private System.Windows.Forms.Button btDanhSachNhaCungCap;
        private System.Windows.Forms.Button btDanhSachMonAn;
        private System.Windows.Forms.Button btDanhSachLoaiMonAn;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btDanhSachBan;
    }
}