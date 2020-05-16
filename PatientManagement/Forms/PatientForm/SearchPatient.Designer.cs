namespace PatientManagement.Forms.PatientForm
{
    partial class SearchPatient
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
            this.lsvPatient = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsvPatient
            // 
            this.lsvPatient.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvPatient.HideSelection = false;
            this.lsvPatient.Location = new System.Drawing.Point(39, 58);
            this.lsvPatient.Name = "lsvPatient";
            this.lsvPatient.Size = new System.Drawing.Size(1068, 542);
            this.lsvPatient.TabIndex = 0;
            this.lsvPatient.UseCompatibleStateImageBehavior = false;
            this.lsvPatient.DoubleClick += new System.EventHandler(this.lsvPatient_DoubleClick);
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 633);
            this.Controls.Add(this.lsvPatient);
            this.Name = "SearchPatient";
            this.Text = "SearchPatient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvPatient;
    }
}