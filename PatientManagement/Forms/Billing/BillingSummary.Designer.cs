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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lsvSummary
            // 
            this.lsvSummary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvSummary.FullRowSelect = true;
            this.lsvSummary.Location = new System.Drawing.Point(24, 112);
            this.lsvSummary.Name = "lsvSummary";
            this.lsvSummary.OwnerDraw = true;
            this.lsvSummary.Size = new System.Drawing.Size(753, 294);
            this.lsvSummary.TabIndex = 0;
            this.lsvSummary.UseCompatibleStateImageBehavior = false;
            this.lsvSummary.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(563, 413);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(214, 25);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Discharge Request";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // BillingSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lsvSummary);
            this.Name = "BillingSummary";
            this.Text = "Patient Bill";
            this.Load += new System.EventHandler(this.BillingSummary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lsvSummary;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}