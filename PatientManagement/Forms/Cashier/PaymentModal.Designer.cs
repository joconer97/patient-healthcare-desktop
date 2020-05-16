namespace PatientManagement.Forms.Cashier
{
    partial class PaymentModal
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
            this.txtPayment = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtChange = new MetroFramework.Controls.MetroTextBox();
            this.rdbCash = new System.Windows.Forms.RadioButton();
            this.rdbBill = new System.Windows.Forms.RadioButton();
            this.panelCash = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPatientID2 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.txtRequester = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panelCash.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPayment
            // 
            // 
            // 
            // 
            this.txtPayment.CustomButton.Image = null;
            this.txtPayment.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.txtPayment.CustomButton.Name = "";
            this.txtPayment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPayment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPayment.CustomButton.TabIndex = 1;
            this.txtPayment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPayment.CustomButton.UseSelectable = true;
            this.txtPayment.CustomButton.Visible = false;
            this.txtPayment.Lines = new string[] {
        " "};
            this.txtPayment.Location = new System.Drawing.Point(4, 32);
            this.txtPayment.MaxLength = 32767;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.PasswordChar = '\0';
            this.txtPayment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPayment.SelectedText = "";
            this.txtPayment.SelectionLength = 0;
            this.txtPayment.SelectionStart = 0;
            this.txtPayment.ShortcutsEnabled = true;
            this.txtPayment.Size = new System.Drawing.Size(311, 23);
            this.txtPayment.TabIndex = 1;
            this.txtPayment.Text = " ";
            this.txtPayment.UseSelectable = true;
            this.txtPayment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPayment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPayment.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            this.txtPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox2_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Payment";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(4, 112);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(311, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Done";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 58);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Change";
            // 
            // txtChange
            // 
            // 
            // 
            // 
            this.txtChange.CustomButton.Image = null;
            this.txtChange.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.txtChange.CustomButton.Name = "";
            this.txtChange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChange.CustomButton.TabIndex = 1;
            this.txtChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChange.CustomButton.UseSelectable = true;
            this.txtChange.CustomButton.Visible = false;
            this.txtChange.Lines = new string[] {
        " "};
            this.txtChange.Location = new System.Drawing.Point(4, 80);
            this.txtChange.MaxLength = 32767;
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChange.SelectedText = "";
            this.txtChange.SelectionLength = 0;
            this.txtChange.SelectionStart = 0;
            this.txtChange.ShortcutsEnabled = true;
            this.txtChange.Size = new System.Drawing.Size(311, 23);
            this.txtChange.TabIndex = 6;
            this.txtChange.Text = " ";
            this.txtChange.UseSelectable = true;
            this.txtChange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rdbCash
            // 
            this.rdbCash.AutoSize = true;
            this.rdbCash.Checked = true;
            this.rdbCash.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCash.Location = new System.Drawing.Point(42, 258);
            this.rdbCash.Name = "rdbCash";
            this.rdbCash.Size = new System.Drawing.Size(63, 23);
            this.rdbCash.TabIndex = 8;
            this.rdbCash.TabStop = true;
            this.rdbCash.Text = "Cash";
            this.rdbCash.UseVisualStyleBackColor = true;
            this.rdbCash.CheckedChanged += new System.EventHandler(this.rdbCash_CheckedChanged);
            // 
            // rdbBill
            // 
            this.rdbBill.AutoSize = true;
            this.rdbBill.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBill.Location = new System.Drawing.Point(42, 287);
            this.rdbBill.Name = "rdbBill";
            this.rdbBill.Size = new System.Drawing.Size(51, 23);
            this.rdbBill.TabIndex = 9;
            this.rdbBill.Text = "Bill";
            this.rdbBill.UseVisualStyleBackColor = true;
            this.rdbBill.CheckedChanged += new System.EventHandler(this.rdbBill_CheckedChanged);
            // 
            // panelCash
            // 
            this.panelCash.Controls.Add(this.metroLabel2);
            this.panelCash.Controls.Add(this.txtPayment);
            this.panelCash.Controls.Add(this.metroButton1);
            this.panelCash.Controls.Add(this.metroLabel3);
            this.panelCash.Controls.Add(this.txtChange);
            this.panelCash.Location = new System.Drawing.Point(42, 369);
            this.panelCash.Name = "panelCash";
            this.panelCash.Size = new System.Drawing.Size(325, 156);
            this.panelCash.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.txtPatientID2);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Location = new System.Drawing.Point(42, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 156);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(138, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Patient Identification #";
            // 
            // txtPatientID2
            // 
            // 
            // 
            // 
            this.txtPatientID2.CustomButton.Image = null;
            this.txtPatientID2.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.txtPatientID2.CustomButton.Name = "";
            this.txtPatientID2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPatientID2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatientID2.CustomButton.TabIndex = 1;
            this.txtPatientID2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatientID2.CustomButton.UseSelectable = true;
            this.txtPatientID2.CustomButton.Visible = false;
            this.txtPatientID2.Enabled = false;
            this.txtPatientID2.Lines = new string[] {
        " "};
            this.txtPatientID2.Location = new System.Drawing.Point(4, 32);
            this.txtPatientID2.MaxLength = 32767;
            this.txtPatientID2.Name = "txtPatientID2";
            this.txtPatientID2.PasswordChar = '\0';
            this.txtPatientID2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatientID2.SelectedText = "";
            this.txtPatientID2.SelectionLength = 0;
            this.txtPatientID2.SelectionStart = 0;
            this.txtPatientID2.ShortcutsEnabled = true;
            this.txtPatientID2.Size = new System.Drawing.Size(311, 23);
            this.txtPatientID2.TabIndex = 1;
            this.txtPatientID2.Text = " ";
            this.txtPatientID2.UseSelectable = true;
            this.txtPatientID2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatientID2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(4, 109);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(311, 23);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Done";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txtPatient
            // 
            this.txtPatient.Enabled = false;
            this.txtPatient.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatient.Location = new System.Drawing.Point(135, 75);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(222, 27);
            this.txtPatient.TabIndex = 12;
            // 
            // txtRequester
            // 
            this.txtRequester.Enabled = false;
            this.txtRequester.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequester.Location = new System.Drawing.Point(135, 113);
            this.txtRequester.Name = "txtRequester";
            this.txtRequester.Size = new System.Drawing.Size(222, 27);
            this.txtRequester.TabIndex = 13;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Enabled = false;
            this.txtPatientID.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientID.Location = new System.Drawing.Point(135, 151);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(222, 27);
            this.txtPatientID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Requester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Patient ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(135, 184);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(222, 27);
            this.txtPrice.TabIndex = 18;
            // 
            // PaymentModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 548);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.txtRequester);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCash);
            this.Controls.Add(this.rdbBill);
            this.Controls.Add(this.rdbCash);
            this.Name = "PaymentModal";
            this.Text = "Laboratoty";
            this.panelCash.ResumeLayout(false);
            this.panelCash.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtPayment;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtChange;
        private System.Windows.Forms.RadioButton rdbCash;
        private System.Windows.Forms.RadioButton rdbBill;
        private System.Windows.Forms.Panel panelCash;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPatientID2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.TextBox txtRequester;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
    }
}