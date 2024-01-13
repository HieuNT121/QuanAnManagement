using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyQuanAn
{
    public partial class FrmKetNoiDB : Form
    {
        public string DataSource;
        public FrmKetNoiDB()
        {
            InitializeComponent();
            DataSource = File.ReadAllText("DataSource.txt");
            DataAccess.connectionStr = tbketNoi.Text;
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess.connectionStr = tbketNoi.Text;
                KetNoiCSDL.Connect();
                if(tbketNoi.Text != DataSource)
                {
                    File.WriteAllText("DataSource.txt", tbketNoi.Text);
                }
                FrmDangNhap frmDN = new FrmDangNhap();
                frmDN.Show();
                this.Hide();
            }
            catch {
                MessageBox.Show("Không thể kết nối với CSDL, Vui Lòng nhập lại Data Source!!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void FrmKetNoiDB_Load(object sender, EventArgs e)
        {
            tbketNoi.Text = DataSource;
        }
    }
}
