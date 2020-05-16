namespace PatientManagement.Forms.DoctorForm
{
    partial class AdmissionReportList
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
            this.lsvList = new System.Windows.Forms.ListView();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvList
            // 
            this.lsvList.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvList.HideSelection = false;
            this.lsvList.Location = new System.Drawing.Point(24, 154);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(924, 360);
            this.lsvList.TabIndex = 0;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(499, 110);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 1;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(739, 110);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 2;
            this.metroDateTime2.ValueChanged += new System.EventHandler(this.metroDateTime2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(705, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // AdmissionReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.lsvList);
            this.Name = "AdmissionReportList";
            this.Text = "Admission Report List";
            this.Load += new System.EventHandler(this.AdmissionReportList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvList;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private System.Windows.Forms.Label label1;
    }
}