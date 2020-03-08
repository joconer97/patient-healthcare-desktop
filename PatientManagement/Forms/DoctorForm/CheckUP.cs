using Newtonsoft.Json;
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

namespace PatientManagement.Forms.DoctorForm
{
    public partial class CheckUP : MetroFramework.Forms.MetroForm
    {
        List<string> medicines = new List<string>();
        List<Classes.Prescription> prescriptions = new List<Classes.Prescription>();
        int id = 0;
        string cc = "";
        int doctorID = 0;
        Classes.Patient currentPatient;
        Classes.Checkup checkup = null;
        public CheckUP(Classes.Checkup checkup)
        {
            InitializeComponent();
            id = checkup.id;
            doctorID = checkup.user.id;
            this.checkup = checkup;
            currentPatient = checkup.patient;
            txtFullname.Text = checkup.patient.firstname + " " + checkup.patient.lastname;
            txtGender.Text = checkup.patient.gender.ToString();
            txtAge.Text = (DateTime.Now.Year - checkup.patient.birthdate.Year).ToString();
            txtBP.Text = checkup.blood_pressure;
            txtPR.Text = checkup.pulse_rate;
            txto2sat.Text = checkup.o2sat;
            txtrr.Text = checkup.respiratory_rate;
            txtGCS.Text = checkup.gcs;
            cc = checkup.cc;
            txtTemp.Text = checkup.temperature + "°C";
            InitListView();
            InitListView2();
            PopulateList(checkup.patientID);
        }

        private void CheckUP_Load(object sender, EventArgs e)
        {
            json();
        }

        private void json()
        {
            using (StreamReader r = new StreamReader(@"E:\drugs.json"))
            {
                string json = r.ReadToEnd();
                medicines = JsonConvert.DeserializeObject<List<string>>(json);

                cmbMedicine.DataSource = medicines;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isExist()) return;

            if(txtHrs.Text != "0")
            prescriptions.Add(new Classes.Prescription()
            {
                medicine = cmbMedicine.SelectedItem.ToString(),
                hrs = Int32.Parse(txtHrs.Text)
            });
            PopulateList2();

        }

        private bool isExist()
        {
            foreach(Classes.Prescription prescription in prescriptions)
            {
                if (prescription.medicine == cmbMedicine.SelectedItem.ToString())
                    return true;
            }

            return false;
        }
        private void InitListView()
        {
            lsvRecord.Columns.Add("Records", 200);

            lsvRecord.View = View.Details;
            lsvRecord.GridLines = true;
            lsvRecord.FullRowSelect = true;
            lsvRecord.HideSelection = false;
            lsvRecord.MultiSelect = false;
        }
        private void InitListView2()
        {
            lsvMedicine.Columns.Add("Medicine", 200);
            lsvMedicine.Columns.Add("Time (hrs)", 200);

            lsvMedicine.View = View.Details;
            lsvMedicine.GridLines = true;
            lsvMedicine.FullRowSelect = true;
            lsvMedicine.HideSelection = false;
            lsvMedicine.MultiSelect = false;
        }

        private void PopulateList(string patientID)
        {
          
        }

        private void PopulateList2()
        {
            lsvMedicine.Items.Clear();
            ListViewItem item;
            foreach (var r in prescriptions)
            {
                item = lsvMedicine.Items.Add(r.medicine);
                item.SubItems.Add(r.hrs.ToString());
            }
        }

        private void txtHrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Classes.CheckupHelper.SaveCheckUP("", "", "", "", "", "", id, txtAssesment.Text, txtManagement.Text,1,"","","",doctorID))
            {
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Error added");
            }

            foreach (Classes.Prescription prescription in prescriptions)
            {
                Classes.PrescriptionHelper.savePrescription(prescription, id, "checkup");

            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnAdmissionRequest_Click(object sender, EventArgs e)
        {
            Classes.AdmissionHelper.SaveAdmission(new Classes.Admission()
            {
                patient = currentPatient,
                respiratory_rate = txtrr.Text,
                blood_pressure = txtBP.Text,
                pulse_rate = txtPR.Text,
                gcs = txtGCS.Text,
                o2sat = txto2sat.Text,
                temperature = txtTemp.Text,
                cc = this.cc

            });

            if (Classes.CheckupHelper.SaveCheckUP("", "", "", "", "", "", id, txtAssesment.Text, txtManagement.Text, 1))
            {
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Error added");
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnLabRequest_Click(object sender, EventArgs e)
        {
            new Forms.Laboratory.LaboratoryRequest(checkup.user,checkup).ShowDialog();
        }
    }
}
