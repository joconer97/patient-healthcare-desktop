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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvView2 = new MetroFramework.Controls.MetroListView();
            this.lblFound = new System.Windows.Forms.Label();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.lsvView = new MetroFramework.Controls.MetroListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvView2);
            this.panel1.Controls.Add(this.lblFound);
            this.panel1.Controls.Add(this.btnSearch2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 452);
            this.panel1.TabIndex = 3;
            // 
            // lsvView2
            // 
            this.lsvView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvView2.FullRowSelect = true;
            this.lsvView2.Location = new System.Drawing.Point(22, 149);
            this.lsvView2.Name = "lsvView2";
            this.lsvView2.OwnerDraw = true;
            this.lsvView2.Size = new System.Drawing.Size(930, 283);
            this.lsvView2.TabIndex = 7;
            this.lsvView2.UseCompatibleStateImageBehavior = false;
            this.lsvView2.UseSelectable = true;
            this.lsvView2.DoubleClick += new System.EventHandler(this.lsvView2_DoubleClick);
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFound.Location = new System.Drawing.Point(25, 113);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(117, 19);
            this.lblFound.TabIndex = 6;
            this.lblFound.Text = "0 found patient";
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnSearch2.FlatAppearance.BorderSize = 0;
            this.btnSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch2.Location = new System.Drawing.Point(363, 22);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(171, 29);
            this.btnSearch2.TabIndex = 4;
            this.btnSearch2.Text = "Search by Lastname";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // lsvView
            // 
            this.lsvView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvView.FullRowSelect = true;
            this.lsvView.GridLines = true;
            this.lsvView.Location = new System.Drawing.Point(22, 209);
            this.lsvView.Name = "lsvView";
            this.lsvView.OwnerDraw = true;
            this.lsvView.Size = new System.Drawing.Size(930, 301);
            this.lsvView.TabIndex = 7;
            this.lsvView.UseCompatibleStateImageBehavior = false;
            this.lsvView.UseSelectable = true;
            // 
            // CheckUPSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 586);
            this.Controls.Add(this.panel1);
            this.Name = "CheckUPSearch";
            this.Text = "Out Patient Checkup";
            this.Load += new System.EventHandler(this.CheckUPSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Label lblFound;
        private MetroFramework.Controls.MetroListView lsvView;
        private MetroFramework.Controls.MetroListView lsvView2;
    }
}