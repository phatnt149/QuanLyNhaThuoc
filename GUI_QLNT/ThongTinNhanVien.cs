using BUS_QLNT;
using DTO_QLNT;
using GUI_QLNT.Untils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNT
{
    public partial class ThongTinNhanVien: Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public ThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.NhanVien WHERE userName = '" + DataUser.userName + "'";
            DataTable dt = new DataTable();
            dt = busNV.getNhanVien(query);

            txtUserName.Text = dt.Rows[0]["userName"].ToString();
            txtTenNV.Text = dt.Rows[0]["hoTen"].ToString();
            dateTimePickerNgaySinh.Text = dt.Rows[0]["ngaySinh"].ToString();
            cboGioiTinh.Text = dt.Rows[0]["gioiTinh"].ToString();
            txtDiaChi.Text = dt.Rows[0]["diaChi"].ToString();

            // Lấy byte[] từ cột ẩn
            byte[] imgBytes = dt.Rows[0]["hinhAnh"] as byte[];
            if (imgBytes != null)
            {
                // Convert byte[] -> Image
                Image img = ImageUntils.ByteArrayToImage(imgBytes);

                // Gán vào PictureBox
                picAnh.Image = img;
                picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                picAnh.Image = null;
            }
        }

        public static Image SelectImageFromFile()
        {
            OpenFileDialog open = new OpenFileDialog();  // Tạo hộp thoại chọn file
            open.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            // Chỉ cho phép chọn file ảnh .jpg, nhưng nếu muốn có thể chọn tất cả file
            open.FilterIndex = 1;  // Mặc định chọn bộ lọc đầu tiên (JPG)
            open.RestoreDirectory = true; // Sau khi đóng dialog thì thư mục hiện tại quay lại như ban đầu

            if (open.ShowDialog() == DialogResult.OK)   // Nếu người dùng bấm "OK"
            {
                return Image.FromFile(open.FileName);   // Trả về đối tượng Image từ file đã chọn
            }
            return null; // Nếu bấm Cancel thì không chọn → trả về null
        }
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            Image img = ImageUntils.SelectImageFromFile();
            var byteImage = ImageUntils.ImageToByteArray(img);
            picAnh.Image = img;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                string userName = txtUserName.Text;
                string hoTen = txtTenNV.Text;
                DateTime ngaySinh = dateTimePickerNgaySinh.Value;
                string gioiTinh = cboGioiTinh.Text;
                string diaChi = txtDiaChi.Text;
                byte[] hinhAnh = ImageUntils.ImageToByteArray(picAnh.Image);

                string query = "SELECT * FROM dbo.NhanVien WHERE userName = '" + DataUser.userName + "'";
                DataTable dt = new DataTable();
                dt = busNV.getNhanVien(query);

                string chucVu = dt.Rows[0]["chucVu"].ToString();

                // Tạo DTo
                DTO_NhanVien nv = new DTO_NhanVien(userName, "", hoTen, ngaySinh, gioiTinh, diaChi, hinhAnh, chucVu);
                if (busNV.suaNhanVien(nv,3))
                {
                    MessageBox.Show("Sửa thành công");
                    //this.LoadNhanVien();
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien_Load(sender, e);
        }
    }
}
