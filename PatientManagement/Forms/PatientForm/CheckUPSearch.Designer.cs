namespace PatientManagement.Forms.PatientForm
{
    partial class CheckUPSearch
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvView = new System.Windows.Forms.ListView();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblFound = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(363, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search by ID";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "ID/LASTNAME";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFound);
            this.panel1.Controls.Add(this.lsvView);
            this.panel1.Controls.Add(this.btnSearch2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 526);
            this.panel1.TabIndex = 3;
            // 
            // lsvView
            // 
            this.lsvView.HideSelection = false;
            this.lsvView.Location = new System.Drawing.Point(12, 193);
            this.lsvView.Name = "lsvView";
            this.lsvView.Size = new System.Drawing.Size(940, 315);
            this.lsvView.TabIndex = 5;
            this.lsvView.UseCompatibleStateImageBehavior = false;
            this.lsvView.DoubleClick += new System.EventHandler(this.lsvView_DoubleClick);
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(501, 24);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(132, 23);
            this.btnSearch2.TabIndex = 4;
            this.btnSearch2.Text = "Search by Lastname";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(806, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Patient List";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFound.Location = new System.Drawing.Point(19, 165);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(114, 19);
            this.lblFound.TabIndex = 6;
            this.lblFound.Text = "0 found patient";
            // 
            // CheckUPSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 586);
            this.Controls.Add(this.panel1);
            this.Name = "CheckUPSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckUP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.ListView lsvView;
        private System.Windows.Forms.Label lblFound;
    }
}