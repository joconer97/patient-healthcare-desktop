namespace PatientManagement.Forms.Laboratory
{
    partial class LaboratoryResultList
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
            this.lsvLaboratory = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsvLaboratory
            // 
            this.lsvLaboratory.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvLaboratory.HideSelection = false;
            this.lsvLaboratory.Location = new System.Drawing.Point(12, 120);
            this.lsvLaboratory.Name = "lsvLaboratory";
            this.lsvLaboratory.Size = new System.Drawing.Size(1073, 412);
            this.lsvLaboratory.TabIndex = 1;
            this.lsvLaboratory.UseCompatibleStateImageBehavior = false;
            this.lsvLaboratory.DoubleClick += new System.EventHandler(this.lsvLaboratory_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 27);
            this.textBox1.TabIndex = 2;
            // 
            // LaboratoryResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lsvLaboratory);
            this.Name = "LaboratoryResultList";
            this.Text = "Laboratory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvLaboratory;
        private System.Windows.Forms.TextBox textBox1;
    }
}