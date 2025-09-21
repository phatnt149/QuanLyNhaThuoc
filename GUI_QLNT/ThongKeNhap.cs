using BUS_QLNT;
using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace GUI_QLNT
{
    public partial class ThongKeNhap: Form
    {
        BUS_ThongKeNhap busTKN = new BUS_ThongKeNhap();
        public ThongKeNhap()
        {
            InitializeComponent();
        }
        public void LoadThongKe()
        {
            dataGridView1.DataSource = busTKN.GetThongKeNhap();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
               if(comboBox1.Text != "Ngày")
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
                    dataGridView1.DataSource=busTKN.GetChiTietNhapHangTheoNgay(dateTimePicker1, dateTimePicker2);
                }
                else if(comboBox1.Text == "Tháng")
                {
                    dataGridView1.DataSource = busTKN.GetChiTietNhapHangTheoThang(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
                }
                else
                {
                    dataGridView1.DataSource = busTKN.GetChiTietNhapHangTheoNam(dateTimePicker1.Value.Year);
                }
            }
        }

        private void ThongKeNhap_Load(object sender, EventArgs e)
        {
            // Mapping cột DataGridView với cột trong SQL
            colDonViNhap.DataPropertyName = "donViNhap";
            colGiaNhap.DataPropertyName = "giaNhap";
            colGiaTriQuyDoi.DataPropertyName = "giaTriQuyDoi";
            colHamLuong.DataPropertyName = "hamLuong";
            colHangSanXuat.DataPropertyName = "hangSx";
            colMaNhapThuoc.DataPropertyName = "maNhapHang";
            colMoTa.DataPropertyName = "moTa";
            colNgayNhap.DataPropertyName = "ngayNhap";
            colSoLuongNhap.DataPropertyName = "soLuongNhap";
            colTenThuoc.DataPropertyName = "tenThuoc";
            colThanhTien.DataPropertyName = "thanhTien";
            colUserName.DataPropertyName = "userName";
    
            dataGridView1.DataSource = busTKN.GetThongKeNhap();
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
    }
}
