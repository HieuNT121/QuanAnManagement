using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class FrmTimKiemVatTu : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = DataAccess.connectionStr;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            string TimKiem = "MaNguyenLieu";
            if (cbLuaChon.Text == "Tên Hàng Hóa") TimKiem = "TenNguyenLieu";
            else if (cbLuaChon.Text == "Nhà Cung Cấp") TimKiem = "MaNhaCungCap";
            else if (cbLuaChon.Text == "Đơn Giá") TimKiem = "DonGia";
            command = connection.CreateCommand();
            command.CommandText = "select MaNguyenLieu,TenNguyenLieu,MaNhaCungCap,SoLuong,DonGia,NgayNhap from KhoHang where " + TimKiem + "='" + tbThongTinTimKiem.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvTimKiem.DataSource = table;
        }

        public FrmTimKiemVatTu()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }
    }
}