using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.NurseForm
{
    public partial class InpatientAdmissionList : Form
    {
        public InpatientAdmissionList()
        {
            InitializeComponent();
            InitList();
            PopulateListView();
        }

        List<Classes.Admission> admissions = null;

        private void InitList()
        {
            lsvAdmission.Columns.Add("ROOM # & BED #", 200);
            lsvAdmission.Columns.Add("PIN", 200);
            lsvAdmission.Columns.Add("Fullname", 280);
            lsvAdmission.Columns.Add("Sex", 30);
            lsvAdmission.Columns.Add("Illness", 200);
            lsvAdmission.Columns.Add("Admission Date", 200);
            lsvAdmission.Columns.Add("Admission Time", 200);


            lsvAdmission.View = View.Details;
            lsvAdmission.GridLines = true;
            lsvAdmission.FullRowSelect = true;
            lsvAdmission.HideSelection = false;
            lsvAdmission.MultiSelect = false;
        }
        private void PopulateListView()
        {
            admissions = Classes.Admission.AdmissionRequest(Classes.AdmissionHelper.Admissions(), 1);
            ListViewItem item;

            foreach (Classes.Admission admission in admissions)
            {
                if (admission.isAdmitted == 0) continue;

                item = lsvAdmission.Items.Add("Room " + admission.roomNo.ToString() + " Bed " + admission.bedNo.ToString());
                item.SubItems.Add(admission.patient.id);
                item.SubItems.Add(admission.patient.firstname + " " + admission.patient.middlename + " " + admission.patient.lastname);
                item.SubItems.Add(admission.patient.gender.ToString());
                item.SubItems.Add("Dengue");
                item.SubItems.Add(admission.admittedDate.ToShortDateString());
                item.SubItems.Add(admission.admittedTime.ToString());
            }

        }

        private void lsvAdmission_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                index = lsvAdmission.SelectedItems[0].Index;
            }
            catch (Exception)
            {

                throw;
            }

            new Forms.PatientForm.Admission(admissions[index]).ShowDialog();
        }
    }
}
