namespace PatientManagement.Forms.PatientForm
{
    partial class PatientSummaryReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.AM7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AM11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PM3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PM7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AM7,
            this.AM11,
            this.PM3,
            this.PM7});
            this.dataGridView1.Location = new System.Drawing.Point(23, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(182, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "7AM",
            "11AM",
            "3PM",
            "7PM"});
            this.metroComboBox1.Location = new System.Drawing.Point(23, 466);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(153, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            // 
            // AM7
            // 
            this.AM7.HeaderText = "7AM";
            this.AM7.Name = "AM7";
            // 
            // AM11
            // 
            this.AM11.HeaderText = "11AM";
            this.AM11.Name = "AM11";
            // 
            // PM3
            // 
            this.PM3.HeaderText = "3PM";
            this.PM3.Name = "PM3";
            // 
            // PM7
            // 
            this.PM7.HeaderText = "7PM";
            this.PM7.Name = "PM7";
            // 
            // PatientSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 534);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PatientSummaryReport";
            this.Text = "Patient Summary Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AM7;
        private System.Windows.Forms.DataGridViewTextBoxColumn AM11;
        private System.Windows.Forms.DataGridViewTextBoxColumn PM3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PM7;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}