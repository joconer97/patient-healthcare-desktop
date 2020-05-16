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
    public partial class UpdatePatient : MetroFramework.Forms.MetroForm
    {
        Patient currentPatient = null;
        public UpdatePatient(Patient patient)
        {
            InitializeComponent();
            this.currentPatient = patient;
            SetupPatientInfo();
        }

        private void SetupPatientInfo()
        {
            var address = currentPatient.address.Split('/');
            txtFirstname.Text = currentPatient.firstname;
            txtMiddleName.Text = currentPatient.middlename;
            txtLastname.Text = currentPatient.lastname;
            txtCitizenship.Text = currentPatient.citizenship;
            txtBirthplace.Text = currentPatient.birthplace;
            dtpBirthdate.Text = currentPatient.birthdate.ToShortDateString();
            txtBaranggay.Text = address[1];
            txtStreet.Text = address[0];
            txtCity.Text = address[2];
            txtEmergencyContact.Text = currentPatient.emergency_contact;
            cmbGender.Text = currentPatient.gender.ToString();
            txtOccupation.Text = currentPatient.occupation;
            txtContact.Text = currentPatient.contact;
            txtReligion.Text = currentPatient.religion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Firebase.Firebase firebase = new Firebase.Firebase();

            Patient patient = new Patient()
            {
                id = currentPatient.id,
                firstname = txtFirstname.Text,
                middlename = txtMiddleName.Text,
                lastname = txtLastname.Text,
                gender = char.Parse(cmbGender.SelectedItem.ToString()),
                birthdate = dtpBirthdate.Value,
                birthplace = txtBirthplace.Text,
                contact = txtContact.Text,
                emergency_contact = txtEmergencyContact.Text,
                address = txtStreet.Text + "/" + txtBaranggay.Text + "/" + txtCity.Text,
                occupation = txtOccupation.Text,
                citizenship = txtCitizenship.Text,
                religion = txtReligion.Text,
            };

            PatientHelper.Update(patient);
            firebase.UpdatePatientMember(patient);
           

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
