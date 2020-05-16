namespace PatientManagement.Forms.Pharmacy
{
    partial class Pharmacy
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsvMedicine = new System.Windows.Forms.ListView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lsvMedicineRequest = new System.Windows.Forms.ListView();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 82);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1287, 579);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.lsvMedicine);
            this.tabPage1.Controls.Add(this.metroButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1279, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medicine";
            // 
            // lsvMedicine
            // 
            this.lsvMedicine.HideSelection = false;
            this.lsvMedicine.Location = new System.Drawing.Point(15, 46);
            this.lsvMedicine.Name = "lsvMedicine";
            this.lsvMedicine.Size = new System.Drawing.Size(1242, 423);
            this.lsvMedicine.TabIndex = 1;
            this.lsvMedicine.UseCompatibleStateImageBehavior = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1092, 501);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(165, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Import Product";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lsvMedicineRequest);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1279, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medicine Request";
            // 
            // lsvMedicineRequest
            // 
            this.lsvMedicineRequest.HideSelection = false;
            this.lsvMedicineRequest.Location = new System.Drawing.Point(3, 3);
            this.lsvMedicineRequest.Name = "lsvMedicineRequest";
            this.lsvMedicineRequest.Size = new System.Drawing.Size(1273, 531);
            this.lsvMedicineRequest.TabIndex = 0;
            this.lsvMedicineRequest.UseCompatibleStateImageBehavior = false;
            this.lsvMedicineRequest.DoubleClick += new System.EventHandler(this.lsvMedicineRequest_DoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(896, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Product";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Pharmacy";
            this.Text = "Pharmacy";
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ListView lsvMedicine;
        private System.Windows.Forms.ListView lsvMedicineRequest;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}