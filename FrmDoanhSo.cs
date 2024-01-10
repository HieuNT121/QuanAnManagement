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
        string str = @"Data Source=DESKTOP-MC\SQLEXPRESS;Initial Catalog=QuanLyQuanAn;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            int iTongThu = 0;
            int iTongChi = 0;
            command = connection.CreateCommand();
            command.CommandText = "select * from ThongKeDoanhSo where ThoiGian between ' " + dtpStart.Text + " ' and '" + dtpEnd.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDoanhSo.DataSource = table;
            foreach (DataRow row in table.Rows)
            {
                iTongChi += int.Parse(row["TongThu"].ToString());
                iTongChi += int.Parse(row["TongChi"].ToString());
            }
            tbTongChi.Text = iTongChi.ToString();
            tbTongThu.Text = iTongThu.ToString();

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