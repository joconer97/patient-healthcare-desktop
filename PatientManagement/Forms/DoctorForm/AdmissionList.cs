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
        Classes.User currentUser = null;
        public AdmissionList(Classes.User user)
        {
            InitializeComponent();
            currentUser = user;
            InitListView();
            PopulateListView();
            label1.Text = "Dr. " + currentUser.firstname + " " + currentUser.lastname;
        }
        List<Classes.Admission> admissions = null;
        private void InitListView()
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
            admissions = Classes.Admission.AdmissionRequest(Classes.AdmissionHelper.Admissions(),1);
            ListViewItem item;

            foreach(Classes.Admission admission in admissions)
            {
                if (admission.isAdmitted == 0) continue;

                item = lsvAdmission.Items.Add("Room " + admission.roomNo.ToString() + " Bed " +admission.bedNo.ToString());
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

            admissions[si].doctorID = currentUser.id;
            Classes.AdmissionHelper.SaveAdmission(admissions[si]);
            new Forms.DoctorForm.Admission(admissions[si]).ShowDialog();
        }
    }
}
