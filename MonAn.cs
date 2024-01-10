using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public class MonAn
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string idCategory;
        public string IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }

        private string price;
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public MonAn(string id, string tenMon, string phanLoai, string price)
        {
            this.id = id;
            this.name = tenMon;
            this.idCategory = phanLoai;
            this.price = price;
        }
    }

    public class Category
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Category(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    public class DanhSachPhanLoai
    {
        private static DanhSachPhanLoai instance;
        public static DanhSachPhanLoai Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachPhanLoai();
                return instance;
            }
            set => instance = value;
        }

        List<MonAn> listMonAn;

        public List<MonAn> ListMonAn
        {
            get => listMonAn;
            set => listMonAn = value;
        }

        List<Category> listCategory;

        public List<Category> ListCategory
        {
            get => listCategory;
            set => listCategory = value;
        }
        string connectionStr = DataAccess.connectionStr;
        DanhSachPhanLoai()
        {
            listMonAn = DataThucDon.TruyenDuLieuVaoList(connectionStr);
            listCategory = DataPhanLoai.TruyenDuLieuVaoList(connectionStr);
        }
    }

    public class DataThucDon
    {
        public static void CapNhatvaThemDuLieu(List<MonAn> danhSach, string connectionStr)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                foreach (MonAn mon in danhSach)
                {
                    string checkIfExists = "SELECT COUNT(*) FROM ThucDon WHERE MaMonAn = @MaMonAn";

                    using (SqlCommand checkIfExistsCommand = new SqlCommand(checkIfExists, connection))
                    {
                        checkIfExistsCommand.Parameters.AddWithValue("@MaMonAn", mon.Id);

                        int existingRecords = (int)checkIfExistsCommand.ExecuteScalar();

                        if (existingRecords > 0)
                        {
                            CapNhat(mon, connection);
                        }
                        else
                        {
                            Them(mon, connection);
                        }
                    }

                }
            }
        }

        static void CapNhat(MonAn mon, SqlConnection connection)
        {
            string updateQuery = "UPDATE ThucDon " +
                                 "SET TenMonAn = @TenMonAn, MaPhanLoai = @MaPhanLoai, DonGia = @DonGia " +
                                 "WHERE MaMonAn = @MaMonAn";

            using (SqlCommand capNhatCmd = new SqlCommand(updateQuery, connection))
            {
                capNhatCmd.Parameters.AddWithValue("@MaMonAn", mon.Id);
                capNhatCmd.Parameters.AddWithValue("@TenMonAn", mon.Name);
                capNhatCmd.Parameters.AddWithValue("@MaPhanLoai", mon.IdCategory);
                capNhatCmd.Parameters.AddWithValue("@DonGia", mon.Price);

                capNhatCmd.ExecuteNonQuery();
            }
        }

        static void Them(MonAn mon, SqlConnection connection)
        {
            string insertQuery = "INSERT INTO ThucDon (MaMonAn, TenMonAn, MaPhanLoai, DonGia) " +
                                 "VALUES (@MaMonAn, @TenMonAn, @MaPhanLoai, @DonGia)";

            using (SqlCommand themCmd = new SqlCommand(insertQuery, connection))
            {
                themCmd.Parameters.AddWithValue("@MaMonAn", mon.Id);
                themCmd.Parameters.AddWithValue("@TenMonAn", mon.Name);
                themCmd.Parameters.AddWithValue("@MaPhanLoai", mon.IdCategory);
                themCmd.Parameters.AddWithValue("@DonGia", mon.Price);

                themCmd.ExecuteNonQuery();
            }
        }

        public static List<MonAn> TruyenDuLieuVaoList(string chuoi)
        {
            List<MonAn> ListMonAn = new List<MonAn>();
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                connection.Open();

                string query = $"SELECT * FROM ThucDon";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string MaMonAn = reader["MaMonAn"].ToString();
                                string TenMonAn = reader["TenMonAn"].ToString();
                                string MaPhanLoai = reader["MaPhanLoai"].ToString();
                                string DonGia = reader["DonGia"].ToString();

                                ListMonAn.Add(new MonAn(MaMonAn, TenMonAn, MaPhanLoai, DonGia));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                }
            }

            return ListMonAn;
        }

        public static void Xoa(string connectionString, string maMonAn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM ThucDon WHERE MaMonAn = @MaMonAn";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaMonAn", maMonAn);

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

    public class DataPhanLoai
    {
        public static void CapNhatvaThemDuLieu(List<Category> danhSach, string connectionStr)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                foreach (Category phanLoai in danhSach)
                {
                    string checkIfExists = "SELECT COUNT(*) FROM PhanLoai WHERE MaPhanLoai = @MaPhanLoai";

                    using (SqlCommand checkIfExistsCommand = new SqlCommand(checkIfExists, connection))
                    {
                        checkIfExistsCommand.Parameters.AddWithValue("@MaPhanLoai", phanLoai.Id);

                        int existingRecords = (int)checkIfExistsCommand.ExecuteScalar();

                        if (existingRecords > 0)
                        {
                            CapNhat(phanLoai, connection);
                        }
                        else
                        {
                            Them(phanLoai, connection);
                        }
                    }

                }
            }
        }

        static void CapNhat(Category phanLoai, SqlConnection connection)
        {
            string updateQuery = "UPDATE PhanLoai " +
                                 "SET TenPhanLoai = @TenPhanLoai " +
                                 "WHERE MaPhanLoai = @MaPhanLoai";

            using (SqlCommand capNhatCmd = new SqlCommand(updateQuery, connection))
            {
                capNhatCmd.Parameters.AddWithValue("@MaPhanLoai", phanLoai.Id);
                capNhatCmd.Parameters.AddWithValue("@TenPhanLoai", phanLoai.Name);

                capNhatCmd.ExecuteNonQuery();
            }
        }

        static void Them(Category phanLoai, SqlConnection connection)
        {
            string insertQuery = "INSERT INTO PhanLoai (MaPhanLoai, TenPhanLoai) " +
                                 "VALUES (@MaPhanLoai, @TenPhanLoai )";

            using (SqlCommand themCmd = new SqlCommand(insertQuery, connection))
            {
                themCmd.Parameters.AddWithValue("@MaPhanLoai", phanLoai.Id);
                themCmd.Parameters.AddWithValue("@TenPhanLoai", phanLoai.Name);

                themCmd.ExecuteNonQuery();
            }
        }

        public static List<Category> TruyenDuLieuVaoList(string chuoi)
        {
            List<Category> ListPhanLoai = new List<Category>();
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                connection.Open();

                string query = $"SELECT * FROM PhanLoai";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string MaPhanLoai = reader["MaPhanLoai"].ToString();
                                string TenPhanLoai = reader["TenPhanLoai"].ToString();

                                ListPhanLoai.Add(new Category(MaPhanLoai,TenPhanLoai));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                }
            }

            return ListPhanLoai;
        }
    }
}
