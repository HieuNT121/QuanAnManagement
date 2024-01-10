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
    public partial class FrmThongKeChinh : Form
    {
        public FrmThongKeChinh()
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

        private void btDoanhSo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDoanhSo());
        }

        private void btLuongKhach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLuongKhach());
        }

        private void btChiTieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmChiTieu());
        }

        private void btLuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLuong());
        }

    }
}
