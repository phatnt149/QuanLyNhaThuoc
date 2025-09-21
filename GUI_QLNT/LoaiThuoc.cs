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
using BUS_QLNT;

namespace GUI_QLNT
{
    public partial class LoaiThuoc : Form
    {
        BUS_LoaiThuoc busLoaiThuoc = new BUS_LoaiThuoc();

        public LoaiThuoc()
        {
            InitializeComponent();
        }

        private void LoaiThuoc_Load(object sender, EventArgs e)
        {
            dataGridView_LoaiThuoc.AutoGenerateColumns = false;

            loadLoaiThuoc();
        }

        private void loadLoaiThuoc()
        {
            // Mapping cột DataGridView với cột trong SQL
            maLTc.DataPropertyName = "maLt";
            tenLt.DataPropertyName = "tenLt";
            moTa.DataPropertyName = "moTa";

            var dtKQ = busLoaiThuoc.Get();
            dataGridView_LoaiThuoc.DataSource = dtKQ;
        }


        /// <summary>
        /// Xử lý việc chọn hàng trên Datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_LoaiThuoc_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView_LoaiThuoc.SelectedRows[0];

            labelDangChon_LoaiThuoc.Text = "Mã loại thuốc đang chọn: " + dataGridViewRow.Cells["maLTc"].Value.ToString();
            textBoxTenLoaiThuoc_LoaiThuoc.Text = dataGridViewRow.Cells["tenLt"].Value.ToString();
            textBoxMoTa_LoaiThuoc.Text = dataGridViewRow.Cells["moTa"].Value.ToString();

            buttonThem_LoaiThuoc.Visible = false;
            buttonSua_LoaiThuoc.Visible = true;
            buttonXoa_LoaiThuoc.Visible = true;
            buttonBoChon_LoaiThuoc.Enabled = true;
        }

        /// <summary>
        /// Xử lý việc bỏ chọn datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBoChon_LoaiThuoc_Click(object sender, EventArgs e)
        {
            labelDangChon_LoaiThuoc.Text = "Mã loại thuốc đang chọn: ";
            textBoxTenLoaiThuoc_LoaiThuoc.Text = "";
            textBoxMoTa_LoaiThuoc.Text = "";

            buttonThem_LoaiThuoc.Visible = true;
            buttonSua_LoaiThuoc.Visible = false;
            buttonXoa_LoaiThuoc.Visible = false;
            buttonBoChon_LoaiThuoc.Enabled = false;
            dataGridView_LoaiThuoc.ClearSelection();
        }

        /// <summary>
        /// Xử lý việc tìm kiếm loại thuốc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTimKiem_LoaiThuoc_Click(object sender, EventArgs e)
        {
            if (textBoxTimKiem_LoaiThuoc.Text != "")
            {
                var dtKQ = busLoaiThuoc.Get(textBoxTimKiem_LoaiThuoc.Text);
                dataGridView_LoaiThuoc.DataSource = dtKQ;
            }
            else
            {
                loadLoaiThuoc();
            }
        }

        /// <summary>
        /// Xử lý việc hủy tìm kiếm loại thuốc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHuyTimKiem_LoaiThuoc_Click(object sender, EventArgs e)
        {
            textBoxTimKiem_LoaiThuoc.Text = "";
            loadLoaiThuoc();
        }

        /// <summary>
        /// Xử lý việc thêm loại thuốc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonThem_LoaiThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTenLoaiThuoc_LoaiThuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxMoTa_LoaiThuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (busLoaiThuoc.Insert(textBoxTenLoaiThuoc_LoaiThuoc.Text, textBoxMoTa_LoaiThuoc.Text))
                {
                    MessageBox.Show("Thêm loại thuốc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLoaiThuoc();
                }
                else
                {
                    MessageBox.Show("Thêm loại thuốc không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xử lý việc sửa loại thuốc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSua_LoaiThuoc_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxTenLoaiThuoc_LoaiThuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxMoTa_LoaiThuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView_LoaiThuoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một loại thuốc để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (busLoaiThuoc.Update(
                        Convert.ToInt32(dataGridView_LoaiThuoc.SelectedRows[0].Cells["maLTc"].Value.ToString()),
                        textBoxTenLoaiThuoc_LoaiThuoc.Text,
                        textBoxMoTa_LoaiThuoc.Text
                        )
                    )
                {
                    MessageBox.Show("Sửa loại thuốc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLoaiThuoc();
                }
                else
                {
                    MessageBox.Show("Sửa loại thuốc không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xoá loại thuốc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonXoa_LoaiThuoc_Click(object sender, EventArgs e)
        {
            if (dataGridView_LoaiThuoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một loại thuốc để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (busLoaiThuoc.Delete(
                        Convert.ToInt32(dataGridView_LoaiThuoc.SelectedRows[0].Cells["maLTc"].Value.ToString())
                        )
                    )
                {
                    MessageBox.Show("Xoá loại thuốc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLoaiThuoc();
                }
                else
                {
                    MessageBox.Show("Xoá loại thuốc không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xoá: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
