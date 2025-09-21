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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NCC));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddrow = new System.Windows.Forms.Button();
            this.btnAddToDB = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTimKiem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddrow, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddToDB, 1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // colTenNCC
            // 
            resources.ApplyResources(this.colTenNCC, "colTenNCC");
            this.colTenNCC.Name = "colTenNCC";
            // 
            // colLoaiNCC
            // 
            resources.ApplyResources(this.colLoaiNCC, "colLoaiNCC");
            this.colLoaiNCC.Name = "colLoaiNCC";
            // 
            // colMoTa
            // 
            resources.ApplyResources(this.colMoTa, "colMoTa");
            this.colMoTa.Name = "colMoTa";
            // 
            // colMaNcc
            // 
            resources.ApplyResources(this.colMaNcc, "colMaNcc");
            this.colMaNcc.Name = "colMaNcc";
            // 
            // btnTimKiem
            // 
            resources.ApplyResources(this.btnTimKiem, "btnTimKiem");
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            resources.ApplyResources(this.txtTimKiem, "txtTimKiem");
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click_1);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave_1);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddrow
            // 
            resources.ApplyResources(this.btnAddrow, "btnAddrow");
            this.btnAddrow.Name = "btnAddrow";
            this.btnAddrow.UseVisualStyleBackColor = true;
            this.btnAddrow.Click += new System.EventHandler(this.btnAddrow_Click);
            // 
            // btnAddToDB
            // 
            resources.ApplyResources(this.btnAddToDB, "btnAddToDB");
            this.btnAddToDB.Name = "btnAddToDB";
            this.btnAddToDB.UseVisualStyleBackColor = true;
            this.btnAddToDB.Click += new System.EventHandler(this.btnAddToDB_Click);
            // 
            // NCC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NCC";
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