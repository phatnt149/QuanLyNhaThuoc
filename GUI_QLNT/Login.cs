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
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Tên Đăng Nhập Trống");
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Mật Khẩu Trống");
                }
                string username = txtUsername.Text;
                string password = busNV.maHoaMD5(txtPassword.Text);
                string query = "SELECT * FROM NhanVien WHERE Username='" + username + "' AND Password='" + password + "'";
                var dtKQ = busNV.getNhanVien(query);
                if (dtKQ.Rows.Count > 0)
                {
                    DataUser.userName = dtKQ.Rows[0]["username"].ToString();
                    DataUser.chucvu = dtKQ.Rows[0]["chucvu"].ToString();
                    main m = new main();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại");
                }
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
