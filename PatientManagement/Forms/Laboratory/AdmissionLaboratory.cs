using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.Laboratory
{
    public partial class AdmissionLaboratory : Form
    {
        Classes.Admission currentAdmission = null;
        public AdmissionLaboratory(Classes.Admission admission)
        {
            InitializeComponent();
            currentAdmission = admission;
            SettingUp();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Classes.LaboratoryRequest request = new Classes.LaboratoryRequest()
            {
                id = 0,
                result = "",
                doctorID = currentAdmission.doctorID,
                type = "admission",
                typeID = currentAdmission.id,
                status = "Pending",
                urgency = GetUrgency(),
                isPaid = "Pending",
                patient = new Classes.Patient
                {
                    id = currentAdmission.patient.id
                }

            };

            int labID = Classes.LaboratoryRequestHelper.SaveLaboratoryRequest(request);


            SaveLaboratoryTypes(labID);
            MessageBox.Show("Request have been sent");
        }
        private void SettingUp()
        {
            txtName.Text = currentAdmission.patient.firstname + " " + currentAdmission.patient.middlename + " " + currentAdmission.patient.lastname;
            txtAddress.Text = currentAdmission.patient.address;
            txtGender.Text = currentAdmission.patient.gender.ToString();
            txtDateOfBirth.Text = currentAdmission.patient.birthdate.ToShortDateString();
            txtContact.Text = currentAdmission.patient.contact;
            txtRName.Text = "Dr. " + currentAdmission.doctor.firstname + " " + " " + currentAdmission.doctor.lastname;
            txtROrg.Text = "In Patient Department";
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
                if (c.Checked == true)
                {
                    Classes.LaboratoryRequestHelper.SaveLaboratoryType(new Classes.TestType()
                    {
                        labRequestID = labID,
                        name = c.Text
                    });
                }
            }



        }
    }
}
