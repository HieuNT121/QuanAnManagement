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
    public partial class FrmQuanLyTaiKhoan : Form
    {
        List<string> listAccountType = new List<string>() { "Quản lý", "Nhân viên" };
        string connectionStr = DataAccess.connectionStr;
        int index = -1;

        public FrmQuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadListUser();
        }

        void LoadListUser()
        {
            dtvgUser.DataSource = null;
            dtvgUser.DataSource = Danhsachtaikhoan.Instance.ListTaiKhoan;
            dtvgUser.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Danhsachtaikhoan.Instance.ListTaiKhoan.RemoveAt(index);
            string tenTaiKhoan = tbTenTaiKhoan.Text;
            DataTaiKhoan.Xoa(connectionStr, tenTaiKhoan);
            LoadListUser();
        }

        private void FrmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            cbLoaiTaiKhoan.DataSource = listAccountType;
            LoadListUser();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string userName = tbTenTaiKhoan.Text;
            string password = tbMatKhau.Text;
            string type = "Nhân viên";
            string maNhanVien = tbxMaNhanVIen.Text;
            switch (cbLoaiTaiKhoan.Text)
            {
                case "Quản lý":
                    type = "Quản lý";
                    break;
                case "Nhân viên":
                    type = "Nhân viên";
                    break;
            }

            for (int i = 0; i < Danhsachtaikhoan.Instance.ListTaiKhoan.Count; i++)
            {
                if(tbTenTaiKhoan.Text == Danhsachtaikhoan.Instance.ListTaiKhoan[i].TenTaikhoan || tbxMaNhanVIen.Text == Danhsachtaikhoan.Instance.ListTaiKhoan[i].MaNhanVien)
                {
                    MessageBox.Show("Tài Khoản Đã Có người dùng", "Thông Báo", MessageBoxButtons.OK);
                    break;
                }
                else if(i == Danhsachtaikhoan.Instance.ListTaiKhoan.Count-1)
                {
                    Danhsachtaikhoan.Instance.ListTaiKhoan.Add(new Taikhoan(userName, password, type, maNhanVien));
                    DataTaiKhoan.CapNhatvaThemDuLieu(Danhsachtaikhoan.Instance.ListTaiKhoan, connectionStr);
                    LoadListUser();
                    break;
                }
            }

            /*Danhsachtaikhoan.Instance.ListTaiKhoan.Add(new Taikhoan(userName, password, type, maNhanVien));
            DataTaiKhoan.CapNhatvaThemDuLieu(Danhsachtaikhoan.Instance.ListTaiKhoan, connectionStr);
            LoadListUser();*/
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string userName = tbTenTaiKhoan.Text;
            string password = tbMatKhau.Text;
            string type = "Nhân viên";
            string maNhanVien = tbxMaNhanVIen.Text;
            switch (cbLoaiTaiKhoan.Text)
            {
                case "Quản lý":
                    type = "Quản lý";
                    break;
                case "Nhân viên":
                    type = "Nhân viên";
                    break;
            }

            Danhsachtaikhoan.Instance.ListTaiKhoan[index].TenTaikhoan = userName;
            Danhsachtaikhoan.Instance.ListTaiKhoan[index].MatKhau = password;
            Danhsachtaikhoan.Instance.ListTaiKhoan[index].PhanLoai = type;
            Danhsachtaikhoan.Instance.ListTaiKhoan[index].MaNhanVien = maNhanVien;
            DataTaiKhoan.CapNhatvaThemDuLieu(Danhsachtaikhoan.Instance.ListTaiKhoan, connectionStr);
            LoadListUser();
        }

        private void dtvgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index <0) return;
            tbTenTaiKhoan.Text = dtvgUser.Rows[index].Cells[0].Value.ToString();
            tbMatKhau.Text = dtvgUser.Rows[index].Cells[1].Value.ToString();
            cbLoaiTaiKhoan.Text = dtvgUser.Rows[index].Cells[2].Value.ToString();
            tbxMaNhanVIen.Text = dtvgUser.Rows[index].Cells[3].Value.ToString();
            switch (Danhsachtaikhoan.Instance.ListTaiKhoan[index].PhanLoai)
            {
                case "Quản lý":
                    cbLoaiTaiKhoan.Text = "Quản lý";
                    break;
                case "Nhân viên":
                    cbLoaiTaiKhoan.Text = "Nhân viên";
                    break;
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmQuanLyTaiKhoan_Load_1(object sender, EventArgs e)
        {
            cbLoaiTaiKhoan.DataSource = listAccountType;
            LoadListUser();
        }
    }
}