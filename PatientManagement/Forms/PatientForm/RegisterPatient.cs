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
            Classes.Patient patient = new Classes.Patient
            {
                id = DateTime.Now.ToString("ssmmMMddyyyy"),
                firstname = txtFirstname.Text,
                middlename = txtMiddleName.Text,
                lastname = txtLastname.Text,
                gender = char.Parse(cmbGender.SelectedItem.ToString()),
                birthdate = dtpBirthdate.Value,
                contact = txtContact.Text,
                emergency_contact = txtEmergencyContact.Text,
                address = txtStreet.Text + " " + txtBaranggay.Text + " " + txtCity.Text,
                occupation = txtOccupation.Text,
                citizenship = txtCitizenship.Text,
                religion = txtReligion.Text,
                isRegistered = 0

            };

            Classes.PatientHelper.register(patient);

        }

    }
}
