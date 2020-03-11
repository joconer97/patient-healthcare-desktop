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
            this.SuspendLayout();
            // 
            // lsvLaboratory
            // 
            this.lsvLaboratory.HideSelection = false;
            this.lsvLaboratory.Location = new System.Drawing.Point(1, 1);
            this.lsvLaboratory.Name = "lsvLaboratory";
            this.lsvLaboratory.Size = new System.Drawing.Size(1096, 551);
            this.lsvLaboratory.TabIndex = 1;
            this.lsvLaboratory.UseCompatibleStateImageBehavior = false;
            this.lsvLaboratory.DoubleClick += new System.EventHandler(this.lsvLaboratory_DoubleClick);
            // 
            // LaboratoryResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 554);
            this.Controls.Add(this.lsvLaboratory);
            this.Name = "LaboratoryResultList";
            this.Text = "LaboratoryResultList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvLaboratory;
    }
}