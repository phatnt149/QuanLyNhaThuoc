using BUS_QLNT;
using DTO_QLNT;
using GUI_QLNT.Untils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNT
{
    public partial class NCC: Form
    {
        BUS_NhaCC busNCC = new BUS_NhaCC();

        public NCC()
        {
            InitializeComponent();
        }

        private void NCC_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            txtTimKiem.Text = "Nhập id hoặc tên...";
            txtTimKiem.ForeColor = Color.Gray;

            // Mapping cột DataGridView với cột trong SQL
            colTenNCC.DataPropertyName = "tenNcc";
            colLoaiNCC.DataPropertyName = "loaiNcc";
            colMoTa.DataPropertyName = "moTa";
            colMaNcc.DataPropertyName = "maNcc";


            var dtKQ = busNCC.getNhaCC();
            dataGridView1.DataSource = dtKQ;
        }

        public void LoadNhaCC()
        {
            dataGridView1.DataSource = busNCC.getNhaCC();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (row.Cells[0].Value.ToString() != "" && row.Cells[1].Value.ToString() != "")
            {
                string tenNcc = row.Cells[0].Value.ToString();
                string loaiNcc = row.Cells[1].Value.ToString();
                string moTa = row.Cells[2].Value.ToString();
                int id = Convert.ToInt32(row.Cells["colMaNcc"].Value);


                // Tạo DTo
                DTO_NCC ncc = new DTO_NCC(id,tenNcc,loaiNcc,moTa);
               
                if (busNCC.suaNhaCC(ncc))
                {
                    MessageBox.Show("Sửa thành công");
                    this.LoadNhaCC();
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
          "Bạn có chắc chắn muốn xóa dữ liệu này không?",
          "Xác nhận xóa",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning
                                 );
                DataGridViewRow row = dataGridView1.CurrentRow;
                int id = Convert.ToInt32(row.Cells["colMaNcc"].Value);
                if (result == DialogResult.Yes)
                {
                    if (busNCC.xoaNhaCC(id))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView1.DataSource = busNCC.getNhaCC(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhà cung cấp muốn xóa");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string value = txtTimKiem.Text.Trim();

            if (int.TryParse(value, out int so))
            {
                // Nếu là số
                dataGridView1.DataSource = busNCC.timNhaCCTheoMaNcc(so);
            }
            else
            {
                // Nếu không phải số
                dataGridView1.DataSource = busNCC.timNhaCCTheoTen(txtTimKiem.Text);
                //DataGridViewRow row = dataGridView1.CurrentRow;
                //string s = row.Cells["colMaNcc"].Value;
                //dataGridView1.DataSource = busNCC.timNhaCCTheoMaNcc(id);

            }
        }
        

        private void txtTimKiem_Click_1(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_Leave_1(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                dataGridView1.DataSource = busNCC.getNhaCC();
                txtTimKiem.Text = "Nhập id hoặc tên...";
            }
        }

        private void btnAddrow_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            DataRow newRow = dt.NewRow(); // Tạo dòng rỗng
            dt.Rows.Add(newRow);

            btnAddrow.Visible = false;
            btnSave.Visible = false;
            btnDelete.Visible = false;
            btnCancel.Visible = true;
            btnAddToDB.Visible = true;

        }

        private void btnAddToDB_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (row.Cells[0].Value.ToString() != "" && row.Cells[1].Value.ToString() != "")
            {
                string tenNcc = row.Cells[0].Value.ToString();
                string loaiNcc = row.Cells[1].Value.ToString();
                string moTa = row.Cells[2].Value.ToString();
                // Tạo DTo
                DTO_NCC ncc = new DTO_NCC(1, tenNcc, loaiNcc, moTa);
                if (busNCC.themNhaCC(ncc))
                {
                    MessageBox.Show("Thêm thành công");
                    this.LoadNhaCC();
                    btnAddrow.Visible = true;
                    btnSave.Visible = true;
                    btnDelete.Visible = true;
                    btnCancel.Visible = false;
                    btnAddToDB.Visible = false;
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                    btnAddrow.Visible = true;
                    btnSave.Visible = true;
                    btnDelete.Visible = true;
                    btnCancel.Visible = false;
                    btnAddToDB.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            this.LoadNhaCC();

            btnAddrow.Visible = true;
            btnSave.Visible = true;
            btnDelete.Visible = true;
            btnCancel.Visible = false;
            btnAddToDB.Visible = false;
        }
    }
}
