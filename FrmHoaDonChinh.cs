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
    public partial class FrmHoaDonChinh : Form
    {
        public FrmHoaDonChinh()
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

        private void btHoaDonNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHoaDonNhap());
        }

        private void btDatDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDatDon());
        }

        private void btHoaDonThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHoaDonThanhToan());
        }

        private void btCapNhatHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCapNhatThongTinHoaDon());
        }
    }
}
