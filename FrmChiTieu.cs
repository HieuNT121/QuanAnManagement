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
    public partial class FrmChiTieu : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = DataAccess.connectionStr;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            int iTongCong = 0;
            command = connection.CreateCommand();
            command.CommandText = "select ThoiGian,TongChi from ThongKe where ThoiGian between ' " + dtpkNgaybatDau.Text + " ' and '" + dtpkNgayKetThuc.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvChiTieu.DataSource = table;
            foreach (DataRow row in table.Rows)
            {
                iTongCong += int.Parse(row["TongChi"].ToString());
            }
            tbTongCong.Text = iTongCong.ToString();

        }
        public FrmChiTieu()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }
    }
}
