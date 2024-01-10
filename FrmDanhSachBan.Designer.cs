namespace QuanLyQuanAn
{
    partial class FrmDanhSachBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhSachBan));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dtgvDanhSachBan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachBan)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel18);
            this.flowLayoutPanel2.Controls.Add(this.panel21);
            this.flowLayoutPanel2.Controls.Add(this.panel20);
            this.flowLayoutPanel2.Controls.Add(this.panel19);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(51, 476);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(543, 73);
            this.flowLayoutPanel2.TabIndex = 37;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnXem);
            this.panel18.Location = new System.Drawing.Point(3, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(107, 56);
            this.panel18.TabIndex = 8;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnThem);
            this.panel21.Location = new System.Drawing.Point(116, 3);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(100, 56);
            this.panel21.TabIndex = 11;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnXoa);
            this.panel20.Location = new System.Drawing.Point(222, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(106, 56);
            this.panel20.TabIndex = 9;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btnSua);
            this.panel19.Location = new System.Drawing.Point(334, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(101, 56);
            this.panel19.TabIndex = 10;
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
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtgvDanhSachBan
            // 
            this.dtgvDanhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachBan.Location = new System.Drawing.Point(54, 170);
            this.dtgvDanhSachBan.Name = "dtgvDanhSachBan";
            this.dtgvDanhSachBan.RowHeadersWidth = 51;
            this.dtgvDanhSachBan.RowTemplate.Height = 24;
            this.dtgvDanhSachBan.Size = new System.Drawing.Size(540, 263);
            this.dtgvDanhSachBan.TabIndex = 38;
            this.dtgvDanhSachBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachBan_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã bàn";
            // 
            // tbMaBan
            // 
            this.tbMaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaBan.Location = new System.Drawing.Point(172, 48);
            this.tbMaBan.Name = "tbMaBan";
            this.tbMaBan.Size = new System.Drawing.Size(152, 27);
            this.tbMaBan.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên bàn";
            // 
            // tbTenBan
            // 
            this.tbTenBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenBan.Location = new System.Drawing.Point(172, 87);
            this.tbTenBan.Name = "tbTenBan";
            this.tbTenBan.Size = new System.Drawing.Size(152, 27);
            this.tbTenBan.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Trạng thái";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Còn trống",
            "Được đặt"});
            this.cbTrangThai.Location = new System.Drawing.Point(172, 130);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(152, 28);
            this.cbTrangThai.TabIndex = 44;
            // 
            // FrmDanhSachBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTenBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDanhSachBan);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDanhSachBan";
            this.Text = "FrmDanhSachBan";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dtgvDanhSachBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTrangThai;
    }
}