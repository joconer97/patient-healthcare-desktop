using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.DoctorForm
{
    public partial class DeceasedReport : MetroFramework.Forms.MetroForm
    {
        int admissionID = 0;
        public DeceasedReport(int admissionID)
        {
            InitializeComponent();
            this.admissionID = admissionID;
        }

        private void DeceasedReport_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            if (numericUpDown1.Value >= 23)
            {
                numericUpDown1.Value = 23;
                return;
            }
        }

        private void numericUpDown2_KeyUp(object sender, KeyEventArgs e)
        {
            if(numericUpDown1.Value == 23)
            {
                if(numericUpDown2.Value >= 60)
                {
                    numericUpDown2.Value = 59;
                    return;
                }
            }

            if(numericUpDown2.Value >= 60)
            {
                numericUpDown2.Value = 60;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtReport.Text == "")
            {
                MessageBox.Show("Please fill up the death report");
                return;
            }

            var isConfirmed = MessageBox.Show("Please check all information before you saved it, if you already check it click OK", "Confirmation", MessageBoxButtons.OKCancel);

            if (isConfirmed != DialogResult.OK)
                return;

            Classes.DeceasedHelper.SaveDecesedReport(new Classes.Deceased()
            {
                admissionID = this.admissionID,
                report = txtReport.Text,
                timeOfDeath = new TimeSpan((int)numericUpDown1.Value, (int)numericUpDown2.Value, 0),
                dateOfDeath = DateTime.Now

            });

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }
    }
}
