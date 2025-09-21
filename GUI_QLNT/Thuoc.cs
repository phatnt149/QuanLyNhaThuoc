using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNT;
using DTO_QLNT;
using GUI_QLNT.Untils;

namespace GUI_QLNT
{
    public partial class Thuoc : Form
    {
        BUS_Thuoc busThuoc = new BUS_Thuoc();
        BUS_LoaiThuoc busLoaiThuoc = new BUS_LoaiThuoc();
        BUS_NhaCC busNhaCC = new BUS_NhaCC();

        public Thuoc()
        {
            InitializeComponent();
        }

        private void Thuoc_Load(object sender, EventArgs e)
        {
            dataGridView_Thuoc.AutoGenerateColumns = false;

            LoadThuocTable();
            LoadLoaiThuocComboBox();
            LoadNhaCungCapComboBox();
        }

        /// <summary>
        /// Hàm load dữ liệu từ bảng Thuốc lên DataGridView
        /// </summary>
        private void LoadThuocTable()
        {
            // Mapping cột DataGridView với cột trong SQL
            maThuoc.DataPropertyName = "maThuoc";
            maLt.DataPropertyName = "maLt";
            maNcc.DataPropertyName = "maNcc";
            tenThuoc.DataPropertyName = "tenThuoc";
            hamLuong.DataPropertyName = "hamLuong";
            quyCachDongGoi.DataPropertyName = "quyCachDongGoi";
            hangSx.DataPropertyName = "hangSx";
            donViCoBan.DataPropertyName = "donViCoBan";
            soLuong.DataPropertyName = "soLuong";
            giaBan.DataPropertyName = "giaBan";
            moTa.DataPropertyName = "moTa";
            hinhAnh.DataPropertyName = "hinhAnh";
            hanSd.DataPropertyName = "hanSd";
            donViBan.DataPropertyName = "donViBan";
            giaTriQuyDoi.DataPropertyName = "giaTriQuyDoi";
            giaBanTheoDvBan.DataPropertyName = "giaBanTheoDvBan";
            soLuongTheoDvBan.DataPropertyName = "soluongtheodvban";

            var dtKQ = busThuoc.Get();
            dataGridView_Thuoc.DataSource = dtKQ;
        }

        /// <summary>
        /// Hàm load dữ liệu từ bảng Loại thuốc lên ComboBox
        /// </summary>
        private void LoadLoaiThuocComboBox()
        {
            var dtKQ = busLoaiThuoc.Get();
            comboBoxLoaiThuoc_Thuoc.DataSource = dtKQ;
            comboBoxLoaiThuoc_Thuoc.DisplayMember = "tenLt";
            comboBoxLoaiThuoc_Thuoc.ValueMember = "maLt";

            comboBoxLoaiThuoc_Thuoc.SelectedIndex = -1; // không chọn mục nào khi mới load
        }

        /// <summary>
        /// Hàm load dữ liệu từ bảng Nhà cung cấp lên ComboBox
        /// </summary>
        private void LoadNhaCungCapComboBox()
        {
            var dtKQ = busNhaCC.getNhaCC();
            comboBoxNcc_Thuoc.DataSource = dtKQ;
            comboBoxNcc_Thuoc.DisplayMember = "tenNcc";
            comboBoxNcc_Thuoc.ValueMember = "maNcc";
            comboBoxNcc_Thuoc.SelectedIndex = -1; // không chọn mục nào khi mới load
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Sự kiện khi click vào 1 dòng trong DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Thuoc_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView_Thuoc.SelectedRows[0];

            comboBoxLoaiThuoc_Thuoc.SelectedValue = Convert.ToInt32(dataGridViewRow.Cells["maLt"].Value.ToString());
            comboBoxNcc_Thuoc.SelectedValue = Convert.ToInt32(dataGridViewRow.Cells["maNcc"].Value.ToString());

            labelDangChon_Thuoc.Text = "Mã thuốc đang chọn: " + dataGridViewRow.Cells["maThuoc"].Value.ToString();

            textBoxTenThuoc_Thuoc.Text = dataGridViewRow.Cells["tenThuoc"].Value.ToString();
            textBoxHamLuong_Thuoc.Text = dataGridViewRow.Cells["hamLuong"].Value.ToString();
            textBoxQuyCachDongGoi_Thuoc.Text = dataGridViewRow.Cells["quyCachDongGoi"].Value.ToString();
            textBoxHangSanXuat_Thuoc.Text = dataGridViewRow.Cells["hangSx"].Value.ToString();
            textBoxDonViCoBan_Thuoc.Text = dataGridViewRow.Cells["donViCoBan"].Value.ToString();
            textBoxSoLuong_Thuoc.Text = dataGridViewRow.Cells["soLuong"].Value.ToString();
            textBoxGiaBan_Thuoc.Text = dataGridViewRow.Cells["giaBan"].Value.ToString();
            textBoxMoTa_Thuoc.Text = dataGridViewRow.Cells["moTa"].Value.ToString();
            dateTimeHanSuDung_Thuoc.Text = dataGridViewRow.Cells["hanSd"].Value.ToString();
            textBoxDonViBan_Thuoc.Text = dataGridViewRow.Cells["donViBan"].Value.ToString();
            textBoxGiaTriQuyDoi_Thuoc.Text = dataGridViewRow.Cells["giaTriQuyDoi"].Value.ToString();
            textBoxGiaBanTheoDonViBan_Thuoc.Text = dataGridViewRow.Cells["giaBanTheoDvBan"].Value.ToString();
            textBoxSoLuongTheoDvBan_Thuoc.Text = dataGridViewRow.Cells["soLuongTheoDvBan"].Value.ToString();

            // Hiển thị ảnh
            byte[] imgBytes = dataGridViewRow.Cells["hinhAnh"].Value as byte[];
            if (imgBytes != null)
            {
                // Convert byte[] -> Image
                Image img = ImageUntils.ByteArrayToImage(imgBytes);

                // Gán vào PictureBox
                pictureBoxThuoc_Thuoc.Image = img;
            }
            else
            {
                pictureBoxThuoc_Thuoc.Image = null;
            }

            // Xử lý kích hoạt/tắt các nút
            buttonUpdate_Thuoc.Visible = true;
            buttonDelete_Thuoc.Visible = true;
            buttonAdd_Thuoc.Visible = false;
            buttonBoChon_Thuoc.Enabled = true;
        }

        /// <summary>
        /// Sự kiện khi click nút Chọn hình ảnh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHinhAnh_Thuoc_Click(object sender, EventArgs e)
        {
            Image img = ImageUntils.SelectImageFromFile();
            var byteImage = ImageUntils.ImageToByteArray(img);
            pictureBoxThuoc_Thuoc.Image = img;
        }

        /// <summary>
        /// Sự kiện khi click nút Bỏ chọn thuốc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBoChon_Thuoc_Click(object sender, EventArgs e)
        {
            comboBoxLoaiThuoc_Thuoc.SelectedValue = -1;
            comboBoxNcc_Thuoc.SelectedValue = -1;

            labelDangChon_Thuoc.Text = "Mã thuốc đang chọn: ";

            textBoxTenThuoc_Thuoc.Text = "";
            textBoxHamLuong_Thuoc.Text = "";
            textBoxQuyCachDongGoi_Thuoc.Text = "";
            textBoxHangSanXuat_Thuoc.Text = "";
            textBoxDonViCoBan_Thuoc.Text = "";
            textBoxSoLuong_Thuoc.Text = "";
            textBoxGiaBan_Thuoc.Text = "";
            textBoxMoTa_Thuoc.Text = "";
            dateTimeHanSuDung_Thuoc.Text = "";
            textBoxDonViBan_Thuoc.Text = "";
            textBoxGiaTriQuyDoi_Thuoc.Text = "";
            textBoxGiaBanTheoDonViBan_Thuoc.Text = "";
            textBoxSoLuongTheoDvBan_Thuoc.Text = "";


            pictureBoxThuoc_Thuoc.Image = null;
            dataGridView_Thuoc.ClearSelection();

            // Xử lý kích hoạt/tắt các nút
            buttonUpdate_Thuoc.Visible = false;
            buttonDelete_Thuoc.Visible = false;
            buttonAdd_Thuoc.Visible = true;
            buttonBoChon_Thuoc.Enabled = false;
        }


        /// <summary>
        /// Sự kiện thêm một loại thuốc mới khi click nút Thêm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Thuoc_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (comboBoxLoaiThuoc_Thuoc.SelectedValue == null || comboBoxNcc_Thuoc.SelectedValue == null ||
                string.IsNullOrWhiteSpace(textBoxTenThuoc_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxHamLuong_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxQuyCachDongGoi_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxHangSanXuat_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxDonViCoBan_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxSoLuong_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxGiaBan_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(dateTimeHanSuDung_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxDonViBan_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxGiaTriQuyDoi_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxGiaBanTheoDonViBan_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxSoLuongTheoDvBan_Thuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maLt = Convert.ToInt32(comboBoxLoaiThuoc_Thuoc.SelectedValue);
                int maNcc = Convert.ToInt32(comboBoxNcc_Thuoc.SelectedValue);
                string tenThuoc = textBoxTenThuoc_Thuoc.Text.Trim();
                string hamLuong = textBoxHamLuong_Thuoc.Text.Trim();
                string quyCachDongGoi = textBoxQuyCachDongGoi_Thuoc.Text.Trim();
                string hangSx = textBoxHangSanXuat_Thuoc.Text.Trim();
                string donViCoBan = textBoxDonViCoBan_Thuoc.Text.Trim();
                int soLuong = int.Parse(textBoxSoLuong_Thuoc.Text.Trim());
                decimal giaBan = decimal.Parse(textBoxGiaBan_Thuoc.Text.Trim());
                string moTa = string.IsNullOrWhiteSpace(textBoxMoTa_Thuoc.Text) ? null : textBoxMoTa_Thuoc.Text.Trim();
                byte[] hinhAnh = ImageUntils.ImageToByteArray(pictureBoxThuoc_Thuoc.Image);
                DateTime hanSd = DateTime.Parse(dateTimeHanSuDung_Thuoc.Text.Trim());
                string donViBan = textBoxDonViBan_Thuoc.Text.Trim();
                int giaTriQuyDoi = int.Parse(textBoxGiaTriQuyDoi_Thuoc.Text.Trim());
                decimal giaBanTheoDvBan = decimal.Parse(textBoxGiaBanTheoDonViBan_Thuoc.Text.Trim());
                int soLuongTheoDvBan = int.Parse(textBoxSoLuongTheoDvBan_Thuoc.Text.Trim());

                DTO_Thuoc thuoc = new DTO_Thuoc(
                    0, // maThuoc tự tăng trong DB
                    maLt,
                    maNcc,
                    tenThuoc,
                    hamLuong,
                    quyCachDongGoi,
                    hangSx,
                    donViCoBan,
                    soLuong,
                    giaBan,
                    moTa,
                    hinhAnh,
                    hanSd,
                    donViBan,
                    giaTriQuyDoi,
                    giaBanTheoDvBan,
                    soLuongTheoDvBan
                );

                if (busThuoc.Insert(thuoc))
                {
                    MessageBox.Show("Thêm thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThuocTable();
                    buttonBoChon_Thuoc_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Thêm thuốc không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }


        /// <summary>
        /// Sự kiện cập nhật thông tin một loại thuốc khi click nút Cập nhật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Thuoc_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (comboBoxLoaiThuoc_Thuoc.SelectedValue == null || comboBoxNcc_Thuoc.SelectedValue == null ||
                string.IsNullOrWhiteSpace(textBoxTenThuoc_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxHamLuong_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxQuyCachDongGoi_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxHangSanXuat_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxDonViCoBan_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxSoLuong_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxGiaBan_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(dateTimeHanSuDung_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxDonViBan_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxGiaTriQuyDoi_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxGiaBanTheoDonViBan_Thuoc.Text) ||
                string.IsNullOrWhiteSpace(textBoxSoLuongTheoDvBan_Thuoc.Text) ||
                dataGridView_Thuoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int maThuoc = Convert.ToInt32(dataGridView_Thuoc.SelectedRows[0].Cells["maThuoc"].Value.ToString());
                int maLt = Convert.ToInt32(comboBoxLoaiThuoc_Thuoc.SelectedValue);
                int maNcc = Convert.ToInt32(comboBoxNcc_Thuoc.SelectedValue);
                string tenThuoc = textBoxTenThuoc_Thuoc.Text.Trim();
                string hamLuong = textBoxHamLuong_Thuoc.Text.Trim();
                string quyCachDongGoi = textBoxQuyCachDongGoi_Thuoc.Text.Trim();
                string hangSx = textBoxHangSanXuat_Thuoc.Text.Trim();
                string donViCoBan = textBoxDonViCoBan_Thuoc.Text.Trim();
                int soLuong = int.Parse(textBoxSoLuong_Thuoc.Text.Trim());
                decimal giaBan = decimal.Parse(textBoxGiaBan_Thuoc.Text.Trim());
                string moTa = string.IsNullOrWhiteSpace(textBoxMoTa_Thuoc.Text) ? null : textBoxMoTa_Thuoc.Text.Trim();
                byte[] hinhAnh = ImageUntils.ImageToByteArray(pictureBoxThuoc_Thuoc.Image);
                DateTime hanSd = DateTime.Parse(dateTimeHanSuDung_Thuoc.Text.Trim());
                string donViBan = textBoxDonViBan_Thuoc.Text.Trim();
                int giaTriQuyDoi = int.Parse(textBoxGiaTriQuyDoi_Thuoc.Text.Trim());
                decimal giaBanTheoDvBan = decimal.Parse(textBoxGiaBanTheoDonViBan_Thuoc.Text.Trim());
                int soLuongTheoDvBan = int.Parse(textBoxSoLuongTheoDvBan_Thuoc.Text.Trim());

                DTO_Thuoc thuoc = new DTO_Thuoc(
                    maThuoc,
                    maLt,
                    maNcc,
                    tenThuoc,
                    hamLuong,
                    quyCachDongGoi,
                    hangSx,
                    donViCoBan,
                    soLuong,
                    giaBan,
                    moTa,
                    hinhAnh,
                    hanSd,
                    donViBan,
                    giaTriQuyDoi,
                    giaBanTheoDvBan,
                    soLuongTheoDvBan
                );

                if (busThuoc.Update(thuoc))
                {
                    MessageBox.Show("Sửa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThuocTable();
                    buttonBoChon_Thuoc_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Sửa thuốc không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Sự kiện xóa một loại thuốc khi click nút Xóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Thuoc_Click(object sender, EventArgs e)
        {
            if (dataGridView_Thuoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maThuoc = Convert.ToInt32(dataGridView_Thuoc.SelectedRows[0].Cells["maThuoc"].Value.ToString());
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá thuốc này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (busThuoc.Delete(maThuoc))
                    {
                        MessageBox.Show("Xoá thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadThuocTable();
                        buttonBoChon_Thuoc_Click(null, null);
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


        /// <summary>
        /// Sự kiện tìm kiếm thuốc khi click nút Tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTimKiem_Thuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTimThuoc_Thuoc.Text))
            {
                LoadThuocTable();
                return;
            }

            var dtKQ = busThuoc.Get(textBoxTimThuoc_Thuoc.Text.Trim());
            dataGridView_Thuoc.DataSource = dtKQ;
        }

        /// <summary>
        /// Sự kiện hủy tìm kiếm khi click nút Hủy tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHuyTimKiem_Thuoc_Click(object sender, EventArgs e)
        {
            LoadThuocTable();
            textBoxTimThuoc_Thuoc.Text = "";
        }
    }
}
