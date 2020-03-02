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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Classes.CheckupHelper.SaveCheckUP(txtPatientID.Text, txtBP.Text, txtTemperature.Text, txtPulseRate.Text, txtTimeArrived.Text,txtCC.Text,0,"","",0,txtGCS.Text, txtRR.Text, txtO2Sat.Text))
            {
                MessageBox.Show("Successfully added");
            }
            else
            {
                MessageBox.Show("Error added");
            }
        }

        private void Initialize()
        {
            txtFirstname.Text = patient.firstname;
            txtMiddlename.Text = patient.middlename;
            txtLastname.Text = patient.lastname;
            txtContact.Text = patient.contact;
            txtEmergency.Text = patient.emergency_contact;
            txtBirthdate.Text = patient.birthdate.ToShortDateString();
            txtPatientID.Text = patient.id;
        }
    }
}
