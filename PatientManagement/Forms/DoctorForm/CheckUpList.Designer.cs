namespace PatientManagement.Forms.DoctorForm
{
    partial class CheckUpList
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
            this.label1 = new System.Windows.Forms.Label();
            this.lsvCheckup = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Check-up List";
            // 
            // lsvCheckup
            // 
            this.lsvCheckup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvCheckup.FullRowSelect = true;
            this.lsvCheckup.Location = new System.Drawing.Point(22, 103);
            this.lsvCheckup.Name = "lsvCheckup";
            this.lsvCheckup.OwnerDraw = true;
            this.lsvCheckup.Size = new System.Drawing.Size(1335, 544);
            this.lsvCheckup.Style = MetroFramework.MetroColorStyle.Green;
            this.lsvCheckup.TabIndex = 2;
            this.lsvCheckup.UseCompatibleStateImageBehavior = false;
            this.lsvCheckup.UseSelectable = true;
            this.lsvCheckup.DoubleClick += new System.EventHandler(this.lsvCheckup_DoubleClick_1);
            // 
            // CheckUpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lsvCheckup);
            this.Controls.Add(this.label1);
            this.Name = "CheckUpList";
            this.Text = "CheckUpList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroListView lsvCheckup;
    }
}