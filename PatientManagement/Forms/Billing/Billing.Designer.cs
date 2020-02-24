namespace PatientManagement.Forms.Billing
{
    partial class Billing
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lsvBillApproval = new MetroFramework.Controls.MetroListView();
            this.lsvPatientBill = new MetroFramework.Controls.MetroListView();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 89);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1249, 635);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lsvBillApproval);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1241, 593);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bill Approval";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lsvPatientBill);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1241, 593);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patient Bill List";
            // 
            // lsvBillApproval
            // 
            this.lsvBillApproval.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvBillApproval.FullRowSelect = true;
            this.lsvBillApproval.Location = new System.Drawing.Point(3, 3);
            this.lsvBillApproval.Name = "lsvBillApproval";
            this.lsvBillApproval.OwnerDraw = true;
            this.lsvBillApproval.Size = new System.Drawing.Size(1235, 587);
            this.lsvBillApproval.TabIndex = 0;
            this.lsvBillApproval.UseCompatibleStateImageBehavior = false;
            this.lsvBillApproval.UseSelectable = true;
            // 
            // lsvPatientBill
            // 
            this.lsvPatientBill.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvPatientBill.FullRowSelect = true;
            this.lsvPatientBill.Location = new System.Drawing.Point(3, 3);
            this.lsvPatientBill.Name = "lsvPatientBill";
            this.lsvPatientBill.OwnerDraw = true;
            this.lsvPatientBill.Size = new System.Drawing.Size(1235, 587);
            this.lsvPatientBill.TabIndex = 1;
            this.lsvPatientBill.UseCompatibleStateImageBehavior = false;
            this.lsvPatientBill.UseSelectable = true;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Billing";
            this.Text = "Billing";
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroListView lsvBillApproval;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroListView lsvPatientBill;
    }
}