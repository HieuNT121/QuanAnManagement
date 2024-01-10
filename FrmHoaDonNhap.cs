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
    public partial class FrmHoaDonNhap : Form
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
            command.CommandText = "select * from KhoHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgvHoaDonNhap.DataSource = table;
        }
        public FrmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dtgvHoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvHoaDonNhap.CurrentRow.Index;
            tbMaNguyenLieu.Text = dtgvHoaDonNhap.Rows[i].Cells[0].Value.ToString();
            tbTenNguyenLieu.Text = dtgvHoaDonNhap.Rows[i].Cells[1].Value.ToString();
            tbMaNhaCungCap.Text = dtgvHoaDonNhap.Rows[i].Cells[2].Value.ToString();
            tbMaNhanVien.Text = dtgvHoaDonNhap.Rows[i].Cells[6].Value.ToString();
            dtpkNgayNhap.Text = dtgvHoaDonNhap.Rows[i].Cells[5].Value.ToString();

            int tongTien;
            tongTien = Convert.ToInt32(dtgvHoaDonNhap.Rows[i].Cells[3].Value) * Convert.ToInt32(dtgvHoaDonNhap.Rows[i].Cells[4].Value);
            tbTongTien.Text = tongTien.ToString();

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
