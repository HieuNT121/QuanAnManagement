using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public class Taikhoan
    {
        private string tenTaikhoan;

        public string TenTaikhoan
        {
            get => tenTaikhoan;
            set => tenTaikhoan = value;
        }

        private string matKhau;
        public string MatKhau
        {
            get => matKhau;
            set => matKhau = value;
        }

        private string phanLoai;
        public string PhanLoai
        {
            get => phanLoai;
            set => phanLoai = value;
        }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }

        private string maNhanVien;


        public Taikhoan(string tenTaikhoan, string matKhau, string phanLoai, string maNhanVien)
        {
            this.TenTaikhoan = tenTaikhoan;
            this.MatKhau = matKhau;
            this.PhanLoai = phanLoai;
            this.MaNhanVien = maNhanVien;
        }
    }

    public class TypeTaiKhoan
    {
        public static string AccountType;
    }

}