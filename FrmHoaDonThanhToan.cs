using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class FrmHoaDonThanhToan : Form
    {
        Bitmap memoryImage; 

        SqlConnection connection;
        SqlCommand command;
        string str = DataAccess.connectionStr;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvDanhSachHoaDonThanhToan.DataSource = table;
        }
        public FrmHoaDonThanhToan()
        {
            InitializeComponent();
        }

        private void dtgvDanhSachHoaDonThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvDanhSachHoaDonThanhToan.CurrentRow.Index;
            tbMaHoaDon.Text = dtgvDanhSachHoaDonThanhToan.Rows[i].Cells[0].Value.ToString();
            tbMaNhanVien.Text = dtgvDanhSachHoaDonThanhToan.Rows[i].Cells[1].Value.ToString();
            tbMaBan.Text = dtgvDanhSachHoaDonThanhToan.Rows[i].Cells[2].Value.ToString();
            tbMaKhachHang.Text = dtgvDanhSachHoaDonThanhToan.Rows[i].Cells[3].Value.ToString();
            dtpkNgayThanhToan.Text = dtgvDanhSachHoaDonThanhToan.Rows[i].Cells[4].Value.ToString();
            tbTongTien.Text = dtgvDanhSachHoaDonThanhToan.Rows[i].Cells[5].Value.ToString();
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
            command.CommandText = "insert into HoaDon values ('" + tbMaHoaDon.Text + "', '" + tbMaNhanVien.Text + "', '" + tbMaBan.Text + "', '" + tbMaKhachHang.Text + "', '"+dtpkNgayThanhToan.Text+"','"+tbTongTien.Text+"')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HoaDon where MaHoaDon = '" + tbMaHoaDon.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            command = connection.CreateCommand();
            command.CommandText = "update HoaDon set MaNhanVien = '" + tbMaNhanVien.Text + "', MaBan = '" + tbMaBan.Text + "', MaKhachHang = '" + tbMaKhachHang.Text + "', NgayThanhToan = '" + dtpkNgayThanhToan.Text + "', TongTien = '"+tbTongTien.Text+"' where MaHoaDon = '" + tbMaHoaDon.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btXuatHoaDon_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width * 2 / 5, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

    }
}
