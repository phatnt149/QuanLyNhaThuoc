using System;
using System.Windows.Forms;

namespace GUI_QLNT
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            // Gán sự kiện cho các nút
            btnNhanVien.Click += BtnNhanVien_Click;
            btnNhaCungCap.Click += BtnNhaCungCap_Click;
            btnLoaiDP.Click += BtnLoaiDP_Click;
            btnThuoc.Click += BtnThuoc_Click;
            btnNhapThuoc.Click += BtnNhapThuoc_Click;
            btnTKNhap.Click += BtnTKNhap_Click;
            btnTKBan.Click += BtnTKBan_Click;
            btnBanThuoc.Click += BtnBanThuoc_Click;
            btnThongTinThuoc.Click += BtnThongTinThuoc_Click;
            btnTaiKhoan.Click += BtnTaiKhoan_Click;
            btnDangXuat.Click += BtnDangXuat_Click;
            btnWeb.Click += BtnWeb_Click;
            btnFacebook.Click += BtnFacebook_Click;
            btnHelp.Click += BtnHelp_Click;
        }

        private void OpenChildForm(Form childForm)
        {
            // Xóa control cũ trong panel (nếu có)
            panelMain.Controls.Clear();

            childForm.TopLevel = false;   // ⬅️ quan trọng
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(childForm);
            childForm.Show();

        }

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
        }

        private void BtnNhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NCC());
        }

        private void BtnLoaiDP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quản lý loại dược phẩm");
        }

        private void BtnThuoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Thuoc());
            
        }

        private void BtnNhapThuoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập thuốc");
        }

        private void BtnTKNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thống kê nhập hàng");
        }

        private void BtnTKBan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thống kê bán hàng");
        }

        private void BtnBanThuoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bán thuốc");
        }

        private void BtnThongTinThuoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thông tin thuốc");
        }

        private void BtnTaiKhoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quản lý tài khoản");
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất");
        }

        private void BtnWeb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở website");
        }

        private void BtnFacebook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở Facebook");
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trợ giúp");
        }

        private void main_MaximumSizeChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
