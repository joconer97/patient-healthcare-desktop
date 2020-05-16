namespace PatientManagement.Forms.Pharmacy
{
    partial class ImportMedicine
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
            this.lsvMedicine = new System.Windows.Forms.ListView();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lsvMedicine
            // 
            this.lsvMedicine.HideSelection = false;
            this.lsvMedicine.Location = new System.Drawing.Point(12, 12);
            this.lsvMedicine.Name = "lsvMedicine";
            this.lsvMedicine.Size = new System.Drawing.Size(1198, 423);
            this.lsvMedicine.TabIndex = 2;
            this.lsvMedicine.UseCompatibleStateImageBehavior = false;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(849, 613);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Product";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1045, 613);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(165, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Open Excel";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ImportMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 648);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lsvMedicine);
            this.Name = "ImportMedicine";
            this.Text = "ImportMedicine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvMedicine;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}