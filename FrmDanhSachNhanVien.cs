using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class FrmDanhSachNhanVien : Form
    {
        string connectionStr = DataAccess.connectionStr;
        int index = -1;
        public FrmDanhSachNhanVien()
        {
            InitializeComponent();
            LoadDataNhanVien();
        }
        void LoadDataNhanVien()
        {
            dtgvDanhSachNhanVien.DataSource = null;
            dtgvDanhSachNhanVien.DataSource = DanhSachNhanVien.Instance.ListNhanVien;
            dtgvDanhSachNhanVien.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dtgvDanhSachNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
            dtgvDanhSachNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dtgvDanhSachNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgvDanhSachNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";
            dtgvDanhSachNhanVien.Columns["Luong"].HeaderText = "Lương";
            dtgvDanhSachNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtgvDanhSachNhanVien.Columns["SoGioLamTrongThang"].HeaderText = "Số giờ làm trong tháng";

            dtgvDanhSachNhanVien.Refresh();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            LoadDataNhanVien();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int checkedIsNull = 0;
            int checkIsDuplictated = 0;
            string[] bien = new string[8];
            bien[0] = tbMaNhanVien.Text;
            bien[1] = tbTenNhanVien.Text;
            bien[2] = tbGioiTinh.Text;
            bien[3] = tbDiaChi.Text;
            bien[4] = tbChucVu.Text;
            bien[5] = tbLuong.Text;
            bien[6] = dtpkNgaySinh.Text;
            bien[7] = tbSoGioLamTrongThang.Text;

            foreach (string item in bien)
            {
                if (item == "")
                {
                    checkedIsNull = 1;
                }
            }
            if (checkedIsNull != 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ!");
            }
            else
            {
                foreach (NhanVien NV in DanhSachNhanVien.Instance.ListNhanVien)
                {
                    if (bien[1] == NV.HoTen )
                    {
                        checkIsDuplictated = 1;
                    }
                }
                if (checkIsDuplictated == 1)
                {
                    MessageBox.Show("Đã tồn tại nhân viên này!");
                }
                else
                {
                    DateTime x = dtpkNgaySinh.Value;
                    DanhSachNhanVien.Instance.ListNhanVien.Add(new NhanVien(bien[0], bien[1], bien[2], bien[3], bien[4], Convert.ToInt32(bien[5]), x , Convert.ToInt32(bien[7])));
                    LoadDataNhanVien();
                }
            }
            DataNhanVien.CapNhatvaThemDuLieu(DanhSachNhanVien.Instance.ListNhanVien, connectionStr);
            LoadDataNhanVien();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int checkedIsNull = 0;
            int checkIsDuplictated = 0;
            string[] bien = new string[8];
            bien[0] = tbMaNhanVien.Text;
            bien[1] = tbTenNhanVien.Text;
            bien[2] = tbGioiTinh.Text;
            bien[3] = tbDiaChi.Text;
            bien[4] = tbChucVu.Text;
            bien[5] = tbLuong.Text;
            bien[6] = dtpkNgaySinh.Text;
            bien[7] = tbSoGioLamTrongThang.Text;

            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 hàng!");
            }
            else
            {
                foreach (string item in bien)
                {
                    if (item == "")
                    {
                        checkedIsNull = 1;
                    }
                }
                if (checkedIsNull != 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ!");
                }
                else
                {
                    foreach (NhanVien NV in DanhSachNhanVien.Instance.ListNhanVien)
                    {
                        if (bien[1] == NV.HoTen)
                        {
                            checkIsDuplictated = 1;
                        }
                    }
                    if (checkIsDuplictated == 1)
                    {
                        MessageBox.Show("Đã tồn tại nhân viên này!");
                    }
                    else
                    {
                        DateTime x = dtpkNgaySinh.Value;
                        DanhSachNhanVien.Instance.ListNhanVien[index].MaNhanVien = bien[0];
                        DanhSachNhanVien.Instance.ListNhanVien[index].HoTen = bien[1];
                        DanhSachNhanVien.Instance.ListNhanVien[index].GioiTinh = bien[2];
                        DanhSachNhanVien.Instance.ListNhanVien[index].DiaChi = bien[3];
                        DanhSachNhanVien.Instance.ListNhanVien[index].ChucVu = bien[4];
                        DanhSachNhanVien.Instance.ListNhanVien[index].Luong = Convert.ToInt32(bien[5]);
                        DanhSachNhanVien.Instance.ListNhanVien[index].NgaySinh = x;
                        DanhSachNhanVien.Instance.ListNhanVien[index].SoGioLamTrongThang = Convert.ToInt32(bien[7]);
                        LoadDataNhanVien();
                    }
                }
            }
            
            DataNhanVien.CapNhatvaThemDuLieu(DanhSachNhanVien.Instance.ListNhanVien, connectionStr);
            LoadDataNhanVien();
        }

        private void dtgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0) return;
            tbMaNhanVien.Text = dtgvDanhSachNhanVien.Rows[index].Cells[0].Value.ToString();
            tbTenNhanVien.Text = dtgvDanhSachNhanVien.Rows[index].Cells[1].Value.ToString();
            tbGioiTinh.Text = dtgvDanhSachNhanVien.Rows[index].Cells[2].Value.ToString();
            tbDiaChi.Text = dtgvDanhSachNhanVien.Rows[index].Cells[3].Value.ToString();
            tbChucVu.Text = dtgvDanhSachNhanVien.Rows[index].Cells[4].Value.ToString();
            tbLuong.Text = dtgvDanhSachNhanVien.Rows[index].Cells[5].Value.ToString();
            dtpkNgaySinh.Value = Convert.ToDateTime(dtgvDanhSachNhanVien.Rows[index].Cells[6].Value);
            tbSoGioLamTrongThang.Text = dtgvDanhSachNhanVien.Rows[index].Cells[7].Value.ToString();
        }
    }
}
