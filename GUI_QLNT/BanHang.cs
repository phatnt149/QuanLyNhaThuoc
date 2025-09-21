using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNT;
using DTO_QLNT;

namespace GUI_QLNT
{
    public partial class BanHang : Form
    {
        BUS_Thuoc busThuoc = new BUS_Thuoc();

        public BanHang()
        {
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            loadThuocComboBox();
        }

        private void loadThuocComboBox()
        {
            var dtKQ = busThuoc.Get();
            maThuoc.DataSource = dtKQ;
            maThuoc.DisplayMember = "tenThuoc";
            maThuoc.ValueMember = "maThuoc";
        }

        private void dataGridViewChiTietHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra cột "Thuốc"
            if (dataGridViewChiTietHoaDon.Columns[e.ColumnIndex].Name == "maThuoc" && e.RowIndex >= 0)
            {
                var cell = dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells["maThuoc"];
                if (cell.Value != null)
                {
                    int maThuoc = Convert.ToInt32(cell.Value);

                    // Lấy thông tin thuốc từ nguồn dữ liệu (dtThuoc)
                    DataTable dtThuoc = busThuoc.GetWithPrice(maThuoc);
                    if (dtThuoc.Rows.Count > 0)
                    {
                        DataRow row = dtThuoc.Rows[0];
                        decimal giaBan = Convert.ToDecimal(row["giaBan"]);
                        string donViBan = row["donViBan"].ToString();
                        // Cập nhật giá bán vào cột tương ứng
                        dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells["giaBanTheoDonVi"].Value = giaBan;
                        dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells["donVi"].Value = donViBan;

                        // Cập nhật thành tiền nếu có số lượng
                        if (dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells["soLuong"].Value != null)
                        {
                            int soLuong = Convert.ToInt32(dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells["soLuong"].Value);
                            dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells["thanhTien"].Value = giaBan * soLuong;
                            CapNhatTongTien();
                        }
                        else
                        {
                            dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells["thanhTien"].Value = 0;
                            CapNhatTongTien();
                        }
                    }
                }
            }

            // Kiểm tra cột "Số lượng"
            if (dataGridViewChiTietHoaDon.Columns[e.ColumnIndex].Name == "soLuong" && e.RowIndex >= 0)
            {
                var cell = dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells["soLuong"];
                if (cell.Value != null && dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells["giaBanTheoDonVi"].Value != null)
                {
                    dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells["thanhTien"].Value =
                        Convert.ToDecimal(dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells["giaBanTheoDonVi"].Value) *
                        Convert.ToInt32(cell.Value);
                    CapNhatTongTien();
                }
                else
                {
                    dataGridViewChiTietHoaDon.Rows[e.RowIndex].Cells["thanhTien"].Value = 0;
                    CapNhatTongTien();
                }
            }

            
        }

        /// <summary>
        /// Cho phép cập nhật ngay khi thay đổi giá trị trong DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewChiTietHoaDon_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewChiTietHoaDon.IsCurrentCellDirty)
            {
                dataGridViewChiTietHoaDon.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void CapNhatTongTien()
        {
            decimal tongTien = 0;
            Console.WriteLine(dataGridViewChiTietHoaDon.Rows.Count);
            foreach (DataGridViewRow row in dataGridViewChiTietHoaDon.Rows)
            {
                //Console.WriteLine(row);
                if (row.Cells["thanhTien"].Value != null)
                {
                    decimal thanhTien;
                    if (decimal.TryParse(row.Cells["thanhTien"].Value.ToString(), out thanhTien))
                    {
                        tongTien += thanhTien;
                    }
                }
            }
            textBoxTongTien.Text = tongTien.ToString("N0"); // hoặc txtTongTien.Text = ...
        }

        private void dataGridViewChiTietHoaDon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CapNhatTongTien();
        }

        private void dataGridViewChiTietHoaDon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CapNhatTongTien();
        }
    }
}
