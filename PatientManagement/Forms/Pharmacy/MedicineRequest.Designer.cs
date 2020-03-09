namespace PatientManagement.Forms.Pharmacy
{
    partial class MedicineRequest
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
            this.lsvMedicineRequest = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // lsvMedicineRequest
            // 
            this.lsvMedicineRequest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvMedicineRequest.FullRowSelect = true;
            this.lsvMedicineRequest.Location = new System.Drawing.Point(13, 29);
            this.lsvMedicineRequest.Name = "lsvMedicineRequest";
            this.lsvMedicineRequest.OwnerDraw = true;
            this.lsvMedicineRequest.Size = new System.Drawing.Size(775, 397);
            this.lsvMedicineRequest.TabIndex = 0;
            this.lsvMedicineRequest.UseCompatibleStateImageBehavior = false;
            this.lsvMedicineRequest.UseSelectable = true;
            // 
            // MedicineRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvMedicineRequest);
            this.Name = "MedicineRequest";
            this.Text = "MedicineRequest";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lsvMedicineRequest;
    }
}