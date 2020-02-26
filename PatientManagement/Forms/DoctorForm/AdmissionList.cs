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
            lsvAdmission.Columns.Add("Discharge Date", 200);


            lsvAdmission.View = View.Details;
            lsvAdmission.GridLines = true;
            lsvAdmission.FullRowSelect = true;
            lsvAdmission.HideSelection = false;
            lsvAdmission.MultiSelect = false;
        }

        private void PopulateListView()
        {
            ListViewItem item;

            item = lsvAdmission.Items.Add("1");
            item.SubItems.Add("10563623");
            item.SubItems.Add("Arnel Joshua Payongayong");
            item.SubItems.Add("M");
            item.SubItems.Add("Dengue");
            item.SubItems.Add("02/20/2020");
            item.SubItems.Add("02/30/2020");
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
