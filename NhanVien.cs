using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace QuanLyQuanAn
{
    public class NhanVien
    {
        private string maNhanVien;
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }

        private string hoTen;
        public string HoTen { get => hoTen; set => hoTen = value; }
      
        private string gioiTinh;
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        private string diaChi;
        public string DiaChi { get => diaChi; set => diaChi = value; }

        private string chucVu;
        public string ChucVu { get => chucVu; set => chucVu = value; }

        private int luong;
        public int Luong { get => luong; set => luong = value; }

        private DateTime ngaySinh;
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        private int soGioLamTrongThang;
        public int SoGioLamTrongThang { get => soGioLamTrongThang; set => soGioLamTrongThang = value; }


        public NhanVien (string maNhanVien,string hoTen, string gioiTinh, string diaChi, string chucVu, int luong, DateTime ngaySinh, int soGioLAmTrongThang)
        {
            this.MaNhanVien = maNhanVien;
            this.HoTen =hoTen;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.ChucVu = chucVu;
            this.Luong = luong;
            this.NgaySinh = ngaySinh;
            this.SoGioLamTrongThang = soGioLAmTrongThang;
        }
    }

    public class DanhSachNhanVien
    {
        private static DanhSachNhanVien instance;

        public static DanhSachNhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachNhanVien();
                return instance;
            }
            set => instance = value;
        }

        List<NhanVien> listNhanVien;
        public List<NhanVien> ListNhanVien { get => listNhanVien; set => listNhanVien = value; }

        string connectionStr = DataAccess.connectionStr;

        DanhSachNhanVien()
        {
            ListNhanVien = DataNhanVien.TruyenDuLieuVaoList(connectionStr);
        }
    }

    public class DataNhanVien
    {
        public static void CapNhatvaThemDuLieu(List<NhanVien> danhSach, string connectionStr)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                foreach (NhanVien NV in danhSach)
                {
                    string checkIfExists = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @MaNhanVien ";

                    using (SqlCommand checkIfExistsCommand = new SqlCommand(checkIfExists, connection))
                    {
                        checkIfExistsCommand.Parameters.AddWithValue("@MaNhanVien", NV.MaNhanVien);

                        int existingRecords = (int)checkIfExistsCommand.ExecuteScalar();

                        if (existingRecords > 0)
                        {
                            CapNhat(NV, connection);
                        }
                        else
                        {
                            Them(NV, connection);
                        }
                    }

                }
            }
        }

        static void CapNhat(NhanVien NV, SqlConnection connection)
        {
            string updateQuery = "UPDATE NhanVien " +
                                 "SET HoTen = @HoTen, GioiTinh =@GioiTinh, DiaChi = @DiaChi, ChucVu = @ChucVu, Luong = @Luong, NgaySinh = @NgaySinh, SoGioLamTrongThang = @SoGioLamTrongThang " +
                                 "WHERE MaNhanVien = @MaNhanVien";

            using (SqlCommand capNhatCmd = new SqlCommand(updateQuery, connection))
            {
                capNhatCmd.Parameters.AddWithValue("@MaNhanVien", NV.MaNhanVien);
                capNhatCmd.Parameters.AddWithValue("@HoTen", NV.HoTen);
                capNhatCmd.Parameters.AddWithValue("@GioiTinh", NV.GioiTinh);
                capNhatCmd.Parameters.AddWithValue("@DiaChi", NV.DiaChi);
                capNhatCmd.Parameters.AddWithValue("@ChucVu", NV.ChucVu);
                capNhatCmd.Parameters.AddWithValue("@Luong", NV.Luong);
                capNhatCmd.Parameters.AddWithValue("@NgaySinh", NV.NgaySinh);
                capNhatCmd.Parameters.AddWithValue("@SoGioLamTrongThang", NV.SoGioLamTrongThang);

                capNhatCmd.ExecuteNonQuery();
            }
        }

        static void Them(NhanVien NV, SqlConnection connection)
        {
            string insertQuery = "INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, DiaChi, ChucVu, Luong, NgaySinh, SoGioLamTrongThang) " +
                                 "VALUES (@MaNhanVien, @HoTen, @GioiTinh, @DiaChi, @ChucVu, @Luong, @NgaySinh, @SoGioLamTrongThang )";

            using (SqlCommand themCmd = new SqlCommand(insertQuery, connection))
            {
                themCmd.Parameters.AddWithValue("@MaNhanVien", NV.MaNhanVien);
                themCmd.Parameters.AddWithValue("@HoTen", NV.HoTen);
                themCmd.Parameters.AddWithValue("@GioiTinh", NV.GioiTinh);
                themCmd.Parameters.AddWithValue("@DiaChi", NV.DiaChi);
                themCmd.Parameters.AddWithValue("@ChucVu", NV.ChucVu);
                themCmd.Parameters.AddWithValue("@Luong", NV.Luong);
                themCmd.Parameters.AddWithValue("@NgaySinh", NV.NgaySinh);
                themCmd.Parameters.AddWithValue("@SoGioLamTrongThang", NV.SoGioLamTrongThang);

                themCmd.ExecuteNonQuery();
            }
        }

        public static List<NhanVien> TruyenDuLieuVaoList(string chuoi)
        {
            List<NhanVien> ListNhanVien = new List<NhanVien>();
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                connection.Open();

                string query = $"SELECT * FROM NhanVien";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string MaNhanVien = reader["MaNhanVien"].ToString();
                                string HoTen = reader["HoTen"].ToString();
                                string GioiTinh = reader["GioiTinh"].ToString();
                                string DiaChi = reader["DiaChi"].ToString();
                                string ChucVu = reader["ChucVu"].ToString();
                                int Luong = Convert.ToInt32(reader["Luong"]);
                                DateTime NgaySinh = (DateTime)reader["NgaySinh"];
                                int SoGioLamTrongThang = Convert.ToInt32(reader["SoGioLamTrongThang"]);

                                ListNhanVien.Add(new NhanVien( MaNhanVien, HoTen, GioiTinh, DiaChi, ChucVu, Luong, NgaySinh, SoGioLamTrongThang));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                }
            }

            return ListNhanVien;
        }

        public static void Xoa(string connectionString, string maNhanVien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

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
