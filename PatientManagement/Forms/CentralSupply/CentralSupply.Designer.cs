namespace PatientManagement.Forms.CentralSupply
{
    partial class CentralSupply
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
            this.lsvMedical = new System.Windows.Forms.ListView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(19, 38);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1287, 579);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lsvMedical);
            this.tabPage1.Controls.Add(this.metroButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1279, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medical Supply";
            // 
            // lsvMedical
            // 
            this.lsvMedical.HideSelection = false;
            this.lsvMedical.Location = new System.Drawing.Point(15, 46);
            this.lsvMedical.Name = "lsvMedical";
            this.lsvMedical.Size = new System.Drawing.Size(1242, 429);
            this.lsvMedical.TabIndex = 1;
            this.lsvMedical.UseCompatibleStateImageBehavior = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1092, 501);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(165, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Import Supply";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1279, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medical Supply Request ";
            // 
            // CentralSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "CentralSupply";
            this.Text = "CentralSupply";
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lsvMedical;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}