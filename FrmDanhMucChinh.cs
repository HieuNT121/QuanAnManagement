using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class FrmDanhMucChinh : Form
    {
        public FrmDanhMucChinh()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            if(TypeTaiKhoan.AccountType == "Nhân viên")
            {
                MessageBox.Show("Bạn không phải quản lý\nVui lòng quay lại!!!","Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else OpenChildForm(new FrmDanhSachNhanVien());
        }

        private void btDanhSachMonAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachMonAn());
        }

        private void btDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachKhachHang());
        }

        private void btDanhSachNhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachNhaCungCap());
        }

        private void btDanhSachPhanLoaiMonAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachPhanLoaiMonAn());
        }

        private void btDanhSachBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachBan());
        }
    }
}
