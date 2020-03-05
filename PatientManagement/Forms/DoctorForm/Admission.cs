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
    public partial class Admission : MetroFramework.Forms.MetroForm
    {
        Classes.Admission admission = null;
        List<string> medicines = new List<string>();
        List<Classes.Prescription> prescriptions = new List<Classes.Prescription>();
        List<Classes.Procedure> procedures = new List<Classes.Procedure>();
        public Admission(Classes.Admission admission)
        {
            InitializeComponent();
            this.admission = admission;
            SettingUp();
            json();
            InitListView2();
            InitListView3();
        }

        public void SettingUp()
        {
            txtFname.Text = admission.patient.firstname;
            txtMname.Text = admission.patient.middlename;
            txtLname.Text = admission.patient.lastname;
            txtAge.Text = (DateTime.Now.Year - admission.patient.birthdate.Year).ToString();
            txtGender.Text = admission.patient.gender.ToString();
            txtReligion.Text = admission.patient.religion;
            txtBirthdate.Text = admission.patient.birthdate.ToShortDateString();
            txtAdmissionDate.Text = admission.admittedDate.ToShortDateString();
            txtAdmissionTime.Text = admission.admittedTime.ToString();
            txtContact.Text = admission.patient.contact;
            txtBP.Text = admission.blood_pressure;
            txtCC.Text = admission.cc;
            txtTemp.Text = admission.temperature;
            txtRR.Text = admission.respiratory_rate;
            txtPR.Text = admission.pulse_rate;
            txtGCS.Text = admission.gcs;
            txtO2Sat.Text = admission.o2sat;
            txtOccupation.Text = admission.patient.occupation;
            txtCitizenship.Text = admission.patient.citizenship;

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
        private void PopulateList2()
        {
            lsvMedicine.Items.Clear();
            ListViewItem item;
            foreach (var r in prescriptions)
            {
                item = lsvMedicine.Items.Add(r.medicine);
                item.SubItems.Add(r.hrs);
            }
        }
        private void PopulateList3()
        {
            lsvProcedure.Items.Clear();
            ListViewItem item;
            foreach (var r in procedures)
            {
                item = lsvProcedure.Items.Add(r.procedureNo.ToString());
                item.SubItems.Add(r.procedureName);
            }
        }

        //Add Prescription
        private void metroButton1_Click(object sender, EventArgs e)
        {
            procedures.Add(new Classes.Procedure()
            {
                admissionID = admission.id,
                procedureNo = procedures.Count + 1,
                procedureName = txtProcedure.Text
            });

            txtProcedure.Text = "";
            PopulateList3();
        }

        private bool isExist()
        {
            foreach (Classes.Prescription prescription in prescriptions)
            {
                if (prescription.medicine == cmbMedicine.SelectedItem.ToString())
                    return true;
            }

            return false;
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

        private void InitListView3()
        {
            lsvProcedure.Columns.Add("#", 200);
            lsvProcedure.Columns.Add("Procedure Name", 200);

            lsvProcedure.View = View.Details;
            lsvProcedure.GridLines = true;
            lsvProcedure.FullRowSelect = true;
            lsvProcedure.HideSelection = false;
            lsvProcedure.MultiSelect = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isExist()) return;

            if (txtHrs.Text != "0")
                prescriptions.Add(new Classes.Prescription()
                {
                    medicine = cmbMedicine.SelectedItem.ToString(),
                    hrs = txtHrs.Text
                });
            PopulateList2();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach(var p in procedures)
            {
                Classes.ProcedureHelper.SaveProcedure(p);
            }

            foreach(var m in prescriptions)
            {
                Classes.PrescriptionHelper.savePrescription(m,admission.id,"admission");
            }

            MessageBox.Show("SAVED!");
        }
    }
}
