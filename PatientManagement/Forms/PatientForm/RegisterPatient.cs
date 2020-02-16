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

        List<string> allergies = new List<string>();
        List<string> diagnoses = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            if(!isAllergyExist())
            {
                allergies.Add(txtAllergies.Text);
                cmbAllergies.Items.Add(txtAllergies.Text);
            }

        }

        private bool isAllergyExist()
        {
            foreach(string allergy in allergies)
            {
                if (string.Equals(allergy, txtAllergies.Text)) return true;
            }

            return false;
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
                isRegistered = 0

            };

            Classes.PatientHelper.register(patient);
            saveMedicalRecords(patient.id);
        }

        private void saveMedicalRecords(string patientID)
        {
            foreach(string allergy in allergies)
            {
                Classes.MedicalRecord medicalRecord = new Classes.MedicalRecord()
                {
                    pin = patientID,
                    details = allergy
                };

                Classes.MedicalRecordHelper.saveMedicalRecord(medicalRecord);
            }

            foreach(string diagnose in diagnoses)
            {
                Classes.MedicalRecord medicalRecord = new Classes.MedicalRecord()
                {
                    pin = patientID,
                    details = diagnose
                };

                Classes.MedicalRecordHelper.saveMedicalRecord(medicalRecord);
            }
        }
    }
}
