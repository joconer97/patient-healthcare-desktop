namespace PatientManagement.Forms.DoctorForm
{
    partial class AdmissionList
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lsvAdmission = new MetroFramework.Controls.MetroListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(166, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Admitted Patient List";
            // 
            // lsvAdmission
            // 
            this.lsvAdmission.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvAdmission.FullRowSelect = true;
            this.lsvAdmission.Location = new System.Drawing.Point(33, 134);
            this.lsvAdmission.Name = "lsvAdmission";
            this.lsvAdmission.OwnerDraw = true;
            this.lsvAdmission.Size = new System.Drawing.Size(1310, 611);
            this.lsvAdmission.TabIndex = 1;
            this.lsvAdmission.UseCompatibleStateImageBehavior = false;
            this.lsvAdmission.UseSelectable = true;
            this.lsvAdmission.DoubleClick += new System.EventHandler(this.lsvAdmission_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1090, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // AdmissionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvAdmission);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AdmissionList";
            this.Text = "AdmissionList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroListView lsvAdmission;
        private System.Windows.Forms.Label label1;
    }
}