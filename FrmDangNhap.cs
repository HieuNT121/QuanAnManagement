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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        List<Taikhoan> listTaiKhoan = Danhsachtaikhoan.Instance.ListTaiKhoan;
        bool KiemtraDangNhap(string tentaikhoan, string matkhau)
        {
            bool a = false;
            for (int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (tentaikhoan == listTaiKhoan[i].TenTaikhoan && matkhau == listTaiKhoan[i].MatKhau)
                {
                    TypeTaiKhoan.AccountType = listTaiKhoan[i].PhanLoai;
                    a = true;
                }
            }
            return a;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (KiemtraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                FrmMain formMain = new FrmMain();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                txtTaiKhoan.Focus();
            }
        }

        private void cbxMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            if (!cbxMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}