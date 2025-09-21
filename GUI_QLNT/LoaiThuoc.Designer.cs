namespace GUI_QLNT
{
    partial class LoaiThuoc
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
            this.tableLayoutPanelWindow = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_LoaiThuoc = new System.Windows.Forms.DataGridView();
            this.maLTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDangChon_LoaiThuoc = new System.Windows.Forms.Label();
            this.buttonBoChon_LoaiThuoc = new System.Windows.Forms.Button();
            this.textBoxTimKiem_LoaiThuoc = new System.Windows.Forms.TextBox();
            this.buttonTimKiem_LoaiThuoc = new System.Windows.Forms.Button();
            this.buttonHuyTimKiem_LoaiThuoc = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTenLoaiThuoc_LoaiThuoc = new System.Windows.Forms.Label();
            this.textBoxTenLoaiThuoc_LoaiThuoc = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxMoTa_LoaiThuoc = new System.Windows.Forms.TextBox();
            this.labelMoTa_LoaiThuoc = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonXoa_LoaiThuoc = new System.Windows.Forms.Button();
            this.buttonSua_LoaiThuoc = new System.Windows.Forms.Button();
            this.buttonThem_LoaiThuoc = new System.Windows.Forms.Button();
            this.tableLayoutPanelWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiThuoc)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelWindow
            // 
            this.tableLayoutPanelWindow.ColumnCount = 1;
            this.tableLayoutPanelWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWindow.Controls.Add(this.dataGridView_LoaiThuoc, 0, 1);
            this.tableLayoutPanelWindow.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelWindow.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWindow.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelWindow.Name = "tableLayoutPanelWindow";
            this.tableLayoutPanelWindow.RowCount = 3;
            this.tableLayoutPanelWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanelWindow.Size = new System.Drawing.Size(856, 590);
            this.tableLayoutPanelWindow.TabIndex = 0;
            // 
            // dataGridView_LoaiThuoc
            // 
            this.dataGridView_LoaiThuoc.AllowUserToAddRows = false;
            this.dataGridView_LoaiThuoc.AllowUserToDeleteRows = false;
            this.dataGridView_LoaiThuoc.AllowUserToResizeColumns = false;
            this.dataGridView_LoaiThuoc.AllowUserToResizeRows = false;
            this.dataGridView_LoaiThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LoaiThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoaiThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLTc,
            this.tenLt,
            this.moTa});
            this.dataGridView_LoaiThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_LoaiThuoc.Location = new System.Drawing.Point(3, 43);
            this.dataGridView_LoaiThuoc.Name = "dataGridView_LoaiThuoc";
            this.dataGridView_LoaiThuoc.ReadOnly = true;
            this.dataGridView_LoaiThuoc.RowHeadersVisible = false;
            this.dataGridView_LoaiThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_LoaiThuoc.Size = new System.Drawing.Size(850, 384);
            this.dataGridView_LoaiThuoc.TabIndex = 0;
            this.dataGridView_LoaiThuoc.Click += new System.EventHandler(this.dataGridView_LoaiThuoc_Click);
            // 
            // maLTc
            // 
            this.maLTc.HeaderText = "Mã loại thuốc";
            this.maLTc.Name = "maLTc";
            this.maLTc.ReadOnly = true;
            // 
            // tenLt
            // 
            this.tenLt.HeaderText = "Tên loại thuốc";
            this.tenLt.Name = "tenLt";
            this.tenLt.ReadOnly = true;
            // 
            // moTa
            // 
            this.moTa.HeaderText = "Mô tả";
            this.moTa.Name = "moTa";
            this.moTa.ReadOnly = true;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 34);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.labelDangChon_LoaiThuoc, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonBoChon_LoaiThuoc, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTimKiem_LoaiThuoc, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonTimKiem_LoaiThuoc, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonHuyTimKiem_LoaiThuoc, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(844, 34);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // labelDangChon_LoaiThuoc
            // 
            this.labelDangChon_LoaiThuoc.AutoSize = true;
            this.labelDangChon_LoaiThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDangChon_LoaiThuoc.Location = new System.Drawing.Point(3, 0);
            this.labelDangChon_LoaiThuoc.Name = "labelDangChon_LoaiThuoc";
            this.labelDangChon_LoaiThuoc.Size = new System.Drawing.Size(162, 34);
            this.labelDangChon_LoaiThuoc.TabIndex = 0;
            this.labelDangChon_LoaiThuoc.Text = "Mã loại thuốc đang chọn:";
            this.labelDangChon_LoaiThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonBoChon_LoaiThuoc
            // 
            this.buttonBoChon_LoaiThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBoChon_LoaiThuoc.Enabled = false;
            this.buttonBoChon_LoaiThuoc.Location = new System.Drawing.Point(171, 3);
            this.buttonBoChon_LoaiThuoc.Name = "buttonBoChon_LoaiThuoc";
            this.buttonBoChon_LoaiThuoc.Size = new System.Drawing.Size(78, 28);
            this.buttonBoChon_LoaiThuoc.TabIndex = 1;
            this.buttonBoChon_LoaiThuoc.Text = "Bỏ chọn";
            this.buttonBoChon_LoaiThuoc.UseVisualStyleBackColor = true;
            this.buttonBoChon_LoaiThuoc.Click += new System.EventHandler(this.buttonBoChon_LoaiThuoc_Click);
            // 
            // textBoxTimKiem_LoaiThuoc
            // 
            this.textBoxTimKiem_LoaiThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimKiem_LoaiThuoc.Location = new System.Drawing.Point(255, 7);
            this.textBoxTimKiem_LoaiThuoc.Name = "textBoxTimKiem_LoaiThuoc";
            this.textBoxTimKiem_LoaiThuoc.Size = new System.Drawing.Size(416, 20);
            this.textBoxTimKiem_LoaiThuoc.TabIndex = 2;
            // 
            // buttonTimKiem_LoaiThuoc
            // 
            this.buttonTimKiem_LoaiThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTimKiem_LoaiThuoc.Location = new System.Drawing.Point(677, 3);
            this.buttonTimKiem_LoaiThuoc.Name = "buttonTimKiem_LoaiThuoc";
            this.buttonTimKiem_LoaiThuoc.Size = new System.Drawing.Size(78, 28);
            this.buttonTimKiem_LoaiThuoc.TabIndex = 3;
            this.buttonTimKiem_LoaiThuoc.Text = "Tìm kiếm";
            this.buttonTimKiem_LoaiThuoc.UseVisualStyleBackColor = true;
            this.buttonTimKiem_LoaiThuoc.Click += new System.EventHandler(this.buttonTimKiem_LoaiThuoc_Click);
            // 
            // buttonHuyTimKiem_LoaiThuoc
            // 
            this.buttonHuyTimKiem_LoaiThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHuyTimKiem_LoaiThuoc.Location = new System.Drawing.Point(761, 3);
            this.buttonHuyTimKiem_LoaiThuoc.Name = "buttonHuyTimKiem_LoaiThuoc";
            this.buttonHuyTimKiem_LoaiThuoc.Size = new System.Drawing.Size(80, 28);
            this.buttonHuyTimKiem_LoaiThuoc.TabIndex = 4;
            this.buttonHuyTimKiem_LoaiThuoc.Text = "Huỷ tìm kiếm";
            this.buttonHuyTimKiem_LoaiThuoc.UseVisualStyleBackColor = true;
            this.buttonHuyTimKiem_LoaiThuoc.Click += new System.EventHandler(this.buttonHuyTimKiem_LoaiThuoc_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 433);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(850, 69);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.06203F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.93797F));
            this.tableLayoutPanel4.Controls.Add(this.labelTenLoaiThuoc_LoaiThuoc, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxTenLoaiThuoc_LoaiThuoc, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(419, 28);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // labelTenLoaiThuoc_LoaiThuoc
            // 
            this.labelTenLoaiThuoc_LoaiThuoc.AutoSize = true;
            this.labelTenLoaiThuoc_LoaiThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTenLoaiThuoc_LoaiThuoc.Location = new System.Drawing.Point(3, 0);
            this.labelTenLoaiThuoc_LoaiThuoc.Name = "labelTenLoaiThuoc_LoaiThuoc";
            this.labelTenLoaiThuoc_LoaiThuoc.Size = new System.Drawing.Size(99, 28);
            this.labelTenLoaiThuoc_LoaiThuoc.TabIndex = 0;
            this.labelTenLoaiThuoc_LoaiThuoc.Text = "Tên loại thuốc";
            this.labelTenLoaiThuoc_LoaiThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTenLoaiThuoc_LoaiThuoc
            // 
            this.textBoxTenLoaiThuoc_LoaiThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTenLoaiThuoc_LoaiThuoc.Location = new System.Drawing.Point(108, 4);
            this.textBoxTenLoaiThuoc_LoaiThuoc.Name = "textBoxTenLoaiThuoc_LoaiThuoc";
            this.textBoxTenLoaiThuoc_LoaiThuoc.Size = new System.Drawing.Size(308, 20);
            this.textBoxTenLoaiThuoc_LoaiThuoc.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.06203F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.93797F));
            this.tableLayoutPanel5.Controls.Add(this.textBoxMoTa_LoaiThuoc, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelMoTa_LoaiThuoc, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(419, 29);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // textBoxMoTa_LoaiThuoc
            // 
            this.textBoxMoTa_LoaiThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMoTa_LoaiThuoc.Location = new System.Drawing.Point(108, 4);
            this.textBoxMoTa_LoaiThuoc.Name = "textBoxMoTa_LoaiThuoc";
            this.textBoxMoTa_LoaiThuoc.Size = new System.Drawing.Size(308, 20);
            this.textBoxMoTa_LoaiThuoc.TabIndex = 2;
            // 
            // labelMoTa_LoaiThuoc
            // 
            this.labelMoTa_LoaiThuoc.AutoSize = true;
            this.labelMoTa_LoaiThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMoTa_LoaiThuoc.Location = new System.Drawing.Point(3, 0);
            this.labelMoTa_LoaiThuoc.Name = "labelMoTa_LoaiThuoc";
            this.labelMoTa_LoaiThuoc.Size = new System.Drawing.Size(99, 29);
            this.labelMoTa_LoaiThuoc.TabIndex = 1;
            this.labelMoTa_LoaiThuoc.Text = "Mô tả";
            this.labelMoTa_LoaiThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.buttonXoa_LoaiThuoc, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonSua_LoaiThuoc, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonThem_LoaiThuoc, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(428, 37);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(419, 29);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // buttonXoa_LoaiThuoc
            // 
            this.buttonXoa_LoaiThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonXoa_LoaiThuoc.Location = new System.Drawing.Point(281, 3);
            this.buttonXoa_LoaiThuoc.Name = "buttonXoa_LoaiThuoc";
            this.buttonXoa_LoaiThuoc.Size = new System.Drawing.Size(135, 23);
            this.buttonXoa_LoaiThuoc.TabIndex = 2;
            this.buttonXoa_LoaiThuoc.Text = "Xoá";
            this.buttonXoa_LoaiThuoc.UseVisualStyleBackColor = true;
            this.buttonXoa_LoaiThuoc.Visible = false;
            this.buttonXoa_LoaiThuoc.Click += new System.EventHandler(this.buttonXoa_LoaiThuoc_Click);
            // 
            // buttonSua_LoaiThuoc
            // 
            this.buttonSua_LoaiThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSua_LoaiThuoc.Location = new System.Drawing.Point(142, 3);
            this.buttonSua_LoaiThuoc.Name = "buttonSua_LoaiThuoc";
            this.buttonSua_LoaiThuoc.Size = new System.Drawing.Size(133, 23);
            this.buttonSua_LoaiThuoc.TabIndex = 1;
            this.buttonSua_LoaiThuoc.Text = "Sửa";
            this.buttonSua_LoaiThuoc.UseVisualStyleBackColor = true;
            this.buttonSua_LoaiThuoc.Visible = false;
            this.buttonSua_LoaiThuoc.Click += new System.EventHandler(this.buttonSua_LoaiThuoc_Click);
            // 
            // buttonThem_LoaiThuoc
            // 
            this.buttonThem_LoaiThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonThem_LoaiThuoc.Location = new System.Drawing.Point(3, 3);
            this.buttonThem_LoaiThuoc.Name = "buttonThem_LoaiThuoc";
            this.buttonThem_LoaiThuoc.Size = new System.Drawing.Size(133, 23);
            this.buttonThem_LoaiThuoc.TabIndex = 0;
            this.buttonThem_LoaiThuoc.Text = "Thêm";
            this.buttonThem_LoaiThuoc.UseVisualStyleBackColor = true;
            this.buttonThem_LoaiThuoc.Click += new System.EventHandler(this.buttonThem_LoaiThuoc_Click);
            // 
            // LoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 590);
            this.Controls.Add(this.tableLayoutPanelWindow);
            this.Name = "LoaiThuoc";
            this.Text = "LoaiThuoc";
            this.Load += new System.EventHandler(this.LoaiThuoc_Load);
            this.tableLayoutPanelWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiThuoc)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWindow;
        private System.Windows.Forms.DataGridView dataGridView_LoaiThuoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonBoChon_LoaiThuoc;
        private System.Windows.Forms.TextBox textBoxTimKiem_LoaiThuoc;
        private System.Windows.Forms.Button buttonTimKiem_LoaiThuoc;
        private System.Windows.Forms.Button buttonHuyTimKiem_LoaiThuoc;
        private System.Windows.Forms.Label labelDangChon_LoaiThuoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelTenLoaiThuoc_LoaiThuoc;
        private System.Windows.Forms.TextBox textBoxTenLoaiThuoc_LoaiThuoc;
        private System.Windows.Forms.TextBox textBoxMoTa_LoaiThuoc;
        private System.Windows.Forms.Label labelMoTa_LoaiThuoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonXoa_LoaiThuoc;
        private System.Windows.Forms.Button buttonSua_LoaiThuoc;
        private System.Windows.Forms.Button buttonThem_LoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLt;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
    }
}