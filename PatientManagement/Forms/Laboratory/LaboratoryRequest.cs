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

namespace PatientManagement.Forms.Laboratory
{
    public partial class LaboratoryRequest : Form
    {
        User currentUser = null;
        Checkup currentCheckup = null;
        public LaboratoryRequest(User user,Checkup checkup)
        {
            InitializeComponent();
            currentCheckup = checkup;
            currentUser = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SettingUp()
        {
            txtName.Text = currentCheckup.patient.firstname + " " + currentCheckup.patient.middlename + " " + currentCheckup.patient.lastname;
            txtAddress.Text = currentCheckup.patient.address;
            txtGender.Text = currentCheckup.patient.gender.ToString();
            txtContact.Text = currentCheckup.patient.contact;
            txtDateOfBirth.Text = currentCheckup.patient.birthdate.ToShortDateString();

            txtRName.Text = "Dr. " + currentUser.firstname + " " + " " + currentUser.lastname;
            txtROrg.Text = "Out Patient Department";
        }
    }
}
