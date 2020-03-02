namespace PatientManagement.Forms.PatientForm
{
    partial class AdmissionRequestList
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
            this.lsvAdmission = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsvAdmission
            // 
            this.lsvAdmission.HideSelection = false;
            this.lsvAdmission.Location = new System.Drawing.Point(13, 39);
            this.lsvAdmission.Name = "lsvAdmission";
            this.lsvAdmission.Size = new System.Drawing.Size(1168, 537);
            this.lsvAdmission.TabIndex = 0;
            this.lsvAdmission.UseCompatibleStateImageBehavior = false;
            this.lsvAdmission.SelectedIndexChanged += new System.EventHandler(this.lsvAdmission_SelectedIndexChanged);
            // 
            // AdmissionRequestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 645);
            this.Controls.Add(this.lsvAdmission);
            this.Name = "AdmissionRequestList";
            this.Text = "AdmissionRequestList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvAdmission;
    }
}