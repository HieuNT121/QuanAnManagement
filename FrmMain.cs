using QuanLyQuanAn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
            PhanQuyen();
        }

        //private void FrmMain_Load(object sender, EventArgs e)
        //{
        //    loginUser.Text = MainClass.USER;
        //}


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
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

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhMucChinh());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            if (TypeTaiKhoan.AccountType == "Quản lý")
            {
                OpenChildForm(new FrmThongKeChinh());
            }
            else
            {
                MessageBox.Show("Bạn không phải là quản lý", "Cảnh báo");
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            if (TypeTaiKhoan.AccountType == "Quản lý")
            {
                OpenChildForm(new FrmHeThongChinh());
            }
            else
            {
                MessageBox.Show("Bạn không phải là quản lý", "Cảnh báo");
            }

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHoaDonChinh());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhoChinh());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void PhanQuyen()
        {
            if (TypeTaiKhoan.AccountType == "Nhân viên")
            {
                btQuantriHeThong.Enabled = btBaoCaoThongKe.Enabled = false;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btQuantriHeThong.Enabled = btBaoCaoThongKe.Enabled = false;
        }
    }
}