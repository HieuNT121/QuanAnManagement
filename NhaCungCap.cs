using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public class DanhSachNhaCungCap
    {
        private static DanhSachNhaCungCap instance;

        public static DanhSachNhaCungCap Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachNhaCungCap();
                return instance;
            }
            set => instance = value;
        }

        List<NhaCungCap> listNhaCungCap;
        public List<NhaCungCap> ListNhaCungCap { get => listNhaCungCap; set => listNhaCungCap = value; }
        string connectionStr = DataAccess.connectionStr;
        DanhSachNhaCungCap()
        {
            ListNhaCungCap = DataNhaCungCap.TruyenDuLieuVaoList(connectionStr);
        }
    }
    public class NhaCungCap
    {
        private string maNhaCungCap;
        public string MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }

        private string tenNhaCungCap;
        public string TenNhaCungCap { get => tenNhaCungCap; set => tenNhaCungCap = value; }

        private string diaChi;
        public string DiaChi { get => diaChi; set => diaChi = value; }

        private string soDienThoai;
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }

        public NhaCungCap(string maNhaCungCap, string tenNhaCungCap, string diaChi, string soDienThoai)
        {
            this.MaNhaCungCap = maNhaCungCap;
            this.TenNhaCungCap = tenNhaCungCap;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
        }

    }
    public class DataNhaCungCap
    {
        public static void CapNhatvaThemDuLieu(List<NhaCungCap> danhSach, string connectionStr)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                foreach (NhaCungCap NCC in danhSach)
                {
                    string checkIfExists = "SELECT COUNT(*) FROM NhaCungCap WHERE MaNhaCungCap = @MaNhaCungCap";

                    using (SqlCommand checkIfExistsCommand = new SqlCommand(checkIfExists, connection))
                    {
                        checkIfExistsCommand.Parameters.AddWithValue("@MaNhaCungCap", NCC.MaNhaCungCap);

                        int existingRecords = (int)checkIfExistsCommand.ExecuteScalar();

                        if (existingRecords > 0)
                        {
                            CapNhat(NCC, connection);
                        }
                        else
                        {
                            Them(NCC, connection);
                        }
                    }

                }
            }
        }

        static void CapNhat(NhaCungCap NCC, SqlConnection connection)
        {
            string updateQuery = "UPDATE NhaCungCap " +
                                 "SET TenNhaCungCap = @TenNhaCungCap, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai " +
                                 "WHERE MaNhaCungCap = @MaNhaCungCap";

            using (SqlCommand capNhatCmd = new SqlCommand(updateQuery, connection))
            {
                capNhatCmd.Parameters.AddWithValue("@MaNhaCungCap", NCC.MaNhaCungCap);
                capNhatCmd.Parameters.AddWithValue("@TenNhaCungCap", NCC.TenNhaCungCap);
                capNhatCmd.Parameters.AddWithValue("@DiaChi", NCC.DiaChi);
                capNhatCmd.Parameters.AddWithValue("@SoDienThoai", NCC.SoDienThoai);

                capNhatCmd.ExecuteNonQuery();
            }
        }

        static void Them(NhaCungCap NCC, SqlConnection connection)
        {
            string insertQuery = "INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, DiaChi, SoDienThoai) " +
                                 "VALUES (@MaNhaCungCap, @TenNhaCungCap, @DiaChi, @SoDienTHoai)";

            using (SqlCommand themCmd = new SqlCommand(insertQuery, connection))
            {
                themCmd.Parameters.AddWithValue("@MaNhaCungCap", NCC.MaNhaCungCap);
                themCmd.Parameters.AddWithValue("@TenNhaCungCap", NCC.TenNhaCungCap);
                themCmd.Parameters.AddWithValue("@DiaChi", NCC.DiaChi);
                themCmd.Parameters.AddWithValue("@SoDienThoai", NCC.SoDienThoai);

                themCmd.ExecuteNonQuery();
            }
        }

        public static List<NhaCungCap> TruyenDuLieuVaoList(string chuoi)
        {
            List<NhaCungCap> ListNhaCungCap = new List<NhaCungCap>();
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                connection.Open();

                string query = $"SELECT * FROM NhaCungCap";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string MaNhaCungCap = reader["MaNhaCungCap"].ToString();
                                string TenNhaCungCap = reader["TenNhaCungCap"].ToString();
                                string DiaChi = reader["DiaChi"].ToString();
                                string SoDienThoai = reader["SoDienThoai"].ToString();

                                ListNhaCungCap.Add(new NhaCungCap(MaNhaCungCap, TenNhaCungCap, DiaChi, SoDienThoai));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                }
            }

            return ListNhaCungCap;
        }

        public static void Xoa(string connectionString, string maNhaCungCap)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM NhaCungCap WHERE MaNhaCungCap = @MaNhaCungCap";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNhaCungcap", maNhaCungCap);

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