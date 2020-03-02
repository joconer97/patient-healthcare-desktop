using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.DoctorForm
{
    public partial class AdmissionList : MetroFramework.Forms.MetroForm
    {
        public AdmissionList()
        {
            InitializeComponent();
            InitListView();
            PopulateListView();
        }

        private void InitListView()
        {
            lsvAdmission.Columns.Add("BED #", 200);
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
            List<Classes.Admission> admissions = Classes.AdmissionHelper.Admissions();
            ListViewItem item;

            foreach(Classes.Admission admission in admissions)
            {
                if (admission.isAdmitted == 0) continue;

                item = lsvAdmission.Items.Add(admission.bedNo.ToString());
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
            int si = 0;

            try
            {
                si = lsvAdmission.SelectedItems[0].Index;
            }
            catch (Exception)
            {

                throw;
            }

            new Forms.DoctorForm.Admission().ShowDialog();
        }
    }
}
