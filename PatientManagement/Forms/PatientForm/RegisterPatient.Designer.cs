namespace PatientManagement.Forms.PatientForm
{
    partial class RegisterPatient
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
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtEmergencyContact = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.cmbAllergies = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(21, 30);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(365, 32);
            this.txtFirstname.TabIndex = 0;
            this.txtFirstname.Text = "Firstname";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(21, 74);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(365, 32);
            this.txtMiddleName.TabIndex = 1;
            this.txtMiddleName.Text = "Middle Name";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(21, 128);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(365, 32);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.Text = "Lastname";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(21, 174);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(365, 32);
            this.txtContact.TabIndex = 3;
            this.txtContact.Text = "Contact#";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(719, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGender.Location = new System.Drawing.Point(21, 232);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(365, 33);
            this.cmbGender.TabIndex = 5;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Location = new System.Drawing.Point(21, 278);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(365, 32);
            this.dtpBirthdate.TabIndex = 6;
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencyContact.Location = new System.Drawing.Point(21, 329);
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new System.Drawing.Size(365, 32);
            this.txtEmergencyContact.TabIndex = 7;
            this.txtEmergencyContact.Text = "Emergency Contact";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(324, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Allergies";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAllergies
            // 
            this.txtAllergies.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergies.Location = new System.Drawing.Point(5, 28);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(303, 32);
            this.txtAllergies.TabIndex = 9;
            this.txtAllergies.Text = "Allergies";
            // 
            // cmbAllergies
            // 
            this.cmbAllergies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllergies.FormattingEnabled = true;
            this.cmbAllergies.Location = new System.Drawing.Point(5, 67);
            this.cmbAllergies.Name = "cmbAllergies";
            this.cmbAllergies.Size = new System.Drawing.Size(303, 21);
            this.cmbAllergies.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(5, 165);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(303, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(5, 126);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(303, 32);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "Major Diagonoses";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(324, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Diagnoses";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Patient Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Controls.Add(this.txtMiddleName);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.dtpBirthdate);
            this.panel1.Controls.Add(this.txtEmergencyContact);
            this.panel1.Location = new System.Drawing.Point(36, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 423);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAllergies);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.cmbAllergies);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Location = new System.Drawing.Point(449, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 423);
            this.panel2.TabIndex = 16;
            // 
            // RegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "RegisterPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterPatient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox txtEmergencyContact;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.ComboBox cmbAllergies;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}