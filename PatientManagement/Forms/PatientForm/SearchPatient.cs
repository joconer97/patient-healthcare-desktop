using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManagement.Classes;
namespace PatientManagement.Forms.PatientForm
{
    public partial class SearchPatient : MetroFramework.Forms.MetroForm
    {
        public SearchPatient()
        {
            InitializeComponent();
            InitListView();
            PopulateListView();
        }
        List<Patient> patients;

        private void InitListView()
        {
            lsvPatient.Columns.Add("PIN", 200);
            lsvPatient.Columns.Add("Firstname", 200);
            lsvPatient.Columns.Add("Middlename", 200);
            lsvPatient.Columns.Add("Lastname", 200);
            lsvPatient.Columns.Add("Gender", 140);
            lsvPatient.Columns.Add("Membership Status", 200);

            lsvPatient.View = View.Details;
            lsvPatient.GridLines = true;
            lsvPatient.FullRowSelect = true;
            lsvPatient.HideSelection = false;
            lsvPatient.MultiSelect = false;
        }

        private void PopulateListView()
        {
            patients = PatientHelper.GetPatients();

            ListViewItem item;
            lsvPatient.Items.Clear();
            foreach(var p in patients)
            {
                item = lsvPatient.Items.Add(p.id);
                item.SubItems.Add(p.firstname);
                item.SubItems.Add(p.middlename);
                item.SubItems.Add(p.lastname);
                item.SubItems.Add(p.gender.ToString());
                item.SubItems.Add((p.isRegistered == 0) ? "Pending" : "Member");
            }
        }

        private void lsvPatient_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                index = lsvPatient.SelectedItems[0].Index;
            }
            catch
            {

                throw;
            }

            if(new Forms.PatientForm.UpdatePatient(patients[index]).ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Updated Succesfully");
                PopulateListView();
            }
        }
    }
}
