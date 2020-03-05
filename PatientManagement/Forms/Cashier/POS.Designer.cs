namespace PatientManagement.Forms.Cashier
{
    partial class POS
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
            this.lsvProduct = new MetroFramework.Controls.MetroListView();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnMedicine = new MetroFramework.Controls.MetroButton();
            this.btnMedicalSupply = new MetroFramework.Controls.MetroButton();
            this.btnLab = new MetroFramework.Controls.MetroButton();
            this.lsvTransaction = new System.Windows.Forms.ListView();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lsvProduct
            // 
            this.lsvProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvProduct.FullRowSelect = true;
            this.lsvProduct.Location = new System.Drawing.Point(3, 90);
            this.lsvProduct.Name = "lsvProduct";
            this.lsvProduct.OwnerDraw = true;
            this.lsvProduct.Size = new System.Drawing.Size(631, 461);
            this.lsvProduct.TabIndex = 0;
            this.lsvProduct.UseCompatibleStateImageBehavior = false;
            this.lsvProduct.UseSelectable = true;
            this.lsvProduct.DoubleClick += new System.EventHandler(this.lsvProduct_DoubleClick);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "Search...."};
            this.metroTextBox1.Location = new System.Drawing.Point(4, 16);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(281, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Text = "Search....";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(291, 16);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Search";
            this.metroButton1.UseSelectable = true;
            // 
            // btnMedicine
            // 
            this.btnMedicine.Location = new System.Drawing.Point(3, 61);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(75, 23);
            this.btnMedicine.TabIndex = 3;
            this.btnMedicine.Text = "Medicine";
            this.btnMedicine.UseSelectable = true;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnMedicalSupply
            // 
            this.btnMedicalSupply.Location = new System.Drawing.Point(84, 61);
            this.btnMedicalSupply.Name = "btnMedicalSupply";
            this.btnMedicalSupply.Size = new System.Drawing.Size(124, 23);
            this.btnMedicalSupply.TabIndex = 4;
            this.btnMedicalSupply.Text = "Medical Supply";
            this.btnMedicalSupply.UseSelectable = true;
            this.btnMedicalSupply.Click += new System.EventHandler(this.btnMedicalSupply_Click);
            // 
            // btnLab
            // 
            this.btnLab.Location = new System.Drawing.Point(214, 61);
            this.btnLab.Name = "btnLab";
            this.btnLab.Size = new System.Drawing.Size(124, 23);
            this.btnLab.TabIndex = 5;
            this.btnLab.Text = "Laboratory";
            this.btnLab.UseSelectable = true;
            // 
            // lsvTransaction
            // 
            this.lsvTransaction.HideSelection = false;
            this.lsvTransaction.Location = new System.Drawing.Point(716, 90);
            this.lsvTransaction.Name = "lsvTransaction";
            this.lsvTransaction.Size = new System.Drawing.Size(353, 259);
            this.lsvTransaction.TabIndex = 6;
            this.lsvTransaction.UseCompatibleStateImageBehavior = false;
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Lines = new string[] {
        "Total"};
            this.txtTotal.Location = new System.Drawing.Point(716, 355);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(353, 23);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.Text = "Total";
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[] {
        "Payment"};
            this.metroTextBox3.Location = new System.Drawing.Point(716, 384);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(353, 23);
            this.metroTextBox3.TabIndex = 8;
            this.metroTextBox3.Text = "Payment";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[] {
        "Change"};
            this.metroTextBox4.Location = new System.Drawing.Point(716, 413);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(353, 23);
            this.metroTextBox4.TabIndex = 9;
            this.metroTextBox4.Text = "Change";
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(716, 525);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(353, 23);
            this.metroButton5.TabIndex = 10;
            this.metroButton5.Text = "Pay";
            this.metroButton5.UseSelectable = true;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 563);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lsvTransaction);
            this.Controls.Add(this.btnLab);
            this.Controls.Add(this.btnMedicalSupply);
            this.Controls.Add(this.btnMedicine);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.lsvProduct);
            this.Name = "POS";
            this.Text = "POS";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lsvProduct;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnMedicine;
        private MetroFramework.Controls.MetroButton btnMedicalSupply;
        private MetroFramework.Controls.MetroButton btnLab;
        private System.Windows.Forms.ListView lsvTransaction;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}