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
    public partial class CheckUPSearch : MetroFramework.Forms.MetroForm
    {
        public CheckUPSearch()
        {
            InitializeComponent();
            InitializeListView();
        }
        List<Classes.Patient> currentPatients;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentPatients = Classes.PatientHelper.search(txtSearch.Text,"");
            PopulateList(currentPatients);
            lblFound.Text = currentPatients.Count.ToString() + " patient found";

        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            currentPatients = Classes.PatientHelper.search("", txtSearch.Text);
            PopulateList(currentPatients);
            lblFound.Text = currentPatients.Count.ToString() + " patient found";

        }

        private void InitializeListView()
        {
            lsvView2.Columns.Add("PIN", 200);
            lsvView2.Columns.Add("Firstname", 200);
            lsvView2.Columns.Add("Middlename", 200);
            lsvView2.Columns.Add("Lastname", 200);
            lsvView2.Columns.Add("Gender", 140);



            lsvView2.View = View.Details;
            lsvView2.GridLines = true;
            lsvView2.FullRowSelect = true;
            lsvView2.HideSelection = false;
            lsvView2.MultiSelect = false;
        }

        private void PopulateList(List<Classes.Patient> patients)
        {

            lsvView2.Items.Clear();
            ListViewItem item;
            foreach (var patient in patients)
            {
                item = lsvView2.Items.Add(patient.id);
                item.SubItems.Add(patient.firstname);
                item.SubItems.Add(patient.middlename);
                item.SubItems.Add(patient.lastname);
                item.SubItems.Add(patient.gender.ToString());

            }
        }

        private void lsvView2_DoubleClick(object sender, EventArgs e)
        {
            int si = 0;

            try
            {
                si = lsvView2.SelectedItems[0].Index;
            }
            catch (Exception)
            {

                throw;
            }

            Form checkup = new Forms.PatientForm.CheckUP(currentPatients[si]);

            checkup.ShowDialog();
        }
    }
}
