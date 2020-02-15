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
    public partial class CheckUPSearch : Form
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
            lsvView.Columns.Add("#", 200);
            lsvView.Columns.Add("PIN", 200);
            lsvView.Columns.Add("Firstname", 100);
            lsvView.Columns.Add("Middlename", 100);
            lsvView.Columns.Add("Lastname", 100);
            lsvView.Columns.Add("Gender", 50);



            lsvView.View = View.Details;
            lsvView.GridLines = true;
            lsvView.FullRowSelect = true;
            lsvView.HideSelection = false;
            lsvView.MultiSelect = false;
        }

        private void PopulateList(List<Classes.Patient> patients)
        {
            int ctr = 0;

            lsvView.Items.Clear();
            ListViewItem item;
            foreach (var patient in patients)
            {
                item = lsvView.Items.Add((++ctr).ToString());
                item.SubItems.Add(patient.id);
                item.SubItems.Add(patient.firstname);
                item.SubItems.Add(patient.middlename);
                item.SubItems.Add(patient.lastname);
                item.SubItems.Add(patient.gender.ToString());

            }
        }

        private void lsvView_DoubleClick(object sender, EventArgs e)
        {
            int si = 0;

            try
            {
                si = lsvView.SelectedItems[0].Index;
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
