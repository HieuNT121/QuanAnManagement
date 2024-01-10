using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public class Danhsachtaikhoan
    {
        private static Danhsachtaikhoan instance;
        public static Danhsachtaikhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new Danhsachtaikhoan();
                return instance;
            }
            set => instance = value;
        }

        List<Taikhoan> listTaiKhoan;

        public List<Taikhoan> ListTaiKhoan
        {
            get => listTaiKhoan;
            set => listTaiKhoan = value;
        }

        string connectionStr = DataAccess.connectionStr;

        Danhsachtaikhoan()
        {
            ListTaiKhoan = DataTaiKhoan.TruyenDuLieuVaoList(connectionStr);
        }
    }

    public class DataTaiKhoan
    {
        public static void CapNhatvaThemDuLieu(List<Taikhoan> danhSach, string connectionStr)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                foreach (Taikhoan TK in danhSach)
                {
                    string checkIfExists = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenTaiKhoan";

                    using (SqlCommand checkIfExistsCommand = new SqlCommand(checkIfExists, connection))
                    {
                        checkIfExistsCommand.Parameters.AddWithValue("@TenTaiKhoan", TK.TenTaikhoan);

                        int existingRecords = (int)checkIfExistsCommand.ExecuteScalar();

                        if (existingRecords > 0)
                        {
                            CapNhat(TK, connection);
                        }
                        else
                        {
                            Them(TK, connection);
                        }
                    }

                }
            }
        }

        static void CapNhat(Taikhoan TK, SqlConnection connection)
        {
            string updateQuery = "UPDATE TaiKhoan " +
                                 "SET MatKhau = @MatKhau, PhanLoai = @PhanLoai, MaNhanVien = @MaNhanVien " +
                                 "WHERE TenDangNhap = @TenTaiKhoan";

            using (SqlCommand capNhatCmd = new SqlCommand(updateQuery, connection))
            {
                capNhatCmd.Parameters.AddWithValue("@TenTaiKhoan", TK.TenTaikhoan);
                capNhatCmd.Parameters.AddWithValue("@MatKhau", TK.MatKhau);
                capNhatCmd.Parameters.AddWithValue("@PhanLoai", TK.PhanLoai);
                capNhatCmd.Parameters.AddWithValue("@MaNhanVien", TK.MaNhanVien);

                capNhatCmd.ExecuteNonQuery();
            }
        }

        static void Them(Taikhoan TK, SqlConnection connection)
        {
            string insertQuery = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, PhanLoai, MaNhanVien) " +
                                 "VALUES (@TenDangNhap, @MatKhau, @PhanLoai, @MaNhanVien)";

            using (SqlCommand themCmd = new SqlCommand(insertQuery, connection))
            {
                themCmd.Parameters.AddWithValue("@TenDangNhap", TK.TenTaikhoan);
                themCmd.Parameters.AddWithValue("@MatKhau", TK.MatKhau);
                themCmd.Parameters.AddWithValue("@PhanLoai", TK.PhanLoai);
                themCmd.Parameters.AddWithValue("@MaNhanVien", TK.MaNhanVien);

                themCmd.ExecuteNonQuery();
            }
        }

        public static List<Taikhoan> TruyenDuLieuVaoList(string chuoi)
        {
            List<Taikhoan> ListTaiKhoan = new List<Taikhoan>();
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                connection.Open();

                string query = $"SELECT * FROM TaiKhoan";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string TenTaiKhoan = reader["TenDangNhap"].ToString();
                                string MatKhau = reader["MatKhau"].ToString();
                                string PhanLoai = reader["PhanLoai"].ToString();
                                string MaNhanVien = reader["MaNhanVien"].ToString();

                                ListTaiKhoan.Add(new Taikhoan(TenTaiKhoan, MatKhau, PhanLoai, MaNhanVien));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                }
            }

            return ListTaiKhoan;
        }

        public static void Xoa(string connectionString, string tenTaiKhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM TaiKhoan WHERE TenDangNhap = @TenTaiKhoan";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);

                    try
                    {
                        // Thực hiện truy vấn DELETE
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                }
            }
        }
    }
}