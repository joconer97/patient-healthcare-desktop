namespace PatientManagement.Forms.NurseForm
{
    partial class InpatientAdmissionList
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
            this.lsvAdmission = new MetroFramework.Controls.MetroListView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lsvAdmission
            // 
            this.lsvAdmission.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvAdmission.FullRowSelect = true;
            this.lsvAdmission.Location = new System.Drawing.Point(34, 77);
            this.lsvAdmission.Name = "lsvAdmission";
            this.lsvAdmission.OwnerDraw = true;
            this.lsvAdmission.Size = new System.Drawing.Size(1222, 609);
            this.lsvAdmission.TabIndex = 3;
            this.lsvAdmission.UseCompatibleStateImageBehavior = false;
            this.lsvAdmission.UseSelectable = true;
            this.lsvAdmission.DoubleClick += new System.EventHandler(this.lsvAdmission_DoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(34, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(166, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Admitted Patient List";
            // 
            // InpatientAdmissionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 715);
            this.Controls.Add(this.lsvAdmission);
            this.Controls.Add(this.metroLabel1);
            this.Name = "InpatientAdmissionList";
            this.Text = "InpatientAdmissionList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView lsvAdmission;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}