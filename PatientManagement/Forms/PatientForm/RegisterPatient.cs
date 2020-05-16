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
    public partial class RegisterPatient : MetroFramework.Forms.MetroForm
    {
        public RegisterPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registerPatient();

        }

        private void registerPatient()
        {
            if(!IsValidInput())
            {
                MessageBox.Show("Please fill-up all input");
                return;
            }

            Classes.Patient patient = new Classes.Patient
            {
                id = DateTime.Now.ToString("ssmmMMddyyyy"),
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
                isRegistered = 0

            };

            Firebase.Firebase firebase = new Firebase.Firebase();
            firebase.InsertPatientMember(patient);
            Classes.PatientHelper.register(patient);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private bool IsValidInput()
        {
            if (txtFirstname.Text == "" || txtMiddleName.Text == "" || txtLastname.Text == "" || cmbGender.SelectedItem == null || txtBirthplace.Text == "" || txtContact.Text == "" || txtEmergencyContact.Text == "" || txtStreet.Text == "" || txtBaranggay.Text == "" || txtCity.Text == "" || txtOccupation.Text == "" || txtCitizenship.Text == "" || txtReligion.Text == "")
            {
                return false;
            }

            return true;
        }

    }
}
