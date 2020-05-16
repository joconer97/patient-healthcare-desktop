namespace PatientManagement.Forms.Billing
{
    partial class Billing
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lsvPatientBill = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Search";
            // 
            // lsvPatientBill
            // 
            this.lsvPatientBill.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvPatientBill.FullRowSelect = true;
            this.lsvPatientBill.Location = new System.Drawing.Point(23, 164);
            this.lsvPatientBill.Name = "lsvPatientBill";
            this.lsvPatientBill.OwnerDraw = true;
            this.lsvPatientBill.Size = new System.Drawing.Size(1307, 568);
            this.lsvPatientBill.TabIndex = 1;
            this.lsvPatientBill.UseCompatibleStateImageBehavior = false;
            this.lsvPatientBill.UseSelectable = true;
            this.lsvPatientBill.DoubleClick += new System.EventHandler(this.lsvPatientBill_DoubleClick);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lsvPatientBill);
            this.Name = "Billing";
            this.Text = "Billing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroListView lsvPatientBill;
        private System.Windows.Forms.TextBox textBox1;
    }
}