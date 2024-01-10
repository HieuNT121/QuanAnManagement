using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;



namespace QuanLyQuanAn
{
    public partial class FrmDatDon : Form
    {

        SqlConnection connection = new SqlConnection();
        //SqlCommand command;
        string str = DataAccess.connectionStr;
        string sql;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableTemp = new DataTable();

        int i = 0;
        Status[] table = new Status[4];
        public FrmDatDon()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                table[i] = new Status();
            }
            connection.ConnectionString = str;
            connection.Open();
        }

        public void changeStatus(Button button)
        {
            if (table[i].status == false)
            {
                table[i].status = true;
                dtgvHoaDon.DataSource = table[i].dt;
                button.BackColor = Color.Red;
            }
            else
            {
                if (table[i].ThanhToan == false)
                {
                    dtgvHoaDon.DataSource = table[i].dt;
                    dtgvHoaDon.Refresh();
                }
                else
                {
                    button.BackColor = Color.Aqua;
                    table[i].status = false;
                    table[i].ThanhToan = false;
                    table[i].dt.Clear();
                }
            }
        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan1);
            i = 0;
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan2);
            i = 1;
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan3);
            i = 2;
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan4);
            i = 3;
        }


        private void btXoaMon_Click(object sender, EventArgs e)
        {
            int vitri = dtgvHoaDon.CurrentRow.Index;
            table[i].iTongTien -= int.Parse(dtgvHoaDon.CurrentRow.Cells[1].Value.ToString()) * int.Parse(dtgvHoaDon.CurrentRow.Cells[2].Value.ToString()); ;
            table[i].XoaMonAn(vitri);
            dtgvHoaDon.DataSource = table[i].dt;
            dtgvHoaDon.Refresh();
            tbTongTien.Text = table[i].iTongTien.ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            table[i].ThanhToan = true;
            sql = "SELECT * FROM ThongKeDoanhSo Where ThoiGian = '" + dtp.Text + "'";
            tableTemp.Clear();
            adapter = new SqlDataAdapter(sql, connection);
            tableTemp.Clear();
            adapter.Fill(tableTemp);
            //row = table.Rows[0];
            if (tableTemp.Rows.Count == 0)
            {
                sql = "INSERT INTO ThongKe(ThoiGian,TongThu,TongChi,LuongKhach) VALUES ('";
                sql += dtp.Text + "'," + table[i].iTongTien.ToString() + "',0);";
            }
            else
            {
                sql = "UPDATE ThongKeDoanhSo SET TongChi = " + table[i].iTongTien.ToString() + "Where ThoiGian = '" + dtp.Text + "'"; ;
            }
            cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thanh Toán Thành Công!!!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            sql = "Select DonGia from ThucDon Where TenMonAn = '" + tbTenMonAn.Text + "'";
            adapter = new SqlDataAdapter(sql, connection);
            tableTemp.Clear();
            adapter.Fill(tableTemp);
            int DonGia = int.Parse(tableTemp.Columns[0].ToString());

            table[i].ThemMonAn(tbTenMonAn.Text, int.Parse(nUDSoLuong.Value.ToString()), DonGia);
            dtgvHoaDon.DataSource = table[i].dt;
            dtgvHoaDon.Refresh();
            foreach (DataRow row in table[i].dt.Rows)
            {
                table[i].iTongTien += int.Parse(row[1].ToString()) * int.Parse(row[2].ToString());
            }
            tbTongTien.Text = table[i].iTongTien.ToString();
        }

        private void flpBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan5);
            i = 4;
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan6);
            i = 5;
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan7);
            i = 6;
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan8);
            i = 7;
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan9);
            i = 8;
        }

        private void btnBan10_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan10);
            i = 9;
        }

        private void btnBan11_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan11);
            i = 10;
        }

        private void btnBan12_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan12);
            i = 11;
        }

        private void btnBan13_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan13);
            i = 12;
        }

        private void btnBan14_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan14);
            i = 13;
        }

        private void btnBan15_Click(object sender, EventArgs e)
        {
            changeStatus(btnBan15);
            i = 14;
        }
    }
    public class Status
    {
        public bool status;
        public bool ThanhToan;
        public int iTongTien;
        public DataTable dt;

        public Status()
        {
            status = false;
            ThanhToan = false;
            dt = new DataTable();
            dt.Columns.Add("Tên Món", typeof(string));
            dt.Columns.Add("Số Lượng", typeof(int));
            dt.Columns.Add("Đơn Giá", typeof(int));
            iTongTien = 0;
        }

        public void ThemMonAn(string tenMon, int soLuong, int donGia)
        {
            DataRow dataRow = dt.NewRow();
            dataRow["Tên Món"] = tenMon;
            dataRow["Số Lượng"] = soLuong;
            dataRow["Đơn Giá"] = donGia;
            this.dt.Rows.Add(dataRow);
        }

        public void XoaMonAn(int index)
        {
            this.dt.Rows.RemoveAt(index);
        }
    }
}