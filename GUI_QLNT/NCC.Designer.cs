using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace GUI_QLNT
{
    partial class NCC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddrow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddToDB = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTimKiem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddrow, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddToDB, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 264);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenNCC,
            this.colLoaiNCC,
            this.colMoTa,
            this.colMaNcc});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTimKiem.Location = new System.Drawing.Point(3, 67);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 20);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTimKiem.Location = new System.Drawing.Point(112, 67);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(248, 20);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click_1);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave_1);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.Location = new System.Drawing.Point(511, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(656, 363);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // colTenNCC
            // 
            this.colTenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.colTenNCC.Name = "colTenNCC";
            // 
            // colLoaiNCC
            // 
            this.colLoaiNCC.HeaderText = "Loại Nhà Cung Cấp";
            this.colLoaiNCC.Name = "colLoaiNCC";
            // 
            // colMoTa
            // 
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.Name = "colMoTa";
            // 
            // colMaNcc
            // 
            this.colMaNcc.HeaderText = "Mã NCC";
            this.colMaNcc.Name = "colMaNcc";
            this.colMaNcc.Visible = false;
            // 
            // btnAddrow
            // 
            this.btnAddrow.Location = new System.Drawing.Point(366, 363);
            this.btnAddrow.Name = "btnAddrow";
            this.btnAddrow.Size = new System.Drawing.Size(139, 32);
            this.btnAddrow.TabIndex = 7;
            this.btnAddrow.Text = "Add new row";
            this.btnAddrow.UseVisualStyleBackColor = true;
            this.btnAddrow.Click += new System.EventHandler(this.btnAddrow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Location = new System.Drawing.Point(3, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddToDB
            // 
            this.btnAddToDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddToDB.Location = new System.Drawing.Point(112, 363);
            this.btnAddToDB.Name = "btnAddToDB";
            this.btnAddToDB.Size = new System.Drawing.Size(248, 32);
            this.btnAddToDB.TabIndex = 9;
            this.btnAddToDB.Text = "Add to DataBase";
            this.btnAddToDB.UseVisualStyleBackColor = true;
            this.btnAddToDB.Visible = false;
            this.btnAddToDB.Click += new System.EventHandler(this.btnAddToDB_Click);
            // 
            // NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NCC";
            this.Text = "NCC";
            this.Load += new System.EventHandler(this.NCC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Button btnSave;
        private Button btnDelete;
        private DataGridViewTextBoxColumn colTenNCC;
        private DataGridViewTextBoxColumn colLoaiNCC;
        private DataGridViewTextBoxColumn colMoTa;
        private DataGridViewTextBoxColumn colMaNcc;
        private Button btnAddrow;
        private Button btnCancel;
        private Button btnAddToDB;
    }
}