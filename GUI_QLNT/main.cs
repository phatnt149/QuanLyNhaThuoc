using GUI_QLNT;
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

            username.Visible = false;
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
        private void OpenChildForm2(Form childForm)
        {
            // Xóa control cũ trong panel (nếu có)
            panel1.Controls.Clear();

            childForm.TopLevel = false;   // ⬅️ quan trọng
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel1.Controls.Add(childForm);
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
            MessageBox.Show("Quản lý thuốc");
        }

        private void BtnNhapThuoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập thuốc");
        }

        private void BtnTKNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeNhap());
        }

        private void BtnTKBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeBan());
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
            OpenChildForm2(new ThongTinNhanVien());
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn đăng xuất không?",
            "Xác nhận đăng xuất",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                // Ẩn form hiện tại
                this.Hide();

                // Quay lại màn hình đăng nhập
                login lg = new login();
                lg.ShowDialog();

                // Đóng form sau khi logout
                this.Close();
            }
            ;
        }

        private void BtnWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ou.edu.vn/");
        }

        private void BtnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100066781932277");
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trợ giúp");
        }

        private void main_MaximumSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void main_Load(object sender, EventArgs e)
        {
            label1.Text = DataUser.userName;
            label2.Text = DataUser.userName;
            label3.Text = DataUser.userName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo st = new System.Diagnostics.ProcessStartInfo();
            st.FileName = "WINWORD.EXE";
            System.Diagnostics.Process.Start(st);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe");
        }
    }
}
