using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.PatientForm
{
    public partial class CheckUP : MetroFramework.Forms.MetroForm
    {
        Classes.Patient patient;
        public CheckUP(Classes.Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            Initialize();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimeArrived.Text = DateTime.Now.ToShortTimeString();
        }
        private bool ValidateInput()
        {
            var data = Classes.CheckupHelper.ListCheckup();

            if(txtCC.Text == "" | txtBP.Text == "" | txtGCS.Text == "" | txtO2Sat.Text == "")
            {
                return false;
            }

            return true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if(!ValidateInput())
            {
                MessageBox.Show("Please fill up the box");
                return;
            }
            int currentID = Classes.CheckupHelper.SaveCheckUP(txtPatientID.Text, txtBP.Text, txtTemperature.Text, txtPulseRate.Text, txtTimeArrived.Text, txtCC.Text, 0, "", "","Pending for Checkup", 0, txtRespiratoryRate.Text, txtGCS.Text, txtO2Sat.Text);

            if (currentID != 0)
            {

                Firebase.Firebase firebase = new Firebase.Firebase();
                Classes.Checkup checkup = new Classes.Checkup()
                {
                    id =  currentID,
                    patientID = patient.id,
                    temperature = txtTemperature.Text,
                    blood_pressure = txtBP.Text,
                    pulse_rate = txtPulseRate.Text,
                    respiratory_rate = txtRespiratoryRate.Text,
                    gcs = txtGCS.Text,
                    o2sat = txtO2Sat.Text,
                    date = DateTime.Now,
                    cc = txtCC.Text,
                    assesment = "",
                    management = "",
                    isTreated = 0,
                    status = "Pending of Checkup"
                };

                firebase.InsertCheckUp(checkup);
                MessageBox.Show("Successfully added");

                this.DialogResult = System.Windows.Forms.DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Error added");
            }
        }

        private void Initialize()
        {
            txtFirstname.Text = patient.firstname + " " + patient.middlename + " " + patient.lastname;
            txtContact.Text = patient.contact;
            txtGender.Text = patient.gender.ToString();
            txtAge.Text = (DateTime.Now.Year - patient.birthdate.Year).ToString();
            txtEmergency.Text = patient.emergency_contact;
            txtBirthdate.Text = patient.birthdate.ToShortDateString();
            txtPatientID.Text = patient.id;
        }
    }
}
