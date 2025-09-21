using BUS_QLNT;
using GUI_QLNV;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using GUI_QLNT.Untils;
using DTO_QLNT;

namespace GUI_QLNT
{
    public partial class NhanVien : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            grd_qlnv.AutoGenerateColumns = false;
            txtTimKiem.Text = "Nhập username...";
            txtTimKiem.ForeColor = Color.Gray;

            // Mapping cột DataGridView với cột trong SQL
            colUsername.DataPropertyName = "userName";
            colHoTen.DataPropertyName = "hoTen";
            colNgaySinh.DataPropertyName = "ngaySinh";
            colGioiTinh.DataPropertyName = "gioiTinh";
            colDiaChi.DataPropertyName = "diaChi";
            colChucVu.DataPropertyName = "chucVu";
            colHinhAnh.DataPropertyName = "hinhAnh";


            var dtKQ = busNV.getNhanVien();
            grd_qlnv.DataSource = dtKQ;
        }

        public void LoadNhanVien()
        {
            grd_qlnv.DataSource = busNV.getNhanVien();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {



            NhanVienDetail frmNvDetail = new NhanVienDetail();
            frmNvDetail.TopMost = true; // luôn trên cùng
            frmNvDetail.StartPosition = FormStartPosition.CenterScreen;
            frmNvDetail.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void grd_qlnv_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grd_qlnv.SelectedRows[0];
            // Chuyển giá trị lên form
            txtUserName.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            comboBoxGioiTinh.Text = row.Cells[3].Value.ToString();
            dateTimePicker1.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[4].Value.ToString();
            txtChucVu.Text = row.Cells[5].Value.ToString();

            // Lấy byte[] từ cột ẩn
            byte[] imgBytes = row.Cells["colHinhAnh"].Value as byte[];
            if (imgBytes != null)
            {
                // Convert byte[] -> Image
                Image img = ImageUntils.ByteArrayToImage(imgBytes);

                // Gán vào PictureBox
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            Image img = ImageUntils.SelectImageFromFile();
            var byteImage = ImageUntils.ImageToByteArray(img);
            pictureBox1.Image = img;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text != "" && txtPass.Text != "")
            {
                string userName = txtUserName.Text;
                string passWord = busNV.maHoaMD5(txtPass.Text);
                string hoTen = txtHoTen.Text;
                DateTime ngaySinh = dateTimePicker1.Value;
                string gioiTinh = comboBoxGioiTinh.Text;
                string diaChi = txtDiaChi.Text;
                byte[] hinhAnh = ImageUntils.ImageToByteArray(pictureBox1.Image);
                string chucVu = txtChucVu.Text;
                // Tạo DTo
                DTO_NhanVien nv = new DTO_NhanVien(userName, passWord, hoTen, ngaySinh, gioiTinh, diaChi, hinhAnh, chucVu);
                if (busNV.themNhanVien(nv))
                {
                    MessageBox.Show("Thêm thành công");
                    this.LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPass.Text != "")
            {
                string userName = txtUserName.Text;
                string passWord = busNV.maHoaMD5(txtPass.Text);
                string hoTen = txtHoTen.Text;
                DateTime ngaySinh = dateTimePicker1.Value;
                string gioiTinh = comboBoxGioiTinh.Text;
                string diaChi = txtDiaChi.Text;
                byte[] hinhAnh = ImageUntils.ImageToByteArray(pictureBox1.Image);
                string chucVu = txtChucVu.Text;
                // Tạo DTo
                DTO_NhanVien nv = new DTO_NhanVien(userName, passWord, hoTen, ngaySinh, gioiTinh, diaChi, hinhAnh, chucVu);
                if (busNV.suaNhanVien(nv))
                {
                    MessageBox.Show("Sửa thành công");
                    this.LoadNhanVien();
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
            if (grd_qlnv.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
          "Bạn có chắc chắn muốn xóa dữ liệu này không?",
          "Xác nhận xóa",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning
                                 );

                if (result == DialogResult.Yes)
                {
                    if (busNV.xoaNhanVien(txtUserName.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        grd_qlnv.DataSource = busNV.getNhanVien(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grd_qlnv.DataSource = busNV.timNhanVienTheoUserName(txtTimKiem.Text);
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                grd_qlnv.DataSource = busNV.getNhanVien();
                txtTimKiem.Text = "Nhập username...";
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            grd_qlnv.DataSource = busNV.getNhanVien();
            txtUserName.Text = "";
            txtHoTen.Text = "";
            comboBoxGioiTinh.Text = "";
            dateTimePicker1.Text = "";
            txtDiaChi.Text = "";
            txtChucVu.Text = "";
            pictureBox1.Image = null;
            txtTimKiem.Text = "";
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


