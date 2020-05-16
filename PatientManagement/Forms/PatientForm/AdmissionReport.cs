using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManagement.Classes;

namespace PatientManagement.Forms.PatientForm
{
    public partial class AdmissionReport : MetroFramework.Forms.MetroForm
    {
        Classes.Admission admission = null;
        Classes.User currentUser = null;
        public AdmissionReport(Classes.Admission admission,Classes.User user)
        {
            InitializeComponent();
            currentUser = user;
            this.admission = admission;
        }

        private void AdmissionReport_Load(object sender, EventArgs e)
        {
            txtPatientID.Text = admission.patient.id;
            txtFirstname.Text = admission.patient.firstname + " " + admission.patient.middlename + " " + admission.patient.lastname;
            txtAge.Text = (DateTime.Now.Year - admission.patient.birthdate.Year).ToString();
            txtGender.Text = admission.patient.gender.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortDateString() + " | "+ DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!ValidateInput())
            {
                return;
            }
            Classes.ReportHelper.SaveReport(new Report()
            {
                admissionID = this.admission.id,
                employeeID = this.currentUser.id,
                bp = txtBP.Text,
                pr = txtPulseRate.Text,
                temperature = txtTemperature.Text,
                gcs = txtGCS.Text,
                notes = txtNotes.Text,
                rr = txtRespiratoryRate.Text,
                o2sat = txtO2Sat.Text,
                date = DateTime.Now
            });

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private bool ValidateInput()
        {
            bool isValid = true;
            string message = "Please fill the following";

            if (txtBP.Text == "")
            {
                message += " \n ●Blood Pressure";
                isValid = false;
            }
            if (txtGCS.Text == "")
            {
                message += " \n ●GCS";
                isValid = false;
            }
            if(txtNotes.Text == "")
            {
                message += " \n ●Notes";
                isValid = false;
            }
            if(txtO2Sat.Text == "")
            {
                message += " \n ●O2SAT";
                isValid = false;
            }
            if(txtPulseRate.Text == "")
            {
                message += " \n ●Pulse Rate";
                isValid = false;
            }
            if(txtRespiratoryRate.Text == "")
            {
                message += " \n ●Respiratory Rate";
                isValid = false;
            }

            if(!isValid)
            {
                MessageBox.Show(message);
            }

            return isValid;
        }
    }
}
