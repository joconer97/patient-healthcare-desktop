using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.Laboratory
{
    public partial class PendingLaboratoryRequest : Form
    {
        Classes.LaboratoryRequest request = null;
        public PendingLaboratoryRequest(Classes.LaboratoryRequest request)
        {
            InitializeComponent();
            this.request = request;
            SettingUpForm();
            TestTypes();
        }

        private void SettingUpForm()
        {
            txtName.Text = request.patient.firstname + " " + request.patient.middlename + " " + request.patient.lastname;
            txtAddress.Text = request.patient.address;
            txtGender.Text = request.patient.gender.ToString();
            txtDateOfBirth.Text = request.patient.birthdate.ToShortDateString();
            txtContact.Text = request.patient.contact;
            txtRName.Text = "Dr. " + request.user.firstname + " " + " " + request.user.lastname;
            txtROrg.Text = "Out Patient Department";

            if (request.urgency == "Urgent") radUrgent.Checked = true;
            else radNormal.Checked = true;
        }

        private void TestTypes()
        {
            List<Classes.TestType> testTypes = Classes.LaboratoryRequestHelper.TestTypeList(request.id);
            

            foreach(var t in testTypes)
            {
                switch(t.name)
                {
                    case "Blood":
                        checkBox1.Checked = true;
                        break;
                    case "Faeces":
                        checkBox2.Checked = true;
                        break;
                    case "Urine":
                        checkBox3.Checked = true;
                        break;
                    case "Sputrum":
                        checkBox4.Checked = true;
                        break;
                    case "Swab":
                        checkBox5.Checked = true;
                        break;
                    case "Fluids":
                        checkBox6.Checked = true;
                        break;
                    case "Tissue":
                        checkBox7.Checked = true;
                        break;
                    case "Cytology":
                        checkBox8.Checked = true;
                        break;
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "PDF Files|*.pdf";
                if(file.ShowDialog() == DialogResult.OK)
                {
                    string workingDirectory = Environment.CurrentDirectory;
                  
                    string path = Directory.GetParent(workingDirectory).Parent.FullName +"/LaboratoryResult/"+ request.id.ToString() + request.patient.firstname + ".pdf";
                    request.result = path;
                    request.status = "Completed";

                    Classes.LaboratoryRequestHelper.SaveLaboratoryRequest(request);
                    File.Delete(path);
                    File.Copy(file.FileName, path);
                    MessageBox.Show("Result have been uploaded");

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            request.status = "In-Progress";
            Classes.LaboratoryRequestHelper.SaveLaboratoryRequest(request);
            MessageBox.Show("Status Updated");
        }
    }
}
