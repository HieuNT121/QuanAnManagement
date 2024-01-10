namespace QuanLyQuanAn
{
    partial class FrmQuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyTaiKhoan));
            this.lbTenTaiKhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.cbLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.dtvgUser = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btThem = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btXoa = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMaNhanVIen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvgUser)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTenTaiKhoan
            // 
            this.lbTenTaiKhoan.AutoSize = true;
            this.lbTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTaiKhoan.Location = new System.Drawing.Point(76, 94);
            this.lbTenTaiKhoan.Name = "lbTenTaiKhoan";
            this.lbTenTaiKhoan.Size = new System.Drawing.Size(149, 31);
            this.lbTenTaiKhoan.TabIndex = 1;
            this.lbTenTaiKhoan.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại tài khoản";
            // 
            // tbTenTaiKhoan
            // 
            this.tbTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTaiKhoan.Location = new System.Drawing.Point(245, 91);
            this.tbTenTaiKhoan.Name = "tbTenTaiKhoan";
            this.tbTenTaiKhoan.Size = new System.Drawing.Size(224, 38);
            this.tbTenTaiKhoan.TabIndex = 4;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhau.Location = new System.Drawing.Point(245, 145);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(224, 38);
            this.tbMatKhau.TabIndex = 5;
            // 
            // cbLoaiTaiKhoan
            // 
            this.cbLoaiTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiTaiKhoan.FormattingEnabled = true;
            this.cbLoaiTaiKhoan.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.cbLoaiTaiKhoan.Location = new System.Drawing.Point(245, 203);
            this.cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
            this.cbLoaiTaiKhoan.Size = new System.Drawing.Size(224, 39);
            this.cbLoaiTaiKhoan.TabIndex = 12;
            // 
            // dtvgUser
            // 
            this.dtvgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvgUser.Location = new System.Drawing.Point(530, 70);
            this.dtvgUser.MultiSelect = false;
            this.dtvgUser.Name = "dtvgUser";
            this.dtvgUser.ReadOnly = true;
            this.dtvgUser.RowHeadersWidth = 51;
            this.dtvgUser.RowTemplate.Height = 24;
            this.dtvgUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtvgUser.Size = new System.Drawing.Size(443, 444);
            this.dtvgUser.TabIndex = 17;
            this.dtvgUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvgUser_CellContentClick);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.panel19);
            this.flowLayoutPanel3.Controls.Add(this.panel20);
            this.flowLayoutPanel3.Controls.Add(this.panel21);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(64, 345);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(445, 65);
            this.flowLayoutPanel3.TabIndex = 24;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btThem);
            this.panel19.Location = new System.Drawing.Point(3, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(114, 56);
            this.panel19.TabIndex = 10;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(13, 5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(91, 40);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "    Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btXoa);
            this.panel20.Location = new System.Drawing.Point(123, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(106, 56);
            this.panel20.TabIndex = 9;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(3, 5);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(89, 40);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "    Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btSua);
            this.panel21.Location = new System.Drawing.Point(235, 3);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(87, 56);
            this.panel21.TabIndex = 11;
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(0, 5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(83, 40);
            this.btSua.TabIndex = 6;
            this.btSua.Text = "    Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã nhân viên";
            // 
            // tbxMaNhanVIen
            // 
            this.tbxMaNhanVIen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaNhanVIen.Location = new System.Drawing.Point(245, 253);
            this.tbxMaNhanVIen.Name = "tbxMaNhanVIen";
            this.tbxMaNhanVIen.Size = new System.Drawing.Size(224, 38);
            this.tbxMaNhanVIen.TabIndex = 26;
            // 
            // FrmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.tbxMaNhanVIen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.dtvgUser);
            this.Controls.Add(this.cbLoaiTaiKhoan);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbTenTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTenTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuanLyTaiKhoan";
            this.Text = "FrmQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.FrmQuanLyTaiKhoan_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtvgUser)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenTaiKhoan;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.ComboBox cbLoaiTaiKhoan;
        private System.Windows.Forms.DataGridView dtvgUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMaNhanVIen;
    }
}