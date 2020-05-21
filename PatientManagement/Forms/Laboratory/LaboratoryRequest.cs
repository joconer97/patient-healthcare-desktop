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
            SettingUp();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SettingUp()
        {
            txtName.Text = currentCheckup.patient.firstname + " " + currentCheckup.patient.middlename + " " + currentCheckup.patient.lastname;
            txtAddress.Text = currentCheckup.patient.address;
            txtGender.Text = currentCheckup.patient.gender.ToString();
            txtDateOfBirth.Text = currentCheckup.patient.birthdate.ToShortDateString();
            txtContact.Text = currentCheckup.patient.contact;
            txtRName.Text = "Dr. " + currentUser.firstname + " " + " " + currentUser.lastname;
            txtROrg.Text = "Out Patient Department";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(!ValidateLaboratoryTypes())
            {
                MessageBox.Show("Please fill up laboratory types");
                return;
            }

            Classes.LaboratoryRequest request = new Classes.LaboratoryRequest()
            {
                id = 0,
                result = "",
                doctorID = currentUser.id,
                type = "checkup",
                typeID = currentCheckup.id,
                status = "Pending",
                urgency = GetUrgency(),
                isPaid = "Pending",
                patient = new Patient()
                {
                    id = currentCheckup.patient.id
                },
                date = DateTime.Now
            };

           int labID = Classes.LaboratoryRequestHelper.SaveLaboratoryRequest(request);


           SaveLaboratoryTypes(labID);
           MessageBox.Show("Request have been sent");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private string GetUrgency()
        {
            if (radNormal.Checked) return radNormal.Text;
            else return radUrgent.Text;
        }
        private void SaveLaboratoryTypes(int labID)
        {
            List<string> types = new List<string>();
            CheckBox[] checkBox = new CheckBox[8];
            checkBox[0] = checkBox1;
            checkBox[1] = checkBox2;
            checkBox[2] = checkBox3;
            checkBox[3] = checkBox4;
            checkBox[4] = checkBox5;
            checkBox[5] = checkBox5;
            checkBox[6] = checkBox6;
            checkBox[7] = checkBox7;

            foreach (var c in checkBox)
            {
                if(c.Checked == true)
                {
                    Classes.LaboratoryRequestHelper.SaveLaboratoryType(new Classes.TestType()
                    {
                        labRequestID = labID,
                        name = c.Text
                    });
                }
            }

        }

        private bool ValidateLaboratoryTypes()
        {
            CheckBox[] checkBox = new CheckBox[8];
            checkBox[0] = checkBox1;
            checkBox[1] = checkBox2;
            checkBox[2] = checkBox3;
            checkBox[3] = checkBox4;
            checkBox[4] = checkBox5;
            checkBox[5] = checkBox5;
            checkBox[6] = checkBox6;
            checkBox[7] = checkBox7;

            foreach (var c in checkBox)
            {
                if (c.Checked == true)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
