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
    public partial class FrmCapNhatThongTinHoaDon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = DataAccess.connectionStr;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from ThongTinHoaDon";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvThongTinHoaDon.DataSource = table;
        }
        public FrmCapNhatThongTinHoaDon()
        {
            InitializeComponent();
        }

        private void dtgvThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvThongTinHoaDon.CurrentRow.Index;
            tbMaHoaDon.Text = dtgvThongTinHoaDon.Rows[i].Cells[0].Value.ToString();
            tbMaMonAn.Text = dtgvThongTinHoaDon.Rows[i].Cells[1].Value.ToString();
            cbSoLuong.Text = dtgvThongTinHoaDon.Rows[i].Cells[2].Value.ToString();
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
            command.CommandText = "insert into ThongTinHoaDon values ('" + tbMaHoaDon.Text + "', '" + tbMaMonAn.Text + "', '"+cbSoLuong.Text+"')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from ThongTinHoaDon where MaHoaDon = '" + tbMaHoaDon.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update ThongTinHoaDon set MaMonAn = '" + tbMaMonAn.Text + "', SoLuong = '" + cbSoLuong.Text + "' where MaHoaDon = '"+tbMaHoaDon.Text+"' ";
            command.ExecuteNonQuery();
            loadData();
        }

    }
}
