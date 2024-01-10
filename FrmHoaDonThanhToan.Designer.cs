namespace QuanLyQuanAn
{
    partial class FrmHoaDonThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonThanhToan));
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaKhachHang = new System.Windows.Forms.TextBox();
            this.dtgvDanhSachHoaDonThanhToan = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaNhanVien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMaHoaDon = new System.Windows.Forms.TextBox();
            this.btXuatHoaDon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDonThanhToan)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // tbMaBan
            // 
            this.tbMaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaBan.Location = new System.Drawing.Point(159, 124);
            this.tbMaBan.Name = "tbMaBan";
            this.tbMaBan.Size = new System.Drawing.Size(190, 27);
            this.tbMaBan.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày thanh toán";
            // 
            // dtpkNgayThanhToan
            // 
            this.dtpkNgayThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayThanhToan.Location = new System.Drawing.Point(159, 225);
            this.dtpkNgayThanhToan.Name = "dtpkNgayThanhToan";
            this.dtpkNgayThanhToan.Size = new System.Drawing.Size(190, 30);
            this.dtpkNgayThanhToan.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã bàn";
            // 
            // tbMaKhachHang
            // 
            this.tbMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaKhachHang.Location = new System.Drawing.Point(159, 167);
            this.tbMaKhachHang.Name = "tbMaKhachHang";
            this.tbMaKhachHang.Size = new System.Drawing.Size(190, 27);
            this.tbMaKhachHang.TabIndex = 10;
            // 
            // dtgvDanhSachHoaDonThanhToan
            // 
            this.dtgvDanhSachHoaDonThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHoaDonThanhToan.Location = new System.Drawing.Point(427, 75);
            this.dtgvDanhSachHoaDonThanhToan.Name = "dtgvDanhSachHoaDonThanhToan";
            this.dtgvDanhSachHoaDonThanhToan.RowHeadersWidth = 51;
            this.dtgvDanhSachHoaDonThanhToan.RowTemplate.Height = 24;
            this.dtgvDanhSachHoaDonThanhToan.Size = new System.Drawing.Size(545, 288);
            this.dtgvDanhSachHoaDonThanhToan.TabIndex = 11;
            this.dtgvDanhSachHoaDonThanhToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachHoaDonThanhToan_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã nhân viên";
            // 
            // tbMaNhanVien
            // 
            this.tbMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNhanVien.Location = new System.Drawing.Point(159, 82);
            this.tbMaNhanVien.Name = "tbMaNhanVien";
            this.tbMaNhanVien.Size = new System.Drawing.Size(190, 27);
            this.tbMaNhanVien.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã hóa đơn";
            // 
            // tbMaHoaDon
            // 
            this.tbMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHoaDon.Location = new System.Drawing.Point(159, 39);
            this.tbMaHoaDon.Name = "tbMaHoaDon";
            this.tbMaHoaDon.Size = new System.Drawing.Size(190, 27);
            this.tbMaHoaDon.TabIndex = 17;
            // 
            // btXuatHoaDon
            // 
            this.btXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXuatHoaDon.Location = new System.Drawing.Point(789, 427);
            this.btXuatHoaDon.Name = "btXuatHoaDon";
            this.btXuatHoaDon.Size = new System.Drawing.Size(183, 34);
            this.btXuatHoaDon.TabIndex = 6;
            this.btXuatHoaDon.Text = "Xuất hóa đơn";
            this.btXuatHoaDon.UseVisualStyleBackColor = false;
            this.btXuatHoaDon.Click += new System.EventHandler(this.btXuatHoaDon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tổng tiền";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongTien.Location = new System.Drawing.Point(159, 280);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(190, 27);
            this.tbTongTien.TabIndex = 19;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel18);
            this.flowLayoutPanel2.Controls.Add(this.panel21);
            this.flowLayoutPanel2.Controls.Add(this.panel20);
            this.flowLayoutPanel2.Controls.Add(this.panel19);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(427, 389);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(248, 139);
            this.flowLayoutPanel2.TabIndex = 23;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnXem);
            this.panel18.Location = new System.Drawing.Point(3, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(107, 56);
            this.panel18.TabIndex = 8;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(12, 8);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(83, 40);
            this.btnXem.TabIndex = 10;
            this.btnXem.Text = "    Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnThem);
            this.panel21.Location = new System.Drawing.Point(116, 3);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(100, 56);
            this.panel21.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(5, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnXoa);
            this.panel20.Location = new System.Drawing.Point(3, 65);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(106, 56);
            this.panel20.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(9, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btnSua);
            this.panel19.Location = new System.Drawing.Point(115, 65);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(101, 56);
            this.panel19.TabIndex = 10;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(9, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 40);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.OriginAtMargins = true;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FrmHoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMaHoaDon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbMaNhanVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgvDanhSachHoaDonThanhToan);
            this.Controls.Add(this.tbMaKhachHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpkNgayThanhToan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btXuatHoaDon);
            this.Controls.Add(this.tbMaBan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHoaDonThanhToan";
            this.Text = "FrmHoaDonNhap";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDonThanhToan)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkNgayThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaKhachHang;
        private System.Windows.Forms.DataGridView dtgvDanhSachHoaDonThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaNhanVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMaHoaDon;
        private System.Windows.Forms.Button btXuatHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}