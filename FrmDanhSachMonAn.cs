using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyQuanAn
{

    public partial class FrmDanhSachMonAn : Form
    {
        string connectionStr = DataAccess.connectionStr;
        int index = -1;
        public FrmDanhSachMonAn()
        {
            InitializeComponent();
            LoadDataMon();
        }
        void LoadDataMon()
        {
            dtgvMonAn.DataSource = null;
            dtgvMonAn.DataSource = (from mon in DanhSachPhanLoai.Instance.ListMonAn
                                    from cate in DanhSachPhanLoai.Instance.ListCategory
                                    where mon.IdCategory == cate.Id
                                    select new
                                    {
                                        ID = mon.Id,
                                        Tên = mon.Name,
                                        Category = cate.Name,
                                        Giá = mon.Price
                                    }).ToList();
            dtgvMonAn.Refresh();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDataMon();
            dtgvMonAn.DataSource = (from mon in DanhSachPhanLoai.Instance.ListMonAn
                                    from cate in DanhSachPhanLoai.Instance.ListCategory
                                    where mon.IdCategory == cate.Id
                                    && mon.Name == tenTimKiem.Text
                                    select new
                                    {
                                        ID = mon.Id,
                                        Tên = mon.Name,
                                        Category = cate.Name,
                                        Giá = mon.Price
                                    }).ToList();
            dtgvMonAn.Refresh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDataMon();
        }

        private void dtgvMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            tbxIdFood.Text = dtgvMonAn.Rows[index].Cells[0].Value.ToString();
            tbxFoodName.Text = dtgvMonAn.Rows[index].Cells[1].Value.ToString();
            tbxCategory.Text = dtgvMonAn.Rows[index].Cells[2].Value.ToString();
            tbxFoodPrice.Text = dtgvMonAn.Rows[index].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int checkIsNull = 0;
            int checkIsExist = 0;
            int checkIsDuplicated = 0;
            string[] bien = new string[5];
            bien[0] = tbxIdFood.Text;
            bien[1] = tbxFoodName.Text;
            bien[2] = tbxCategory.Text;
            bien[3] = tbxFoodPrice.Text;

            foreach (string a in bien)
            {
                if (a == "")
                {
                    checkIsNull = 1;
                }
            }
            if(checkIsNull == 1)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                foreach (Category a in DanhSachPhanLoai.Instance.ListCategory)
                {
                    if (bien[2] == a.Name)
                    {
                        bien[4] = a.Id;
                        checkIsExist = 1;
                    }
                }

                if (checkIsExist == 0)
                {
                    MessageBox.Show("Không có loại món này trong cửa hàng");
                }
                else
                {
                    foreach (MonAn mon in DanhSachPhanLoai.Instance.ListMonAn)
                    {
                        if (bien[1] == mon.Name)
                        {
                            checkIsDuplicated = 1;
                        }
                    }
                    if (checkIsDuplicated == 1)
                    {
                        MessageBox.Show("Món này đã có trong cửa hàng!");
                    }
                    else
                    {
                        DanhSachPhanLoai.Instance.ListMonAn.Add(new MonAn(bien[0], bien[1], bien[4], bien[3]));
                        LoadDataMon();
                    }
                }
            }
            DataThucDon.CapNhatvaThemDuLieu(DanhSachPhanLoai.Instance.ListMonAn, connectionStr);
            LoadDataMon();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 cột trong bảng");
            }
            int checkIsNull = 0;
            int checkIsExist = 0;
            string[] bien = new string[5];
            bien[0] = tbxIdFood.Text;
            bien[1] = tbxFoodName.Text;
            bien[2] = tbxCategory.Text;
            bien[3] = tbxFoodPrice.Text;

            for (int i = 0; i < 4; i++)
            {
                if (bien[i] == "")
                {
                    checkIsNull = 1;
                }
            }
            if(checkIsNull == 1)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                foreach (Category a in DanhSachPhanLoai.Instance.ListCategory)
                {
                    if (bien[2] == a.Name)
                    {
                        bien[4] = a.Id;
                        checkIsExist = 1;
                    }
                }

                if (checkIsExist == 0)
                {
                    MessageBox.Show("Không có loại món này trong cửa hàng");
                }
                else
                {
                    DanhSachPhanLoai.Instance.ListMonAn[index].Id = bien[0];
                    DanhSachPhanLoai.Instance.ListMonAn[index].Name = bien[1];
                    DanhSachPhanLoai.Instance.ListMonAn[index].IdCategory = bien[4];
                    DanhSachPhanLoai.Instance.ListMonAn[index].Price = bien[3];
                }
            }
            DataThucDon.CapNhatvaThemDuLieu(DanhSachPhanLoai.Instance.ListMonAn, connectionStr);
            LoadDataMon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DanhSachPhanLoai.Instance.ListMonAn.RemoveAt(index);
            string maMonAn = tbxIdFood.Text;
            DataNhaCungCap.Xoa(connectionStr, maMonAn);
            LoadDataMon();
        }

    }
}
