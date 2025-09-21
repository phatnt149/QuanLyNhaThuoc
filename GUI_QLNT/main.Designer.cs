using System.Windows.Forms;
using System.Drawing;

namespace GUI_QLNT
{
    partial class main
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl;
        private TabPage tabQuanLy;
        private TabPage tabBanHang;
        private TabPage tabTroGiup;

        private GroupBox groupNhanSu;
        private Button btnNhanVien;
        private Button btnNhaCungCap;

        private GroupBox groupDuocPham;
        private Button btnLoaiDP;
        private Button btnThuoc;
        private Button btnNhapThuoc;

        private GroupBox groupThongKe;
        private Button btnTKNhap;
        private Button btnTKBan;

        private GroupBox groupBanHang;
        private Button btnBanThuoc;
        private Button btnThongTinThuoc;

        private GroupBox groupMoRong;
        private Button btnTaiKhoan;
        private Button btnDangXuat;

        private GroupBox groupLienHe;
        private Button btnWeb;
        private Button btnFacebook;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabQuanLy = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupNhanSu = new System.Windows.Forms.GroupBox();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.groupDuocPham = new System.Windows.Forms.GroupBox();
            this.btnLoaiDP = new System.Windows.Forms.Button();
            this.btnThuoc = new System.Windows.Forms.Button();
            this.btnNhapThuoc = new System.Windows.Forms.Button();
            this.groupThongKe = new System.Windows.Forms.GroupBox();
            this.btnTKNhap = new System.Windows.Forms.Button();
            this.btnTKBan = new System.Windows.Forms.Button();
            this.tabBanHang = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBanHang = new System.Windows.Forms.GroupBox();
            this.btnBanThuoc = new System.Windows.Forms.Button();
            this.btnThongTinThuoc = new System.Windows.Forms.Button();
            this.groupMoRong = new System.Windows.Forms.GroupBox();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.tabTroGiup = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.groupLienHe = new System.Windows.Forms.GroupBox();
            this.btnWeb = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabQuanLy.SuspendLayout();
            this.groupNhanSu.SuspendLayout();
            this.groupDuocPham.SuspendLayout();
            this.groupThongKe.SuspendLayout();
            this.tabBanHang.SuspendLayout();
            this.groupBanHang.SuspendLayout();
            this.groupMoRong.SuspendLayout();
            this.tabTroGiup.SuspendLayout();
            this.groupLienHe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabQuanLy);
            this.tabControl.Controls.Add(this.tabBanHang);
            this.tabControl.Controls.Add(this.tabTroGiup);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(900, 536);
            this.tabControl.TabIndex = 0;
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Controls.Add(this.label1);
            this.tabQuanLy.Controls.Add(this.panelMain);
            this.tabQuanLy.Controls.Add(this.groupNhanSu);
            this.tabQuanLy.Controls.Add(this.groupDuocPham);
            this.tabQuanLy.Controls.Add(this.groupThongKe);
            this.tabQuanLy.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.Size = new System.Drawing.Size(892, 510);
            this.tabQuanLy.TabIndex = 0;
            this.tabQuanLy.Text = "Quản lý";
            this.tabQuanLy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(816, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Location = new System.Drawing.Point(20, 116);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(850, 386);
            this.panelMain.TabIndex = 3;
            // 
            // groupNhanSu
            // 
            this.groupNhanSu.Controls.Add(this.btnNhanVien);
            this.groupNhanSu.Controls.Add(this.btnNhaCungCap);
            this.groupNhanSu.Location = new System.Drawing.Point(10, 10);
            this.groupNhanSu.Name = "groupNhanSu";
            this.groupNhanSu.Size = new System.Drawing.Size(200, 100);
            this.groupNhanSu.TabIndex = 0;
            this.groupNhanSu.TabStop = false;
            this.groupNhanSu.Text = "Nhân sự";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(10, 20);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(90, 70);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân viên";
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Location = new System.Drawing.Point(100, 20);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(90, 70);
            this.btnNhaCungCap.TabIndex = 1;
            this.btnNhaCungCap.Text = "Nhà cung cấp";
            // 
            // groupDuocPham
            // 
            this.groupDuocPham.Controls.Add(this.btnLoaiDP);
            this.groupDuocPham.Controls.Add(this.btnThuoc);
            this.groupDuocPham.Controls.Add(this.btnNhapThuoc);
            this.groupDuocPham.Location = new System.Drawing.Point(220, 10);
            this.groupDuocPham.Name = "groupDuocPham";
            this.groupDuocPham.Size = new System.Drawing.Size(300, 100);
            this.groupDuocPham.TabIndex = 1;
            this.groupDuocPham.TabStop = false;
            this.groupDuocPham.Text = "Dược phẩm";
            // 
            // btnLoaiDP
            // 
            this.btnLoaiDP.Location = new System.Drawing.Point(10, 20);
            this.btnLoaiDP.Name = "btnLoaiDP";
            this.btnLoaiDP.Size = new System.Drawing.Size(90, 70);
            this.btnLoaiDP.TabIndex = 0;
            this.btnLoaiDP.Text = "Loại DP";
            // 
            // btnThuoc
            // 
            this.btnThuoc.Location = new System.Drawing.Point(100, 20);
            this.btnThuoc.Name = "btnThuoc";
            this.btnThuoc.Size = new System.Drawing.Size(90, 70);
            this.btnThuoc.TabIndex = 1;
            this.btnThuoc.Text = "Thuốc";
            // 
            // btnNhapThuoc
            // 
            this.btnNhapThuoc.Location = new System.Drawing.Point(190, 20);
            this.btnNhapThuoc.Name = "btnNhapThuoc";
            this.btnNhapThuoc.Size = new System.Drawing.Size(90, 70);
            this.btnNhapThuoc.TabIndex = 2;
            this.btnNhapThuoc.Text = "Nhập thuốc";
            // 
            // groupThongKe
            // 
            this.groupThongKe.Controls.Add(this.btnTKNhap);
            this.groupThongKe.Controls.Add(this.btnTKBan);
            this.groupThongKe.Location = new System.Drawing.Point(530, 10);
            this.groupThongKe.Name = "groupThongKe";
            this.groupThongKe.Size = new System.Drawing.Size(200, 100);
            this.groupThongKe.TabIndex = 2;
            this.groupThongKe.TabStop = false;
            this.groupThongKe.Text = "Thống kê";
            // 
            // btnTKNhap
            // 
            this.btnTKNhap.Location = new System.Drawing.Point(10, 20);
            this.btnTKNhap.Name = "btnTKNhap";
            this.btnTKNhap.Size = new System.Drawing.Size(90, 70);
            this.btnTKNhap.TabIndex = 0;
            this.btnTKNhap.Text = "TK Nhập";
            // 
            // btnTKBan
            // 
            this.btnTKBan.Location = new System.Drawing.Point(100, 20);
            this.btnTKBan.Name = "btnTKBan";
            this.btnTKBan.Size = new System.Drawing.Size(90, 70);
            this.btnTKBan.TabIndex = 1;
            this.btnTKBan.Text = "TK Bán";
            // 
            // tabBanHang
            // 
            this.tabBanHang.Controls.Add(this.groupBox1);
            this.tabBanHang.Controls.Add(this.label2);
            this.tabBanHang.Controls.Add(this.username);
            this.tabBanHang.Controls.Add(this.panel1);
            this.tabBanHang.Controls.Add(this.groupBanHang);
            this.tabBanHang.Controls.Add(this.groupMoRong);
            this.tabBanHang.Location = new System.Drawing.Point(4, 22);
            this.tabBanHang.Name = "tabBanHang";
            this.tabBanHang.Size = new System.Drawing.Size(892, 510);
            this.tabBanHang.TabIndex = 1;
            this.tabBanHang.Text = "Bán hàng";
            this.tabBanHang.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(816, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(775, 5);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 29);
            this.username.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(20, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 386);
            this.panel1.TabIndex = 4;
            // 
            // groupBanHang
            // 
            this.groupBanHang.Controls.Add(this.btnBanThuoc);
            this.groupBanHang.Controls.Add(this.btnThongTinThuoc);
            this.groupBanHang.Location = new System.Drawing.Point(10, 10);
            this.groupBanHang.Name = "groupBanHang";
            this.groupBanHang.Size = new System.Drawing.Size(200, 100);
            this.groupBanHang.TabIndex = 0;
            this.groupBanHang.TabStop = false;
            this.groupBanHang.Text = "Bán hàng";
            // 
            // btnBanThuoc
            // 
            this.btnBanThuoc.Location = new System.Drawing.Point(10, 20);
            this.btnBanThuoc.Name = "btnBanThuoc";
            this.btnBanThuoc.Size = new System.Drawing.Size(90, 70);
            this.btnBanThuoc.TabIndex = 0;
            this.btnBanThuoc.Text = "Bán thuốc";
            // 
            // btnThongTinThuoc
            // 
            this.btnThongTinThuoc.Location = new System.Drawing.Point(100, 20);
            this.btnThongTinThuoc.Name = "btnThongTinThuoc";
            this.btnThongTinThuoc.Size = new System.Drawing.Size(90, 70);
            this.btnThongTinThuoc.TabIndex = 1;
            this.btnThongTinThuoc.Text = "Thông tin thuốc";
            // 
            // groupMoRong
            // 
            this.groupMoRong.Controls.Add(this.btnTaiKhoan);
            this.groupMoRong.Controls.Add(this.btnDangXuat);
            this.groupMoRong.Location = new System.Drawing.Point(220, 10);
            this.groupMoRong.Name = "groupMoRong";
            this.groupMoRong.Size = new System.Drawing.Size(200, 100);
            this.groupMoRong.TabIndex = 1;
            this.groupMoRong.TabStop = false;
            this.groupMoRong.Text = "Mở rộng";
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Location = new System.Drawing.Point(10, 20);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(90, 70);
            this.btnTaiKhoan.TabIndex = 0;
            this.btnTaiKhoan.Text = "Tài khoản";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(100, 20);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(90, 70);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            // 
            // tabTroGiup
            // 
            this.tabTroGiup.Controls.Add(this.label3);
            this.tabTroGiup.Controls.Add(this.groupLienHe);
            this.tabTroGiup.Location = new System.Drawing.Point(4, 22);
            this.tabTroGiup.Name = "tabTroGiup";
            this.tabTroGiup.Size = new System.Drawing.Size(892, 510);
            this.tabTroGiup.TabIndex = 2;
            this.tabTroGiup.Text = "Liên hệ";
            this.tabTroGiup.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(816, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupLienHe
            // 
            this.groupLienHe.Controls.Add(this.btnWeb);
            this.groupLienHe.Controls.Add(this.btnFacebook);
            this.groupLienHe.Location = new System.Drawing.Point(10, 10);
            this.groupLienHe.Name = "groupLienHe";
            this.groupLienHe.Size = new System.Drawing.Size(200, 100);
            this.groupLienHe.TabIndex = 0;
            this.groupLienHe.TabStop = false;
            this.groupLienHe.Text = "Liên hệ";
            // 
            // btnWeb
            // 
            this.btnWeb.Location = new System.Drawing.Point(10, 20);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(90, 70);
            this.btnWeb.TabIndex = 0;
            this.btnWeb.Text = "Web";
            // 
            // btnFacebook
            // 
            this.btnFacebook.Location = new System.Drawing.Point(100, 20);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(90, 70);
            this.btnFacebook.TabIndex = 1;
            this.btnFacebook.Text = "Facebook";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(426, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công cụ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Word";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "Máy tính";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // main
            // 
            this.ClientSize = new System.Drawing.Size(900, 536);
            this.Controls.Add(this.tabControl);
            this.Name = "main";
            this.Text = "Phần mềm Quản lý Nhà thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MaximumSizeChanged += new System.EventHandler(this.main_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabQuanLy.ResumeLayout(false);
            this.tabQuanLy.PerformLayout();
            this.groupNhanSu.ResumeLayout(false);
            this.groupDuocPham.ResumeLayout(false);
            this.groupThongKe.ResumeLayout(false);
            this.tabBanHang.ResumeLayout(false);
            this.tabBanHang.PerformLayout();
            this.groupBanHang.ResumeLayout(false);
            this.groupMoRong.ResumeLayout(false);
            this.tabTroGiup.ResumeLayout(false);
            this.tabTroGiup.PerformLayout();
            this.groupLienHe.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel panelMain;
        private Panel panel1;
        private Label username;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
    }
}
