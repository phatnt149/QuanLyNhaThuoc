namespace GUI_QLNV
{
    partial class NhanVienDetail
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(21, 39);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(21, 117);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(47, 13);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Tên NV:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(21, 143);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(50, 13);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(21, 170);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(21, 196);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(50, 13);
            this.lblChucVu.TabIndex = 8;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(372, 29);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(79, 13);
            this.lblAnh.TabIndex = 10;
            this.lblAnh.Text = "Ảnh nhân viên:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(141, 36);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(141, 114);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(200, 20);
            this.txtTenNV.TabIndex = 4;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(141, 140);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(200, 21);
            this.cboGioiTinh.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(141, 167);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(141, 193);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(200, 20);
            this.txtChucVu.TabIndex = 7;
            // 
            // picAnh
            // 
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(372, 59);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(150, 150);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 11;
            this.picAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(372, 219);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(150, 30);
            this.btnChonAnh.TabIndex = 10;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(131, 220);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(241, 220);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 30);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(141, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(21, 65);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(21, 91);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(59, 13);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(141, 88);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgaySinh.TabIndex = 3;
            // 
            // NhanVienDetail
            // 
            this.ClientSize = new System.Drawing.Size(606, 724);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Name = "NhanVienDetail";
            this.Text = "Chi tiết nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.NhanVienDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblAnh;

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtChucVu;

        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
    }
}
