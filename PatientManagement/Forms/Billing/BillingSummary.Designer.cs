namespace PatientManagement.Forms.Billing
{
    partial class BillingSummary
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
            this.lsvSummary = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // lsvSummary
            // 
            this.lsvSummary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvSummary.FullRowSelect = true;
            this.lsvSummary.Location = new System.Drawing.Point(24, 112);
            this.lsvSummary.Name = "lsvSummary";
            this.lsvSummary.OwnerDraw = true;
            this.lsvSummary.Size = new System.Drawing.Size(753, 315);
            this.lsvSummary.TabIndex = 0;
            this.lsvSummary.UseCompatibleStateImageBehavior = false;
            this.lsvSummary.UseSelectable = true;
            // 
            // BillingSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvSummary);
            this.Name = "BillingSummary";
            this.Text = "BillingSummary";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lsvSummary;
    }
}