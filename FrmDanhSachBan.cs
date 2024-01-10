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
    public partial class FrmDanhSachBan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = DataAccess.connectionStr;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Ban";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvDanhSachBan.DataSource = table;
        }
        public FrmDanhSachBan()
        {
            InitializeComponent();
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
            command.CommandText = "insert into Ban values ('" + tbMaBan.Text + "', '" + tbTenBan.Text + "', N'" + cbTrangThai.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Ban where MaBan = '" + tbMaBan.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Ban set TenBan = '" + tbTenBan.Text + "', TrangThai = N'" + cbTrangThai.Text + "' where MaBan = '" + tbMaBan.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void dtgvDanhSachBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvDanhSachBan.CurrentRow.Index;
            tbMaBan.Text = dtgvDanhSachBan.Rows[i].Cells[0].Value.ToString();
            tbTenBan.Text = dtgvDanhSachBan.Rows[i].Cells[1].Value.ToString();
            cbTrangThai.Text = dtgvDanhSachBan.Rows[i].Cells[2].Value.ToString();
        }
    }
}
