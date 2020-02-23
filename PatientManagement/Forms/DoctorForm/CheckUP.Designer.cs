namespace PatientManagement.Forms.DoctorForm
{
    partial class CheckUP
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsvRecord = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.txtPR = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAssesment = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHrs = new MetroFramework.Controls.MetroTextBox();
            this.lsvMedicine = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManagement = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Admission Request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(930, 591);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Discharge";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1143, 522);
            this.metroTabControl1.TabIndex = 9;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1135, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patient Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsvRecord);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(61, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1071, 286);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medical Records";
            // 
            // lsvRecord
            // 
            this.lsvRecord.HideSelection = false;
            this.lsvRecord.Location = new System.Drawing.Point(7, 32);
            this.lsvRecord.Name = "lsvRecord";
            this.lsvRecord.Size = new System.Drawing.Size(1058, 235);
            this.lsvRecord.TabIndex = 0;
            this.lsvRecord.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBP);
            this.groupBox2.Controls.Add(this.txtPR);
            this.groupBox2.Controls.Add(this.txtTemp);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(598, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 194);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vital Sign";
            // 
            // txtBP
            // 
            this.txtBP.Enabled = false;
            this.txtBP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBP.Location = new System.Drawing.Point(6, 31);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(253, 29);
            this.txtBP.TabIndex = 0;
            this.txtBP.Text = "Blood Pressure";
            // 
            // txtPR
            // 
            this.txtPR.Enabled = false;
            this.txtPR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPR.Location = new System.Drawing.Point(5, 63);
            this.txtPR.Name = "txtPR";
            this.txtPR.Size = new System.Drawing.Size(253, 29);
            this.txtPR.TabIndex = 1;
            this.txtPR.Text = "Pulse Rate";
            // 
            // txtTemp
            // 
            this.txtTemp.Enabled = false;
            this.txtTemp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(5, 95);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(253, 29);
            this.txtTemp.TabIndex = 2;
            this.txtTemp.Text = "Temperature";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFullname);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // txtFullname
            // 
            this.txtFullname.Enabled = false;
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(6, 31);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(253, 29);
            this.txtFullname.TabIndex = 0;
            this.txtFullname.Text = "Fullname";
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(5, 63);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(253, 29);
            this.txtGender.TabIndex = 1;
            this.txtGender.Text = "Gender";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(5, 95);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(253, 29);
            this.txtAge.TabIndex = 2;
            this.txtAge.Text = "Age";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1135, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medical Prescription";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtManagement);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtAssesment);
            this.panel2.Location = new System.Drawing.Point(584, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 463);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assesment";
            // 
            // txtAssesment
            // 
            // 
            // 
            // 
            this.txtAssesment.CustomButton.Image = null;
            this.txtAssesment.CustomButton.Location = new System.Drawing.Point(354, 2);
            this.txtAssesment.CustomButton.Name = "";
            this.txtAssesment.CustomButton.Size = new System.Drawing.Size(107, 107);
            this.txtAssesment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAssesment.CustomButton.TabIndex = 1;
            this.txtAssesment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAssesment.CustomButton.UseSelectable = true;
            this.txtAssesment.CustomButton.Visible = false;
            this.txtAssesment.Lines = new string[0];
            this.txtAssesment.Location = new System.Drawing.Point(20, 64);
            this.txtAssesment.MaxLength = 32767;
            this.txtAssesment.Multiline = true;
            this.txtAssesment.Name = "txtAssesment";
            this.txtAssesment.PasswordChar = '\0';
            this.txtAssesment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAssesment.SelectedText = "";
            this.txtAssesment.SelectionLength = 0;
            this.txtAssesment.SelectionStart = 0;
            this.txtAssesment.ShortcutsEnabled = true;
            this.txtAssesment.Size = new System.Drawing.Size(464, 112);
            this.txtAssesment.TabIndex = 0;
            this.txtAssesment.UseSelectable = true;
            this.txtAssesment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAssesment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtHrs);
            this.panel1.Controls.Add(this.lsvMedicine);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cmbMedicine);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 463);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Drugs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Time(hr)";
            // 
            // txtHrs
            // 
            // 
            // 
            // 
            this.txtHrs.CustomButton.Image = null;
            this.txtHrs.CustomButton.Location = new System.Drawing.Point(469, 1);
            this.txtHrs.CustomButton.Name = "";
            this.txtHrs.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHrs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHrs.CustomButton.TabIndex = 1;
            this.txtHrs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHrs.CustomButton.UseSelectable = true;
            this.txtHrs.CustomButton.Visible = false;
            this.txtHrs.Lines = new string[] {
        "0"};
            this.txtHrs.Location = new System.Drawing.Point(11, 92);
            this.txtHrs.MaxLength = 32767;
            this.txtHrs.Name = "txtHrs";
            this.txtHrs.PasswordChar = '\0';
            this.txtHrs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHrs.SelectedText = "";
            this.txtHrs.SelectionLength = 0;
            this.txtHrs.SelectionStart = 0;
            this.txtHrs.ShortcutsEnabled = true;
            this.txtHrs.Size = new System.Drawing.Size(491, 23);
            this.txtHrs.TabIndex = 14;
            this.txtHrs.Text = "0";
            this.txtHrs.UseSelectable = true;
            this.txtHrs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHrs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHrs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHrs_KeyPress);
            // 
            // lsvMedicine
            // 
            this.lsvMedicine.HideSelection = false;
            this.lsvMedicine.Location = new System.Drawing.Point(12, 216);
            this.lsvMedicine.Name = "lsvMedicine";
            this.lsvMedicine.Size = new System.Drawing.Size(491, 206);
            this.lsvMedicine.TabIndex = 13;
            this.lsvMedicine.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(491, 46);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add to Prescription";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(12, 33);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(491, 29);
            this.cmbMedicine.TabIndex = 10;
            this.cmbMedicine.Text = "Drugs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Management";
            // 
            // txtManagement
            // 
            // 
            // 
            // 
            this.txtManagement.CustomButton.Image = null;
            this.txtManagement.CustomButton.Location = new System.Drawing.Point(354, 2);
            this.txtManagement.CustomButton.Name = "";
            this.txtManagement.CustomButton.Size = new System.Drawing.Size(107, 107);
            this.txtManagement.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtManagement.CustomButton.TabIndex = 1;
            this.txtManagement.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtManagement.CustomButton.UseSelectable = true;
            this.txtManagement.CustomButton.Visible = false;
            this.txtManagement.Lines = new string[0];
            this.txtManagement.Location = new System.Drawing.Point(20, 244);
            this.txtManagement.MaxLength = 32767;
            this.txtManagement.Multiline = true;
            this.txtManagement.Name = "txtManagement";
            this.txtManagement.PasswordChar = '\0';
            this.txtManagement.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManagement.SelectedText = "";
            this.txtManagement.SelectionLength = 0;
            this.txtManagement.SelectionStart = 0;
            this.txtManagement.ShortcutsEnabled = true;
            this.txtManagement.Size = new System.Drawing.Size(464, 112);
            this.txtManagement.TabIndex = 2;
            this.txtManagement.UseSelectable = true;
            this.txtManagement.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtManagement.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CheckUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 647);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CheckUP";
            this.Text = "CheckUP";
            this.Load += new System.EventHandler(this.CheckUP_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lsvRecord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.TextBox txtPR;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtAssesment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvMedicine;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private MetroFramework.Controls.MetroTextBox txtHrs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtManagement;
    }
}