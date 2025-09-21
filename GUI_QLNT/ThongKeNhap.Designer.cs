using System.Windows.Forms;

namespace GUI_QLNT
{
    partial class ThongKeNhap
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaNhapThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTriQuyDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHamLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHangSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnFill = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExcel, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFill, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhapThuoc,
            this.colTenThuoc,
            this.colDonViNhap,
            this.colGiaTriQuyDoi,
            this.colSoLuongNhap,
            this.colGiaNhap,
            this.colMoTa,
            this.colNgayNhap,
            this.colThanhTien,
            this.colUserName,
            this.colHamLuong,
            this.colHangSanXuat});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // colMaNhapThuoc
            // 
            this.colMaNhapThuoc.HeaderText = "Mã Nhập Thuốc";
            this.colMaNhapThuoc.Name = "colMaNhapThuoc";
            // 
            // colTenThuoc
            // 
            this.colTenThuoc.HeaderText = "Tên Thuốc";
            this.colTenThuoc.Name = "colTenThuoc";
            // 
            // colDonViNhap
            // 
            this.colDonViNhap.HeaderText = "Đơn Vị Nhập";
            this.colDonViNhap.Name = "colDonViNhap";
            // 
            // colGiaTriQuyDoi
            // 
            this.colGiaTriQuyDoi.HeaderText = "Giá Trị Quy Đổi";
            this.colGiaTriQuyDoi.Name = "colGiaTriQuyDoi";
            // 
            // colSoLuongNhap
            // 
            this.colSoLuongNhap.HeaderText = "Số Lượng Nhập";
            this.colSoLuongNhap.Name = "colSoLuongNhap";
            // 
            // colGiaNhap
            // 
            this.colGiaNhap.HeaderText = "Giá Nhập";
            this.colGiaNhap.Name = "colGiaNhap";
            // 
            // colMoTa
            // 
            this.colMoTa.HeaderText = "Mô Tả";
            this.colMoTa.Name = "colMoTa";
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.HeaderText = "Ngày Nhập";
            this.colNgayNhap.Name = "colNgayNhap";
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "Username";
            this.colUserName.Name = "colUserName";
            // 
            // colHamLuong
            // 
            this.colHamLuong.HeaderText = "Hàm Lượng";
            this.colHamLuong.Name = "colHamLuong";
            // 
            // colHangSanXuat
            // 
            this.colHangSanXuat.HeaderText = "Hãng Sản Xuất";
            this.colHangSanXuat.Name = "colHangSanXuat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lọc theo:";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.comboBox1.Location = new System.Drawing.Point(83, 363);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 394);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnExcel
            // 
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcel.Location = new System.Drawing.Point(643, 425);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(106, 22);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Convert to Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(243, 394);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Visible = false;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(83, 425);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(73, 22);
            this.btnFill.TabIndex = 7;
            this.btnFill.Text = "Fillter";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(243, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thành tiền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThongKeNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ThongKeNhap";
            this.Text = "ThongKeNhap";
            this.Load += new System.EventHandler(this.ThongKeNhap_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhapThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTriQuyDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHamLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHangSanXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnFill;
        private Button button1;
    }
}