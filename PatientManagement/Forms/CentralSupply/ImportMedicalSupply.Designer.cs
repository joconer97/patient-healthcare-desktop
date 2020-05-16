namespace PatientManagement.Forms.CentralSupply
{
    partial class ImportMedicalSupply
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
            this.lsvMedical = new System.Windows.Forms.ListView();
            this.btnOpenExcel = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvMedical
            // 
            this.lsvMedical.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMedical.HideSelection = false;
            this.lsvMedical.Location = new System.Drawing.Point(11, 78);
            this.lsvMedical.Name = "lsvMedical";
            this.lsvMedical.Size = new System.Drawing.Size(1242, 429);
            this.lsvMedical.TabIndex = 2;
            this.lsvMedical.UseCompatibleStateImageBehavior = false;
            // 
            // btnOpenExcel
            // 
            this.btnOpenExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnOpenExcel.FlatAppearance.BorderSize = 0;
            this.btnOpenExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenExcel.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenExcel.Location = new System.Drawing.Point(1136, 513);
            this.btnOpenExcel.Name = "btnOpenExcel";
            this.btnOpenExcel.Size = new System.Drawing.Size(117, 38);
            this.btnOpenExcel.TabIndex = 3;
            this.btnOpenExcel.Text = "Open Excel";
            this.btnOpenExcel.UseVisualStyleBackColor = false;
            this.btnOpenExcel.Click += new System.EventHandler(this.btnOpenExcel_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(983, 513);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(147, 38);
            this.btn.TabIndex = 4;
            this.btn.Text = "Save";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // ImportMedicalSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 577);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnOpenExcel);
            this.Controls.Add(this.lsvMedical);
            this.Name = "ImportMedicalSupply";
            this.Text = "Excel Importing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvMedical;
        private System.Windows.Forms.Button btnOpenExcel;
        private System.Windows.Forms.Button btn;
    }
}