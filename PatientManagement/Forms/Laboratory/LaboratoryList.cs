using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.Laboratory
{
    public partial class LaboratoryList : Form
    {
        public LaboratoryList()
        {
            InitializeComponent();
            InitListView();
            PopulateList();
        }
        List<Classes.LaboratoryRequest> requests = null;

        private void PopulateList()
        {
            requests = Classes.LaboratoryRequestHelper.LaboratoryRequestsList();

            ListViewItem item;

            foreach(var r in requests)
            {
                item = lsvLaboratory.Items.Add(r.patient.firstname + " " + r.patient.middlename + " " + r.patient.lastname);
                item.SubItems.Add(r.user.firstname + " " + r.user.lastname);
                item.SubItems.Add(r.status);
                item.SubItems.Add(r.urgency);
            }
        }
        private void InitListView()
        {
            lsvLaboratory.Columns.Add("Patient Name", 200);
            lsvLaboratory.Columns.Add("Doctor Name", 200);
            lsvLaboratory.Columns.Add("Status", 280);
            lsvLaboratory.Columns.Add("Urgency", 30);


            lsvLaboratory.View = View.Details;
            lsvLaboratory.GridLines = true;
            lsvLaboratory.FullRowSelect = true;
            lsvLaboratory.HideSelection = false;
            lsvLaboratory.MultiSelect = false;
        }

        private void lsvLaboratory_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                index = lsvLaboratory.SelectedItems[0].Index;
            }
            catch (Exception)
            {

                throw;
            }

            new Forms.Laboratory.PendingLaboratoryRequest(requests[index]).ShowDialog();
        }
    }
}
