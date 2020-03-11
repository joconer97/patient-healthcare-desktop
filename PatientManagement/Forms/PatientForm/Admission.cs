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
    public partial class Admission : MetroFramework.Forms.MetroForm
    {
        Classes.Admission admission = null;
        public Admission(Classes.Admission admission)
        {
            InitializeComponent();
            this.admission = admission;
            SettingUp();
            InitListView2();
            InitListView3();
            PopulateList();
            PopulateList2();
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
            txtDoctorName.Text = "Dr. " + admission.doctor.firstname + " " + admission.doctor.lastname;
            txtNurseName.Text = "Nurse " + admission.nurse.firstname + " " + admission.nurse.lastname;

        }

        private void InitListView3()
        {
            lsvProcedure.Columns.Add("Procedure #", 200);
            lsvProcedure.Columns.Add("Procedure Name", 200);

            lsvProcedure.View = View.Details;
            lsvProcedure.GridLines = true;
            lsvProcedure.FullRowSelect = true;
            lsvProcedure.HideSelection = false;
            lsvProcedure.MultiSelect = false;
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

        private void PopulateList()
        {
            List<Classes.Prescription> prescriptions = Classes.PrescriptionHelper.ListPrescription(admission.id, "admission");

            ListViewItem item;

            foreach(var p in prescriptions)
            {
                item = lsvMedicine.Items.Add(p.medicine);
                item.SubItems.Add(p.hrs.ToString());
            }
        }

        private void PopulateList2()
        {

            List<Classes.Procedure> procedures = Classes.ProcedureHelper.ListProcedure(admission.id);

            ListViewItem item;

            foreach (var p in procedures)
            {
                item = lsvProcedure.Items.Add(p.procedureNo.ToString());
                item.SubItems.Add(p.procedureName);
            }
        }
    }
}
