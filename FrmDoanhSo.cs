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

    public partial class FrmDoanhSo : Form
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
            command.CommandText = "select ThoiGian,TongThu from ThongKe where ThoiGian between ' " + dtpStart.Text + " ' and '" + dtpEnd.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDoanhSo.DataSource = table;
            foreach (DataRow row in table.Rows)
            {
                iTongCong += int.Parse(row["TongThu"].ToString());
            }
            tbTongThu.Text = iTongCong.ToString();

        }
        public FrmDoanhSo()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }
    }
}