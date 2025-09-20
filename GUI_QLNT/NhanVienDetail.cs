using System;
using System.Windows.Forms;
using System.Xml.Linq;
using DTO_QLNT;
using BUS_QLNT;
using GUI_QLNT;

namespace GUI_QLNV
{
    public partial class NhanVienDetail : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        private NhanVien frmParent;
        public NhanVienDetail(NhanVien frm)
        {
            InitializeComponent();
            frmParent = frm;
        }
        public NhanVienDetail()
        {
            InitializeComponent();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh nhân viên";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAnh.Image = System.Drawing.Image.FromFile(ofd.FileName);
                }
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                // Tạo DTo
                DTO_NhanVien nv = new DTO_NhanVien(); 
                if (busNV.themNhanVien(nv))
                {
                    //frmParent.LoadNhanVien();
                    MessageBox.Show("Thêm thành công");
                    this.Close();
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

        private void NhanVienDetail_Load(object sender, EventArgs e)
        {
            
        }
    }
}
