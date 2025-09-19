using System.Drawing;
using System.Windows.Forms;

namespace GUI_QLNT
{
    partial class MedicineForm
    {
        private Label lblPlaceholder;

        private void InitializeComponent()
        {
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.AutoSize = true;
            this.lblPlaceholder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPlaceholder.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPlaceholder.Location = new System.Drawing.Point(50, 50);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(270, 25);
            this.lblPlaceholder.TabIndex = 0;
            this.lblPlaceholder.Text = "📦 Quản lý thông tin Thuốc";
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlaceholder);
            this.Name = "MedicineForm";
            this.Text = "Medicine Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
