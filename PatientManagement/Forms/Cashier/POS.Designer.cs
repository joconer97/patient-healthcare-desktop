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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.lsvProduct = new MetroFramework.Controls.MetroListView();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnMedicine = new MetroFramework.Controls.MetroButton();
            this.btnMedicalSupply = new MetroFramework.Controls.MetroButton();
            this.lsvTransaction = new System.Windows.Forms.ListView();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.txtPayment = new MetroFramework.Controls.MetroTextBox();
            this.txtChange = new MetroFramework.Controls.MetroTextBox();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txtPatientID = new MetroFramework.Controls.MetroTextBox();
            this.txtFullname = new MetroFramework.Controls.MetroTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lsvProduct
            // 
            this.lsvProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvProduct.FullRowSelect = true;
            this.lsvProduct.Location = new System.Drawing.Point(12, 152);
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
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.metroTextBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroTextBox1.Lines = new string[] {
        "Search...."};
            this.metroTextBox1.Location = new System.Drawing.Point(13, 78);
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
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroButton1.Location = new System.Drawing.Point(300, 78);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(102, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Search";
            this.metroButton1.UseSelectable = true;
            // 
            // btnMedicine
            // 
            this.btnMedicine.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMedicine.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnMedicine.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMedicine.Location = new System.Drawing.Point(12, 123);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(75, 23);
            this.btnMedicine.TabIndex = 3;
            this.btnMedicine.Text = "Medicine";
            this.btnMedicine.UseSelectable = true;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnMedicalSupply
            // 
            this.btnMedicalSupply.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMedicalSupply.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnMedicalSupply.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMedicalSupply.Location = new System.Drawing.Point(93, 123);
            this.btnMedicalSupply.Name = "btnMedicalSupply";
            this.btnMedicalSupply.Size = new System.Drawing.Size(124, 23);
            this.btnMedicalSupply.TabIndex = 4;
            this.btnMedicalSupply.Text = "Medical Supply";
            this.btnMedicalSupply.UseSelectable = true;
            this.btnMedicalSupply.Click += new System.EventHandler(this.btnMedicalSupply_Click);
            // 
            // lsvTransaction
            // 
            this.lsvTransaction.HideSelection = false;
            this.lsvTransaction.Location = new System.Drawing.Point(716, 74);
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
            this.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtTotal.Lines = new string[] {
        "Total"};
            this.txtTotal.Location = new System.Drawing.Point(716, 340);
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
            // txtPayment
            // 
            // 
            // 
            // 
            this.txtPayment.CustomButton.Image = null;
            this.txtPayment.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.txtPayment.CustomButton.Name = "";
            this.txtPayment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPayment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPayment.CustomButton.TabIndex = 1;
            this.txtPayment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPayment.CustomButton.UseSelectable = true;
            this.txtPayment.CustomButton.Visible = false;
            this.txtPayment.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPayment.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtPayment.Lines = new string[] {
        "Payment"};
            this.txtPayment.Location = new System.Drawing.Point(716, 371);
            this.txtPayment.MaxLength = 32767;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.PasswordChar = '\0';
            this.txtPayment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPayment.SelectedText = "";
            this.txtPayment.SelectionLength = 0;
            this.txtPayment.SelectionStart = 0;
            this.txtPayment.ShortcutsEnabled = true;
            this.txtPayment.Size = new System.Drawing.Size(353, 23);
            this.txtPayment.TabIndex = 8;
            this.txtPayment.Text = "Payment";
            this.txtPayment.UseSelectable = true;
            this.txtPayment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPayment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPayment.TextChanged += new System.EventHandler(this.metroTextBox3_TextChanged);
            this.txtPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayment_KeyPress);
            // 
            // txtChange
            // 
            // 
            // 
            // 
            this.txtChange.CustomButton.Image = null;
            this.txtChange.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.txtChange.CustomButton.Name = "";
            this.txtChange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChange.CustomButton.TabIndex = 1;
            this.txtChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChange.CustomButton.UseSelectable = true;
            this.txtChange.CustomButton.Visible = false;
            this.txtChange.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtChange.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtChange.Lines = new string[] {
        "Change"};
            this.txtChange.Location = new System.Drawing.Point(716, 406);
            this.txtChange.MaxLength = 32767;
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChange.SelectedText = "";
            this.txtChange.SelectionLength = 0;
            this.txtChange.SelectionStart = 0;
            this.txtChange.ShortcutsEnabled = true;
            this.txtChange.Size = new System.Drawing.Size(353, 23);
            this.txtChange.TabIndex = 9;
            this.txtChange.Text = "Change";
            this.txtChange.UseSelectable = true;
            this.txtChange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton5
            // 
            this.metroButton5.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton5.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton5.Location = new System.Drawing.Point(716, 453);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(353, 23);
            this.metroButton5.TabIndex = 10;
            this.metroButton5.Text = "Pay";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton2.Location = new System.Drawing.Point(716, 551);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(353, 23);
            this.metroButton2.TabIndex = 14;
            this.metroButton2.Text = "Charge Bill";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txtPatientID
            // 
            // 
            // 
            // 
            this.txtPatientID.CustomButton.Image = null;
            this.txtPatientID.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.txtPatientID.CustomButton.Name = "";
            this.txtPatientID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPatientID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatientID.CustomButton.TabIndex = 1;
            this.txtPatientID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatientID.CustomButton.UseSelectable = true;
            this.txtPatientID.CustomButton.Visible = false;
            this.txtPatientID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPatientID.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtPatientID.Lines = new string[] {
        "Patient ID"};
            this.txtPatientID.Location = new System.Drawing.Point(716, 493);
            this.txtPatientID.MaxLength = 32767;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PasswordChar = '\0';
            this.txtPatientID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatientID.SelectedText = "";
            this.txtPatientID.SelectionLength = 0;
            this.txtPatientID.SelectionStart = 0;
            this.txtPatientID.ShortcutsEnabled = true;
            this.txtPatientID.Size = new System.Drawing.Size(353, 23);
            this.txtPatientID.TabIndex = 13;
            this.txtPatientID.Text = "Patient ID";
            this.txtPatientID.UseSelectable = true;
            this.txtPatientID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatientID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFullname
            // 
            // 
            // 
            // 
            this.txtFullname.CustomButton.Image = null;
            this.txtFullname.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.txtFullname.CustomButton.Name = "";
            this.txtFullname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFullname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFullname.CustomButton.TabIndex = 1;
            this.txtFullname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFullname.CustomButton.UseSelectable = true;
            this.txtFullname.CustomButton.Visible = false;
            this.txtFullname.Enabled = false;
            this.txtFullname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFullname.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtFullname.Lines = new string[0];
            this.txtFullname.Location = new System.Drawing.Point(716, 522);
            this.txtFullname.MaxLength = 32767;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.PasswordChar = '\0';
            this.txtFullname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullname.SelectedText = "";
            this.txtFullname.SelectionLength = 0;
            this.txtFullname.SelectionStart = 0;
            this.txtFullname.ShortcutsEnabled = true;
            this.txtFullname.Size = new System.Drawing.Size(353, 23);
            this.txtFullname.TabIndex = 15;
            this.txtFullname.UseSelectable = true;
            this.txtFullname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 652);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lsvTransaction);
            this.Controls.Add(this.btnMedicalSupply);
            this.Controls.Add(this.btnMedicine);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.lsvProduct);
            this.Name = "POS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lsvProduct;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnMedicine;
        private MetroFramework.Controls.MetroButton btnMedicalSupply;
        private System.Windows.Forms.ListView lsvTransaction;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroTextBox txtPayment;
        private MetroFramework.Controls.MetroTextBox txtChange;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txtPatientID;
        private MetroFramework.Controls.MetroTextBox txtFullname;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}