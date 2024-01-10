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
    public partial class FrmLuongKhach : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-MC\SQLEXPRESS;Initial Catalog=QuanLyQuanAn;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            DateTime s = dtpkStart.Value;
            string start = s.ToString("yyyy-MM-dd");
            DateTime e = dtpkEnd.Value;
            string end = e.ToString("yyyy-MM-dd");
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang kh join HoaDon hd on kh.MaKhachHang = hd.MaKhachHang where hd.NgayThanhToan between start and end";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvLuongKhach.DataSource = table;
        }
        public FrmLuongKhach()
        {
            InitializeComponent();
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }
    }
}