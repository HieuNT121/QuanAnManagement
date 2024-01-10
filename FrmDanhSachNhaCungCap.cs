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
    public partial class FrmDanhSachNhaCungCap : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = DataAccess.connectionStr;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhaCungCap";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvDanhSachNhaCungCap.DataSource = table;
        }

        public FrmDanhSachNhaCungCap()
        {
            InitializeComponent();
        }

        private void dtgvDanhSachNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvDanhSachNhaCungCap.CurrentRow.Index;
            txtMaNhaCungCap.Text = dtgvDanhSachNhaCungCap.Rows[i].Cells[0].Value.ToString();
            txtTenNhaCungCap.Text = dtgvDanhSachNhaCungCap.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dtgvDanhSachNhaCungCap.Rows[i].Cells[2].Value.ToString();
            txtSoDienThoai.Text = dtgvDanhSachNhaCungCap.Rows[i].Cells[3].Value.ToString();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into NhaCungCap values ('" + txtMaNhaCungCap.Text + "', '" + txtTenNhaCungCap.Text + "', '" + txtDiaChi.Text + "', '" + txtSoDienThoai.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NhaCungCap where MaNhaCungCap = '"+txtMaNhaCungCap.Text+"'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update NhaCungCap set TenNhaCungCap = '" + txtTenNhaCungCap.Text + "', DiaChi = '" + txtDiaChi.Text + "', SoDienThoai = '" + txtSoDienThoai.Text + "' where MaNhaCungCap = '"+txtMaNhaCungCap.Text+"'";
            command.ExecuteNonQuery();
            loadData();
        }

    }
}
