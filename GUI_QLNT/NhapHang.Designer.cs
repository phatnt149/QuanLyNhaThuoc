namespace GUI_QLNT
{
    partial class NhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDangChon_NhapHang = new System.Windows.Forms.Label();
            this.buttonBoChon_NhapHang = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelWindow = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_DonHang = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNhanVienNhapHang_NhapHang = new System.Windows.Forms.Label();
            this.labelMaThuoc_NhapHang = new System.Windows.Forms.Label();
            this.labelDonViNhap_NhapHang = new System.Windows.Forms.Label();
            this.labelGiaTriQuyDoi_NhapHang = new System.Windows.Forms.Label();
            this.labelSoLuongNhap_NhapHang = new System.Windows.Forms.Label();
            this.labelMoTa_NhapHang = new System.Windows.Forms.Label();
            this.labelGiaNhap_NhapHang = new System.Windows.Forms.Label();
            this.labelNgayNhap_NhapHang = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxDonViNhap_NhapHang = new System.Windows.Forms.TextBox();
            this.comboBoxNhanVien_NhapHang = new System.Windows.Forms.ComboBox();
            this.dateTimeNgayNhap_NhapHang = new System.Windows.Forms.DateTimePicker();
            this.comboBoxThuoc_NhapHang = new System.Windows.Forms.ComboBox();
            this.textBoxGiaTriQuyDoi_NhapHang = new System.Windows.Forms.TextBox();
            this.textBoxSoLuongNhap_NhapHang = new System.Windows.Forms.TextBox();
            this.textBoxMoTa_NhapHang = new System.Windows.Forms.TextBox();
            this.textBoxGiapNhap_NhapHang = new System.Windows.Forms.TextBox();
            this.textBoxThanhTien_NhapHang = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonThem_NhapHang = new System.Windows.Forms.Button();
            this.buttonSua_NhapHang = new System.Windows.Forms.Button();
            this.buttonXoa_NhapHang = new System.Windows.Forms.Button();
            this.maNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTriQuyDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DonHang)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDangChon_NhapHang
            // 
            this.labelDangChon_NhapHang.AutoSize = true;
            this.labelDangChon_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDangChon_NhapHang.Location = new System.Drawing.Point(3, 0);
            this.labelDangChon_NhapHang.Name = "labelDangChon_NhapHang";
            this.labelDangChon_NhapHang.Size = new System.Drawing.Size(169, 34);
            this.labelDangChon_NhapHang.TabIndex = 0;
            this.labelDangChon_NhapHang.Text = "Mã đơn hàng đang chọn:";
            this.labelDangChon_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonBoChon_NhapHang
            // 
            this.buttonBoChon_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBoChon_NhapHang.Enabled = false;
            this.buttonBoChon_NhapHang.Location = new System.Drawing.Point(178, 3);
            this.buttonBoChon_NhapHang.Name = "buttonBoChon_NhapHang";
            this.buttonBoChon_NhapHang.Size = new System.Drawing.Size(81, 28);
            this.buttonBoChon_NhapHang.TabIndex = 1;
            this.buttonBoChon_NhapHang.Text = "Bỏ chọn";
            this.buttonBoChon_NhapHang.UseVisualStyleBackColor = true;
            this.buttonBoChon_NhapHang.Click += new System.EventHandler(this.buttonBoChon_NhapHang_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.labelDangChon_NhapHang, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonBoChon_NhapHang, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 34);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 850F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 34);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanelWindow
            // 
            this.tableLayoutPanelWindow.ColumnCount = 1;
            this.tableLayoutPanelWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWindow.Controls.Add(this.dataGridView_DonHang, 0, 1);
            this.tableLayoutPanelWindow.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelWindow.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWindow.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelWindow.Name = "tableLayoutPanelWindow";
            this.tableLayoutPanelWindow.RowCount = 3;
            this.tableLayoutPanelWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanelWindow.Size = new System.Drawing.Size(890, 572);
            this.tableLayoutPanelWindow.TabIndex = 1;
            // 
            // dataGridView_DonHang
            // 
            this.dataGridView_DonHang.AllowUserToAddRows = false;
            this.dataGridView_DonHang.AllowUserToDeleteRows = false;
            this.dataGridView_DonHang.AllowUserToResizeColumns = false;
            this.dataGridView_DonHang.AllowUserToResizeRows = false;
            this.dataGridView_DonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhapHang,
            this.maThuoc,
            this.donViNhap,
            this.giaTriQuyDoi,
            this.soLuongNhap,
            this.giaNhap,
            this.moTa,
            this.ngayNhap,
            this.thanhTien,
            this.userName});
            this.dataGridView_DonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_DonHang.Location = new System.Drawing.Point(3, 43);
            this.dataGridView_DonHang.Name = "dataGridView_DonHang";
            this.dataGridView_DonHang.ReadOnly = true;
            this.dataGridView_DonHang.RowHeadersVisible = false;
            this.dataGridView_DonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DonHang.Size = new System.Drawing.Size(884, 366);
            this.dataGridView_DonHang.TabIndex = 0;
            this.dataGridView_DonHang.Click += new System.EventHandler(this.dataGridView_DonHang_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 415);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(884, 154);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.55556F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.44444F));
            this.tableLayoutPanel4.Controls.Add(this.textBoxSoLuongNhap_NhapHang, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.textBoxGiaTriQuyDoi_NhapHang, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxThuoc_NhapHang, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelSoLuongNhap_NhapHang, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.labelGiaTriQuyDoi_NhapHang, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.labelDonViNhap_NhapHang, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelMaThuoc_NhapHang, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelNhanVienNhapHang_NhapHang, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxDonViNhap_NhapHang, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxNhanVien_NhapHang, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(288, 148);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.55556F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.44444F));
            this.tableLayoutPanel5.Controls.Add(this.textBoxThanhTien_NhapHang, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.textBoxGiapNhap_NhapHang, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBoxMoTa_NhapHang, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.labelNgayNhap_NhapHang, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.labelGiaNhap_NhapHang, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelMoTa_NhapHang, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dateTimeNgayNhap_NhapHang, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(297, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(288, 148);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // labelNhanVienNhapHang_NhapHang
            // 
            this.labelNhanVienNhapHang_NhapHang.AutoSize = true;
            this.labelNhanVienNhapHang_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNhanVienNhapHang_NhapHang.Location = new System.Drawing.Point(3, 0);
            this.labelNhanVienNhapHang_NhapHang.Name = "labelNhanVienNhapHang_NhapHang";
            this.labelNhanVienNhapHang_NhapHang.Size = new System.Drawing.Size(82, 29);
            this.labelNhanVienNhapHang_NhapHang.TabIndex = 0;
            this.labelNhanVienNhapHang_NhapHang.Text = "Nhân viên nhập hàng";
            this.labelNhanVienNhapHang_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMaThuoc_NhapHang
            // 
            this.labelMaThuoc_NhapHang.AutoSize = true;
            this.labelMaThuoc_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaThuoc_NhapHang.Location = new System.Drawing.Point(3, 29);
            this.labelMaThuoc_NhapHang.Name = "labelMaThuoc_NhapHang";
            this.labelMaThuoc_NhapHang.Size = new System.Drawing.Size(82, 29);
            this.labelMaThuoc_NhapHang.TabIndex = 2;
            this.labelMaThuoc_NhapHang.Text = "Thuốc";
            this.labelMaThuoc_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDonViNhap_NhapHang
            // 
            this.labelDonViNhap_NhapHang.AutoSize = true;
            this.labelDonViNhap_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDonViNhap_NhapHang.Location = new System.Drawing.Point(3, 58);
            this.labelDonViNhap_NhapHang.Name = "labelDonViNhap_NhapHang";
            this.labelDonViNhap_NhapHang.Size = new System.Drawing.Size(82, 29);
            this.labelDonViNhap_NhapHang.TabIndex = 4;
            this.labelDonViNhap_NhapHang.Text = "Đơn vị nhập";
            this.labelDonViNhap_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGiaTriQuyDoi_NhapHang
            // 
            this.labelGiaTriQuyDoi_NhapHang.AutoSize = true;
            this.labelGiaTriQuyDoi_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGiaTriQuyDoi_NhapHang.Location = new System.Drawing.Point(3, 87);
            this.labelGiaTriQuyDoi_NhapHang.Name = "labelGiaTriQuyDoi_NhapHang";
            this.labelGiaTriQuyDoi_NhapHang.Size = new System.Drawing.Size(82, 29);
            this.labelGiaTriQuyDoi_NhapHang.TabIndex = 6;
            this.labelGiaTriQuyDoi_NhapHang.Text = "Giá trị quy đổi";
            this.labelGiaTriQuyDoi_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSoLuongNhap_NhapHang
            // 
            this.labelSoLuongNhap_NhapHang.AutoSize = true;
            this.labelSoLuongNhap_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSoLuongNhap_NhapHang.Location = new System.Drawing.Point(3, 116);
            this.labelSoLuongNhap_NhapHang.Name = "labelSoLuongNhap_NhapHang";
            this.labelSoLuongNhap_NhapHang.Size = new System.Drawing.Size(82, 32);
            this.labelSoLuongNhap_NhapHang.TabIndex = 8;
            this.labelSoLuongNhap_NhapHang.Text = "Số lượng nhập";
            this.labelSoLuongNhap_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMoTa_NhapHang
            // 
            this.labelMoTa_NhapHang.AutoSize = true;
            this.labelMoTa_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMoTa_NhapHang.Location = new System.Drawing.Point(3, 0);
            this.labelMoTa_NhapHang.Name = "labelMoTa_NhapHang";
            this.labelMoTa_NhapHang.Size = new System.Drawing.Size(82, 29);
            this.labelMoTa_NhapHang.TabIndex = 1;
            this.labelMoTa_NhapHang.Text = "Mô tả";
            this.labelMoTa_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGiaNhap_NhapHang
            // 
            this.labelGiaNhap_NhapHang.AutoSize = true;
            this.labelGiaNhap_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGiaNhap_NhapHang.Location = new System.Drawing.Point(3, 29);
            this.labelGiaNhap_NhapHang.Name = "labelGiaNhap_NhapHang";
            this.labelGiaNhap_NhapHang.Size = new System.Drawing.Size(82, 29);
            this.labelGiaNhap_NhapHang.TabIndex = 3;
            this.labelGiaNhap_NhapHang.Text = "Giá nhập";
            this.labelGiaNhap_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNgayNhap_NhapHang
            // 
            this.labelNgayNhap_NhapHang.AutoSize = true;
            this.labelNgayNhap_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNgayNhap_NhapHang.Location = new System.Drawing.Point(3, 58);
            this.labelNgayNhap_NhapHang.Name = "labelNgayNhap_NhapHang";
            this.labelNgayNhap_NhapHang.Size = new System.Drawing.Size(82, 29);
            this.labelNgayNhap_NhapHang.TabIndex = 5;
            this.labelNgayNhap_NhapHang.Text = "Ngày Nhập";
            this.labelNgayNhap_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 29);
            this.label17.TabIndex = 7;
            this.label17.Text = "Thành tiền";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDonViNhap_NhapHang
            // 
            this.textBoxDonViNhap_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDonViNhap_NhapHang.Location = new System.Drawing.Point(91, 61);
            this.textBoxDonViNhap_NhapHang.Name = "textBoxDonViNhap_NhapHang";
            this.textBoxDonViNhap_NhapHang.Size = new System.Drawing.Size(194, 20);
            this.textBoxDonViNhap_NhapHang.TabIndex = 9;
            // 
            // comboBoxNhanVien_NhapHang
            // 
            this.comboBoxNhanVien_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxNhanVien_NhapHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNhanVien_NhapHang.FormattingEnabled = true;
            this.comboBoxNhanVien_NhapHang.Location = new System.Drawing.Point(91, 3);
            this.comboBoxNhanVien_NhapHang.Name = "comboBoxNhanVien_NhapHang";
            this.comboBoxNhanVien_NhapHang.Size = new System.Drawing.Size(194, 21);
            this.comboBoxNhanVien_NhapHang.TabIndex = 10;
            // 
            // dateTimeNgayNhap_NhapHang
            // 
            this.dateTimeNgayNhap_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeNgayNhap_NhapHang.Location = new System.Drawing.Point(91, 61);
            this.dateTimeNgayNhap_NhapHang.Name = "dateTimeNgayNhap_NhapHang";
            this.dateTimeNgayNhap_NhapHang.Size = new System.Drawing.Size(194, 20);
            this.dateTimeNgayNhap_NhapHang.TabIndex = 8;
            this.dateTimeNgayNhap_NhapHang.Value = new System.DateTime(2025, 9, 21, 21, 0, 32, 0);
            // 
            // comboBoxThuoc_NhapHang
            // 
            this.comboBoxThuoc_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxThuoc_NhapHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThuoc_NhapHang.FormattingEnabled = true;
            this.comboBoxThuoc_NhapHang.Location = new System.Drawing.Point(91, 32);
            this.comboBoxThuoc_NhapHang.Name = "comboBoxThuoc_NhapHang";
            this.comboBoxThuoc_NhapHang.Size = new System.Drawing.Size(194, 21);
            this.comboBoxThuoc_NhapHang.TabIndex = 11;
            // 
            // textBoxGiaTriQuyDoi_NhapHang
            // 
            this.textBoxGiaTriQuyDoi_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGiaTriQuyDoi_NhapHang.Location = new System.Drawing.Point(91, 90);
            this.textBoxGiaTriQuyDoi_NhapHang.Name = "textBoxGiaTriQuyDoi_NhapHang";
            this.textBoxGiaTriQuyDoi_NhapHang.Size = new System.Drawing.Size(194, 20);
            this.textBoxGiaTriQuyDoi_NhapHang.TabIndex = 12;
            // 
            // textBoxSoLuongNhap_NhapHang
            // 
            this.textBoxSoLuongNhap_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSoLuongNhap_NhapHang.Location = new System.Drawing.Point(91, 119);
            this.textBoxSoLuongNhap_NhapHang.Name = "textBoxSoLuongNhap_NhapHang";
            this.textBoxSoLuongNhap_NhapHang.Size = new System.Drawing.Size(194, 20);
            this.textBoxSoLuongNhap_NhapHang.TabIndex = 13;
            // 
            // textBoxMoTa_NhapHang
            // 
            this.textBoxMoTa_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMoTa_NhapHang.Location = new System.Drawing.Point(91, 3);
            this.textBoxMoTa_NhapHang.Name = "textBoxMoTa_NhapHang";
            this.textBoxMoTa_NhapHang.Size = new System.Drawing.Size(194, 20);
            this.textBoxMoTa_NhapHang.TabIndex = 10;
            // 
            // textBoxGiapNhap_NhapHang
            // 
            this.textBoxGiapNhap_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGiapNhap_NhapHang.Location = new System.Drawing.Point(91, 32);
            this.textBoxGiapNhap_NhapHang.Name = "textBoxGiapNhap_NhapHang";
            this.textBoxGiapNhap_NhapHang.Size = new System.Drawing.Size(194, 20);
            this.textBoxGiapNhap_NhapHang.TabIndex = 11;
            // 
            // textBoxThanhTien_NhapHang
            // 
            this.textBoxThanhTien_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxThanhTien_NhapHang.Enabled = false;
            this.textBoxThanhTien_NhapHang.Location = new System.Drawing.Point(91, 90);
            this.textBoxThanhTien_NhapHang.Name = "textBoxThanhTien_NhapHang";
            this.textBoxThanhTien_NhapHang.Size = new System.Drawing.Size(194, 20);
            this.textBoxThanhTien_NhapHang.TabIndex = 12;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.buttonXoa_NhapHang, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonSua_NhapHang, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonThem_NhapHang, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(591, 119);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(290, 32);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // buttonThem_NhapHang
            // 
            this.buttonThem_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonThem_NhapHang.Location = new System.Drawing.Point(3, 3);
            this.buttonThem_NhapHang.Name = "buttonThem_NhapHang";
            this.buttonThem_NhapHang.Size = new System.Drawing.Size(90, 26);
            this.buttonThem_NhapHang.TabIndex = 0;
            this.buttonThem_NhapHang.Text = "Thêm";
            this.buttonThem_NhapHang.UseVisualStyleBackColor = true;
            this.buttonThem_NhapHang.Click += new System.EventHandler(this.buttonThem_NhapHang_Click);
            // 
            // buttonSua_NhapHang
            // 
            this.buttonSua_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSua_NhapHang.Location = new System.Drawing.Point(99, 3);
            this.buttonSua_NhapHang.Name = "buttonSua_NhapHang";
            this.buttonSua_NhapHang.Size = new System.Drawing.Size(90, 26);
            this.buttonSua_NhapHang.TabIndex = 1;
            this.buttonSua_NhapHang.Text = "Sửa";
            this.buttonSua_NhapHang.UseVisualStyleBackColor = true;
            this.buttonSua_NhapHang.Visible = false;
            this.buttonSua_NhapHang.Click += new System.EventHandler(this.buttonSua_NhapHang_Click);
            // 
            // buttonXoa_NhapHang
            // 
            this.buttonXoa_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonXoa_NhapHang.Location = new System.Drawing.Point(195, 3);
            this.buttonXoa_NhapHang.Name = "buttonXoa_NhapHang";
            this.buttonXoa_NhapHang.Size = new System.Drawing.Size(92, 26);
            this.buttonXoa_NhapHang.TabIndex = 2;
            this.buttonXoa_NhapHang.Text = "Xoá";
            this.buttonXoa_NhapHang.UseVisualStyleBackColor = true;
            this.buttonXoa_NhapHang.Visible = false;
            this.buttonXoa_NhapHang.Click += new System.EventHandler(this.buttonXoa_NhapHang_Click);
            // 
            // maNhapHang
            // 
            this.maNhapHang.HeaderText = "Mã nhập hàng";
            this.maNhapHang.Name = "maNhapHang";
            this.maNhapHang.ReadOnly = true;
            // 
            // maThuoc
            // 
            this.maThuoc.HeaderText = "Thuốc";
            this.maThuoc.Name = "maThuoc";
            this.maThuoc.ReadOnly = true;
            // 
            // donViNhap
            // 
            this.donViNhap.HeaderText = "Đơn vị nhập";
            this.donViNhap.Name = "donViNhap";
            this.donViNhap.ReadOnly = true;
            // 
            // giaTriQuyDoi
            // 
            this.giaTriQuyDoi.HeaderText = "Giá trị quy đổi";
            this.giaTriQuyDoi.Name = "giaTriQuyDoi";
            this.giaTriQuyDoi.ReadOnly = true;
            this.giaTriQuyDoi.Visible = false;
            // 
            // soLuongNhap
            // 
            this.soLuongNhap.HeaderText = "Số lượng nhập";
            this.soLuongNhap.Name = "soLuongNhap";
            this.soLuongNhap.ReadOnly = true;
            // 
            // giaNhap
            // 
            this.giaNhap.HeaderText = "Giá nhập";
            this.giaNhap.Name = "giaNhap";
            this.giaNhap.ReadOnly = true;
            // 
            // moTa
            // 
            this.moTa.HeaderText = "Mô tả";
            this.moTa.Name = "moTa";
            this.moTa.ReadOnly = true;
            this.moTa.Visible = false;
            // 
            // ngayNhap
            // 
            this.ngayNhap.HeaderText = "Ngày nhập";
            this.ngayNhap.Name = "ngayNhap";
            this.ngayNhap.ReadOnly = true;
            // 
            // thanhTien
            // 
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.HeaderText = "Nhân viên nhập hàng";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Visible = false;
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 572);
            this.Controls.Add(this.tableLayoutPanelWindow);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DonHang)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelDangChon_NhapHang;
        private System.Windows.Forms.Button buttonBoChon_NhapHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWindow;
        private System.Windows.Forms.DataGridView dataGridView_DonHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelNgayNhap_NhapHang;
        private System.Windows.Forms.Label labelGiaNhap_NhapHang;
        private System.Windows.Forms.Label labelMoTa_NhapHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelSoLuongNhap_NhapHang;
        private System.Windows.Forms.Label labelGiaTriQuyDoi_NhapHang;
        private System.Windows.Forms.Label labelDonViNhap_NhapHang;
        private System.Windows.Forms.Label labelMaThuoc_NhapHang;
        private System.Windows.Forms.Label labelNhanVienNhapHang_NhapHang;
        private System.Windows.Forms.TextBox textBoxThanhTien_NhapHang;
        private System.Windows.Forms.TextBox textBoxGiapNhap_NhapHang;
        private System.Windows.Forms.TextBox textBoxMoTa_NhapHang;
        private System.Windows.Forms.DateTimePicker dateTimeNgayNhap_NhapHang;
        private System.Windows.Forms.TextBox textBoxSoLuongNhap_NhapHang;
        private System.Windows.Forms.TextBox textBoxGiaTriQuyDoi_NhapHang;
        private System.Windows.Forms.ComboBox comboBoxThuoc_NhapHang;
        private System.Windows.Forms.TextBox textBoxDonViNhap_NhapHang;
        private System.Windows.Forms.ComboBox comboBoxNhanVien_NhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTriQuyDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonXoa_NhapHang;
        private System.Windows.Forms.Button buttonSua_NhapHang;
        private System.Windows.Forms.Button buttonThem_NhapHang;
    }
}