namespace QuanLyQuanAn
{
    partial class FrmHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonNhap));
            this.btnXem = new System.Windows.Forms.Button();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaNguyenLieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpkNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btXuatHoaDon = new System.Windows.Forms.Button();
            this.tbMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaNhanVien = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dtgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(523, 117);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(83, 40);
            this.btnXem.TabIndex = 10;
            this.btnXem.Text = "    Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // tbTongTien
            // 
            this.tbTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongTien.Location = new System.Drawing.Point(191, 332);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(190, 27);
            this.tbTongTien.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tổng tiền";
            // 
            // tbMaNguyenLieu
            // 
            this.tbMaNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNguyenLieu.Location = new System.Drawing.Point(191, 130);
            this.tbMaNguyenLieu.Name = "tbMaNguyenLieu";
            this.tbMaNguyenLieu.Size = new System.Drawing.Size(190, 27);
            this.tbMaNguyenLieu.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 28);
            this.label8.TabIndex = 34;
            this.label8.Text = "Mã nguyên liệu";
            // 
            // tbTenNguyenLieu
            // 
            this.tbTenNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNguyenLieu.Location = new System.Drawing.Point(191, 172);
            this.tbTenNguyenLieu.Name = "tbTenNguyenLieu";
            this.tbTenNguyenLieu.Size = new System.Drawing.Size(190, 27);
            this.tbTenNguyenLieu.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 28);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mã nhà cung cấp";
            // 
            // dtpkNgayNhap
            // 
            this.dtpkNgayNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayNhap.Location = new System.Drawing.Point(191, 290);
            this.dtpkNgayNhap.Name = "dtpkNgayNhap";
            this.dtpkNgayNhap.Size = new System.Drawing.Size(190, 30);
            this.dtpkNgayNhap.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tên nguyên liệu";
            // 
            // printDocument1
            // 
            this.printDocument1.OriginAtMargins = true;
            // 
            // btXuatHoaDon
            // 
            this.btXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXuatHoaDon.Location = new System.Drawing.Point(177, 453);
            this.btXuatHoaDon.Name = "btXuatHoaDon";
            this.btXuatHoaDon.Size = new System.Drawing.Size(183, 34);
            this.btXuatHoaDon.TabIndex = 26;
            this.btXuatHoaDon.Text = "Xuất hóa đơn";
            this.btXuatHoaDon.UseVisualStyleBackColor = false;
            this.btXuatHoaDon.Click += new System.EventHandler(this.btXuatHoaDon_Click);
            // 
            // tbMaNhaCungCap
            // 
            this.tbMaNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNhaCungCap.Location = new System.Drawing.Point(191, 211);
            this.tbMaNhaCungCap.Name = "tbMaNhaCungCap";
            this.tbMaNhaCungCap.Size = new System.Drawing.Size(190, 27);
            this.tbMaNhaCungCap.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã nhân viên";
            // 
            // tbMaNhanVien
            // 
            this.tbMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNhanVien.Location = new System.Drawing.Point(191, 249);
            this.tbMaNhanVien.Name = "tbMaNhanVien";
            this.tbMaNhanVien.Size = new System.Drawing.Size(190, 27);
            this.tbMaNhanVien.TabIndex = 40;
            // 
            // dtgvHoaDonNhap
            // 
            this.dtgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDonNhap.Location = new System.Drawing.Point(523, 172);
            this.dtgvHoaDonNhap.Name = "dtgvHoaDonNhap";
            this.dtgvHoaDonNhap.RowHeadersWidth = 51;
            this.dtgvHoaDonNhap.RowTemplate.Height = 24;
            this.dtgvHoaDonNhap.Size = new System.Drawing.Size(404, 146);
            this.dtgvHoaDonNhap.TabIndex = 41;
            this.dtgvHoaDonNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHoaDonNhap_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 28);
            this.label2.TabIndex = 42;
            this.label2.Text = "Thông tin nguyên liệu";
            // 
            // FrmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvHoaDonNhap);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.tbMaNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMaNguyenLieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTenNguyenLieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpkNgayNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btXuatHoaDon);
            this.Controls.Add(this.tbMaNhaCungCap);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHoaDonNhap";
            this.Text = "FrmHoaDonThanhToan";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDonNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaNguyenLieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTenNguyenLieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpkNgayNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btXuatHoaDon;
        private System.Windows.Forms.TextBox tbMaNhaCungCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaNhanVien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView dtgvHoaDonNhap;
        private System.Windows.Forms.Label label2;
    }
}