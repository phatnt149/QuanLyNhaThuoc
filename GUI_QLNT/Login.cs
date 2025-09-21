using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DTO_QLNT;
using BUS_QLNT;

namespace GUI_QLNT
{
    public partial class login : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public login()
        {
            InitializeComponent();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = busNV.maHoaMD5(txtPassword.Text);

                if (username == "")
                {
                    MessageBox.Show("Tên Đăng Nhập Trống");
                    return;
                }
                else if (password == "")
                {
                    MessageBox.Show("Mật Khẩu Trống");
                    return;
                }

                DTO_NhanVien nv = busNV.DangNhap(username, password);


                // TODO: Lưu thông tin nhân viên đăng nhập
                main m = new main();
                m.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkShowpass_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkShowpass.Checked == true)
                {
                    txtPassword.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
