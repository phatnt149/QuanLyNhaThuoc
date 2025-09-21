using BUS_QLNT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace GUI_QLNT
{
    public partial class ThongKeBan: Form
    {
        BUS_ThongKeBan busTKB = new BUS_ThongKeBan();
        public ThongKeBan()
        {
            InitializeComponent();
        }

        public void LoadThongKe()
        {
            dataGridView1.DataSource = busTKB.GetThongKeBan();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (comboBox1.Text != "Ngày")
                {
                    dateTimePicker2.Visible = false;
                    // Chỉ hiển thị tháng/năm
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "MM/yyyy";  // Hiển thị tháng/năm
                    dateTimePicker1.ShowUpDown = true;
                }
                else
                {

                    dateTimePicker2.Visible = true;
                }
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {

                if (comboBox1.Text == "Ngày")
                {
                    dataGridView1.DataSource = busTKB.GetChiTietBanHangTheoNgay(dateTimePicker1, dateTimePicker2);
                }
                else if (comboBox1.Text == "Tháng")
                {
                    dataGridView1.DataSource = busTKB.GetChiTietBanHangTheoThang(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
                }
                else
                {
                    dataGridView1.DataSource = busTKB.GetChiTietBanHangTheoNam(dateTimePicker1.Value.Year);
                }
            }
        }

        private void ThongKeBan_Load(object sender, EventArgs e)
        {
            // Mapping cột DataGridView với cột trong SQL
            colDonVi.DataPropertyName = "donViBan";
            colGiaBanTheoDonVi.DataPropertyName = "giaBanTheoDonVi";
            colGioThanhtoan.DataPropertyName = "gioThanhToan";
            colHamLuong.DataPropertyName = "hamLuong";
            colHangSx.DataPropertyName = "hangSx";
            colMaCthd.DataPropertyName = "maCthd";
            colMaHoaDon.DataPropertyName = "maHd";
            colMaThuoc.DataPropertyName = "maThuoc";
            colSoLuong.DataPropertyName = "soLuong";
            colTenKhachhang.DataPropertyName = "hoTen";
            colTenThuoc.DataPropertyName = "tenThuoc";
            colThanhTien.DataPropertyName = "thanhTien";
            colTrangThai.DataPropertyName = "trangThai";
            colUserName.DataPropertyName = "userName";

            dataGridView1.DataSource = busTKB.GetThongKeBan();
        }

        public void ExportDataGridViewToExcel(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            // Tạo ứng dụng Excel
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel chưa được cài đặt!");
                return;
            }

            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(Missing.Value);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets[1];

            // Xuất header cột
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                xlWorkSheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }

            // Xuất dữ liệu
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    xlWorkSheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }

            // Hiển thị Excel
            xlApp.Visible = true;
            xlApp.UserControl = true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToExcel(dataGridView1);
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                LoadThongKe();
            }
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            DataRow newRow = dt.NewRow(); // Tạo dòng rỗng
            dt.Rows.Add(newRow);

            int lastRowIndex = dataGridView1.AllowUserToAddRows
                        ? dataGridView1.Rows.Count - 2
                        : dataGridView1.Rows.Count - 1;

            DataGridViewRow lastRow = dataGridView1.Rows[lastRowIndex];

            lastRow.Cells["colDonVi"].Value = "TỔNG THÀNH TIỀN";
            decimal tongTien = 0m;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; // bỏ qua dòng trắng

                if (row.Cells["colThanhTien"].Value != null)
                {
                    decimal value;
              
                    // Thử convert sang số, nếu thành công thì cộng dồn
                    if (decimal.TryParse(row.Cells["colThanhTien"].Value.ToString(), out value))
                    {
                        tongTien += value;
                    }
                }
            }

            lastRow.Cells["colThanhTien"].Value= tongTien;
        }
    }
}
