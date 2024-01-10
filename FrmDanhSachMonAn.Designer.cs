namespace QuanLyQuanAn
{
    partial class FrmDanhSachMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhSachMonAn));
            this.dtgvMonAn = new System.Windows.Forms.DataGridView();
            this.MonAn = new System.Windows.Forms.Label();
            this.tenTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IDMon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxIdFood = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NameMon = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxFoodName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LoaiMon = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbxCategory = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Gia = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbxFoodPrice = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAn)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvMonAn
            // 
            this.dtgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonAn.Location = new System.Drawing.Point(23, 23);
            this.dtgvMonAn.Name = "dtgvMonAn";
            this.dtgvMonAn.ReadOnly = true;
            this.dtgvMonAn.RowHeadersWidth = 51;
            this.dtgvMonAn.RowTemplate.Height = 24;
            this.dtgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvMonAn.Size = new System.Drawing.Size(576, 440);
            this.dtgvMonAn.TabIndex = 0;
            this.dtgvMonAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMonAn_CellContentClick);
            // 
            // MonAn
            // 
            this.MonAn.AutoSize = true;
            this.MonAn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonAn.Location = new System.Drawing.Point(632, 23);
            this.MonAn.Name = "MonAn";
            this.MonAn.Size = new System.Drawing.Size(93, 31);
            this.MonAn.TabIndex = 5;
            this.MonAn.Text = "Món ăn";
            // 
            // tenTimKiem
            // 
            this.tenTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTimKiem.Location = new System.Drawing.Point(634, 76);
            this.tenTimKiem.Name = "tenTimKiem";
            this.tenTimKiem.Size = new System.Drawing.Size(189, 34);
            this.tenTimKiem.TabIndex = 6;
            this.tenTimKiem.Text = "Tên món ăn";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(634, 129);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(96, 34);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(634, 273);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(312, 190);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.IDMon);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 41);
            this.panel1.TabIndex = 10;
            // 
            // IDMon
            // 
            this.IDMon.AutoSize = true;
            this.IDMon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDMon.Location = new System.Drawing.Point(10, 7);
            this.IDMon.Name = "IDMon";
            this.IDMon.Size = new System.Drawing.Size(74, 23);
            this.IDMon.TabIndex = 9;
            this.IDMon.Text = "Mã món";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbxIdFood);
            this.panel2.Location = new System.Drawing.Point(104, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 41);
            this.panel2.TabIndex = 11;
            // 
            // tbxIdFood
            // 
            this.tbxIdFood.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdFood.Location = new System.Drawing.Point(6, 5);
            this.tbxIdFood.Name = "tbxIdFood";
            this.tbxIdFood.Size = new System.Drawing.Size(189, 30);
            this.tbxIdFood.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.NameMon);
            this.panel3.Location = new System.Drawing.Point(3, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 41);
            this.panel3.TabIndex = 12;
            // 
            // NameMon
            // 
            this.NameMon.AutoSize = true;
            this.NameMon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameMon.Location = new System.Drawing.Point(10, 7);
            this.NameMon.Name = "NameMon";
            this.NameMon.Size = new System.Drawing.Size(76, 23);
            this.NameMon.TabIndex = 9;
            this.NameMon.Text = "Tên món";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbxFoodName);
            this.panel4.Location = new System.Drawing.Point(104, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 41);
            this.panel4.TabIndex = 13;
            // 
            // tbxFoodName
            // 
            this.tbxFoodName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFoodName.Location = new System.Drawing.Point(6, 5);
            this.tbxFoodName.Name = "tbxFoodName";
            this.tbxFoodName.Size = new System.Drawing.Size(189, 30);
            this.tbxFoodName.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.LoaiMon);
            this.panel5.Location = new System.Drawing.Point(3, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(95, 41);
            this.panel5.TabIndex = 14;
            // 
            // LoaiMon
            // 
            this.LoaiMon.AutoSize = true;
            this.LoaiMon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiMon.Location = new System.Drawing.Point(7, 9);
            this.LoaiMon.Name = "LoaiMon";
            this.LoaiMon.Size = new System.Drawing.Size(81, 23);
            this.LoaiMon.TabIndex = 9;
            this.LoaiMon.Text = "Phân loại";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbxCategory);
            this.panel6.Location = new System.Drawing.Point(104, 97);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 41);
            this.panel6.TabIndex = 15;
            // 
            // tbxCategory
            // 
            this.tbxCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCategory.Location = new System.Drawing.Point(6, 5);
            this.tbxCategory.Name = "tbxCategory";
            this.tbxCategory.Size = new System.Drawing.Size(189, 30);
            this.tbxCategory.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.Gia);
            this.panel7.Location = new System.Drawing.Point(3, 144);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(95, 41);
            this.panel7.TabIndex = 16;
            // 
            // Gia
            // 
            this.Gia.AutoSize = true;
            this.Gia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gia.Location = new System.Drawing.Point(19, 10);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(57, 23);
            this.Gia.TabIndex = 9;
            this.Gia.Text = "Giá cả";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbxFoodPrice);
            this.panel8.Location = new System.Drawing.Point(104, 144);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 41);
            this.panel8.TabIndex = 17;
            // 
            // tbxFoodPrice
            // 
            this.tbxFoodPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFoodPrice.Location = new System.Drawing.Point(6, 5);
            this.tbxFoodPrice.Name = "tbxFoodPrice";
            this.tbxFoodPrice.Size = new System.Drawing.Size(189, 30);
            this.tbxFoodPrice.TabIndex = 11;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(52, 511);
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
            this.btnThem.Location = new System.Drawing.Point(170, 511);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 40);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(294, 511);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(420, 511);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 40);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "    Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FrmDanhSachMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(987, 610);
            this.ControlBox = false;
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.tenTimKiem);
            this.Controls.Add(this.MonAn);
            this.Controls.Add(this.dtgvMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDanhSachMonAn";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAn)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvMonAn;
        private System.Windows.Forms.Label MonAn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox tenTimKiem;
        private System.Windows.Forms.Label IDMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxIdFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label NameMon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbxFoodName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LoaiMon;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbxCategory;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Gia;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbxFoodPrice;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}