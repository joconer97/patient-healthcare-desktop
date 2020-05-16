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
            this.lsvCheckup = new MetroFramework.Controls.MetroListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1185, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1095, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome  :";
            // 
            // CheckUpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsvCheckup);
            this.Name = "CheckUpList";
            this.Text = "Patient List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroListView lsvCheckup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}