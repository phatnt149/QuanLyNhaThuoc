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
    public partial class NhapHang : Form
    {
        BUS_NhapHang busNhapHang = new BUS_NhapHang();
        BUS_Thuoc busThuoc = new BUS_Thuoc();
        BUS_NhanVien busNhanVien = new BUS_NhanVien();

        public NhapHang()
        {
            InitializeComponent();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            dataGridView_DonHang.AutoGenerateColumns = false;

            LoadNhapHang();
            loadThuocComboBox();
            loadNhanVienComboBox();
        }

        private void LoadNhapHang()
        {
            // Mapping cột DataGridView với cột trong SQL
            maNhapHang.DataPropertyName = "maNhapHang";
            ngayNhap.DataPropertyName = "ngayNhap";
            maThuoc.DataPropertyName = "maThuoc";
            donViNhap.DataPropertyName = "donViNhap";
            giaTriQuyDoi.DataPropertyName = "giaTriQuyDoi";
            soLuongNhap.DataPropertyName = "soLuongNhap";
            giaNhap.DataPropertyName = "giaNhap";
            moTa.DataPropertyName = "moTa";
            thanhTien.DataPropertyName = "thanhTien";
            userName.DataPropertyName = "userName";
            var dtKQ = busNhapHang.Get();
            dataGridView_DonHang.DataSource = dtKQ;
        }

        private void loadThuocComboBox()
        {
            var dtKQ = busThuoc.GetSimple();
            comboBoxThuoc_NhapHang.DataSource = dtKQ;
            comboBoxThuoc_NhapHang.DisplayMember = "tenThuoc";
            comboBoxThuoc_NhapHang.ValueMember = "maThuoc";

            comboBoxThuoc_NhapHang.SelectedIndex = -1; // không chọn mục nào khi mới load
        }

        private void loadNhanVienComboBox()
        {
            var dtKQ = busNhanVien.GetSimple();
            comboBoxNhanVien_NhapHang.DataSource = dtKQ;
            comboBoxNhanVien_NhapHang.DisplayMember = "tenNhanVien";
            comboBoxNhanVien_NhapHang.ValueMember = "userName";
            comboBoxNhanVien_NhapHang.SelectedIndex = -1; // không chọn mục nào khi mới load
        }

        private void dataGridView_DonHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView_DonHang.SelectedRows[0];

            labelDangChon_NhapHang.Text = "Mã nhập hàng đang chọn: " + dataGridViewRow.Cells["maNhapHang"].Value.ToString();

            comboBoxNhanVien_NhapHang.SelectedValue = dataGridViewRow.Cells["userName"].Value.ToString();
            comboBoxThuoc_NhapHang.SelectedValue = Convert.ToInt32(dataGridViewRow.Cells["maThuoc"].Value.ToString());

            textBoxDonViNhap_NhapHang.Text = dataGridViewRow.Cells["donViNhap"].Value.ToString();
            textBoxGiapNhap_NhapHang.Text = dataGridViewRow.Cells["giaNhap"].Value.ToString();
            textBoxGiaTriQuyDoi_NhapHang.Text = dataGridViewRow.Cells["giaTriQuyDoi"].Value.ToString();
            textBoxMoTa_NhapHang.Text = dataGridViewRow.Cells["moTa"].Value.ToString();
            textBoxSoLuongNhap_NhapHang.Text = dataGridViewRow.Cells["soLuongNhap"].Value.ToString();
            textBoxThanhTien_NhapHang.Text = dataGridViewRow.Cells["thanhTien"].Value.ToString();
            dateTimeNgayNhap_NhapHang.Text = dataGridViewRow.Cells["ngayNhap"].Value.ToString();

            buttonThem_NhapHang.Visible = true;
            buttonSua_NhapHang.Visible = false;
            buttonXoa_NhapHang.Visible = false;
            buttonBoChon_NhapHang.Enabled = false;

            buttonThem_NhapHang.Visible = false;
            buttonSua_NhapHang.Visible = true;
            buttonXoa_NhapHang.Visible = true;
            buttonBoChon_NhapHang.Enabled = true;
        }

        private void buttonBoChon_NhapHang_Click(object sender, EventArgs e)
        {
            labelDangChon_NhapHang.Text = "Mã nhập hàng đang chọn: ";
            comboBoxNhanVien_NhapHang.SelectedIndex = -1;
            comboBoxThuoc_NhapHang.SelectedIndex = -1;

            textBoxDonViNhap_NhapHang.Text = "";
            textBoxGiapNhap_NhapHang.Text = "";
            textBoxGiaTriQuyDoi_NhapHang.Text = "";
            textBoxMoTa_NhapHang.Text = "";
            textBoxSoLuongNhap_NhapHang.Text = "";
            textBoxThanhTien_NhapHang.Text = "";
            dateTimeNgayNhap_NhapHang.Text = "";

            buttonThem_NhapHang.Visible = true;
            buttonSua_NhapHang.Visible = false;
            buttonXoa_NhapHang.Visible = false;
            buttonBoChon_NhapHang.Enabled = false;

            dataGridView_DonHang.ClearSelection();
        }

        private void buttonThem_NhapHang_Click(object sender, EventArgs e)
        {
            if (comboBoxNhanVien_NhapHang.SelectedIndex == -1 || comboBoxThuoc_NhapHang.SelectedIndex == -1
                || textBoxDonViNhap_NhapHang.Text == "" || textBoxGiapNhap_NhapHang.Text == ""
                || textBoxGiaTriQuyDoi_NhapHang.Text == "" || textBoxSoLuongNhap_NhapHang.Text == ""
                || dateTimeNgayNhap_NhapHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string userName = comboBoxNhanVien_NhapHang.SelectedValue.ToString();
                int maThuoc = Convert.ToInt32(comboBoxThuoc_NhapHang.SelectedValue);
                string donViNhap = textBoxDonViNhap_NhapHang.Text;
                int giaTriQuyDoi = Convert.ToInt32(textBoxGiaTriQuyDoi_NhapHang.Text);
                int soLuongNhap = Convert.ToInt32(textBoxSoLuongNhap_NhapHang.Text);
                decimal giaNhap = Convert.ToDecimal(textBoxGiapNhap_NhapHang.Text);
                string moTa = textBoxMoTa_NhapHang.Text;
                DateTime ngayNhap = dateTimeNgayNhap_NhapHang.Value;
                // Tạo DTo
                DTO_QLNT.DTO_NhapHang nhapHang = new DTO_NhapHang(0, maThuoc, donViNhap, giaTriQuyDoi, soLuongNhap, giaNhap, moTa, ngayNhap, soLuongNhap * giaNhap, userName);
                if (busNhapHang.Insert(nhapHang))
                {
                    MessageBox.Show("Thêm thành công");
                    this.LoadNhapHang();
                    buttonBoChon_NhapHang.PerformClick(); // reset form
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho Giá trị quy đổi, Số lượng nhập và Giá nhập.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSua_NhapHang_Click(object sender, EventArgs e)
        {
            if (dataGridView_DonHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhập hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxNhanVien_NhapHang.SelectedIndex == -1 || comboBoxThuoc_NhapHang.SelectedIndex == -1
                || textBoxDonViNhap_NhapHang.Text == "" || textBoxGiapNhap_NhapHang.Text == ""
                || textBoxGiaTriQuyDoi_NhapHang.Text == "" || textBoxSoLuongNhap_NhapHang.Text == ""
                || dateTimeNgayNhap_NhapHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maNhapHang = Convert.ToInt32(labelDangChon_NhapHang.Text.Split(':')[1].Trim());
                string userName = comboBoxNhanVien_NhapHang.SelectedValue.ToString();
                int maThuoc = Convert.ToInt32(comboBoxThuoc_NhapHang.SelectedValue);
                string donViNhap = textBoxDonViNhap_NhapHang.Text;
                int giaTriQuyDoi = Convert.ToInt32(textBoxGiaTriQuyDoi_NhapHang.Text);
                int soLuongNhap = Convert.ToInt32(textBoxSoLuongNhap_NhapHang.Text);
                decimal giaNhap = Convert.ToDecimal(textBoxGiapNhap_NhapHang.Text);
                string moTa = textBoxMoTa_NhapHang.Text;
                DateTime ngayNhap = dateTimeNgayNhap_NhapHang.Value;
                // Tạo DTo
                DTO_QLNT.DTO_NhapHang nhapHang = new DTO_NhapHang(maNhapHang, maThuoc, donViNhap, giaTriQuyDoi, soLuongNhap, giaNhap, moTa, ngayNhap, soLuongNhap * giaNhap, userName);
                if (busNhapHang.Update(nhapHang))
                {
                    MessageBox.Show("Sửa thành công");
                    this.LoadNhapHang();
                    buttonBoChon_NhapHang.PerformClick(); // reset form
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho Giá trị quy đổi, Số lượng nhập và Giá nhập.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_NhapHang_Click(object sender, EventArgs e)
        {
            if (dataGridView_DonHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhập hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNhapHang = Convert.ToInt32(dataGridView_DonHang.SelectedRows[0].Cells["maNhapHang"].Value.ToString());
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá đơn nhập hàng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (busNhapHang.Delete(maNhapHang, Convert.ToInt32(dataGridView_DonHang.SelectedRows[0].Cells["maThuoc"].Value.ToString())))
                    {
                        MessageBox.Show("Xoá thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadNhapHang();
                        buttonBoChon_NhapHang.PerformClick(); // reset form
                    }
                    else
                    {
                        MessageBox.Show("Xoá thuốc không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xoá thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
