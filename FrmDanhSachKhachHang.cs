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
    public partial class FrmDanhSachKhachHang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = DataAccess.connectionStr;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvDanhSachKhachHang.DataSource = table;
        }
        public FrmDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void dtgvDanhSachKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbMaKhachHang.ReadOnly = true;
            int i;
            i = dtgvDanhSachKhachHang.CurrentRow.Index;
            tbMaKhachHang.Text = dtgvDanhSachKhachHang.Rows[i].Cells[0].Value.ToString();
            tbTenKhachHang.Text = dtgvDanhSachKhachHang.Rows[i].Cells[1].Value.ToString();
            tbSoDienThoai.Text = dtgvDanhSachKhachHang.Rows[i].Cells[2].Value.ToString();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into KhachHang values ('" + tbMaKhachHang.Text + "', '" + tbTenKhachHang.Text + "', '" + tbSoDienThoai.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from KhachHang where MaKhachHang = '" + tbMaKhachHang.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KhachHang set TenKhachHang = '" + tbTenKhachHang.Text + "', SoDienThoai = '" + tbSoDienThoai.Text + "' where MaKhachHang = '" + tbMaKhachHang.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

    }
}
