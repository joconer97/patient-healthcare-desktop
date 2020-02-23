namespace PatientManagement.Forms.PatientForm
{
    partial class FollowUPSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvView = new System.Windows.Forms.ListView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvView);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(22, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 482);
            this.panel1.TabIndex = 4;
            // 
            // lsvView
            // 
            this.lsvView.HideSelection = false;
            this.lsvView.Location = new System.Drawing.Point(12, 130);
            this.lsvView.Name = "lsvView";
            this.lsvView.Size = new System.Drawing.Size(940, 315);
            this.lsvView.TabIndex = 5;
            this.lsvView.UseCompatibleStateImageBehavior = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Discharge#";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(363, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search Discharge. ID";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // FollowUPSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 604);
            this.Controls.Add(this.panel1);
            this.Name = "FollowUPSearch";
            this.Text = "FollowUPSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}