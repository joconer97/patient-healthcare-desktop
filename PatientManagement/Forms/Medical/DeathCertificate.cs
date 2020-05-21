using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.Medical
{
    public partial class DeathCertificate : MetroFramework.Forms.MetroForm
    {
        List<Classes.Deceased> deceaseds = new List<Classes.Deceased>();
        public DeathCertificate()
        {
            InitializeComponent();
        }

        private void DeathCertificate_Load(object sender, EventArgs e)
        {

        }

        private void InitializeListView()
        {
            lsvRecords.Columns.Add("ADMISSION #", 50);
            lsvRecords.Columns.Add("TIME OF DEATH", 200);
            lsvRecords.Columns.Add("DATE OF DEATH", 200);
            lsvRecords.Columns.Add("PATIENT", 200);


            lsvRecords.View = View.Details;
            lsvRecords.GridLines = true;
            lsvRecords.FullRowSelect = true;
            lsvRecords.HideSelection = false;
            lsvRecords.MultiSelect = false;
        }

        private void PopulateList()
        {
            deceaseds = Classes.DeceasedHelper.GetDeceases();

            ListViewItem item;

            lsvRecords.Items.Clear();

            foreach(var d in deceaseds)
            {
                item = lsvRecords.Items.Add(d.admissionID.ToString());
                item.SubItems.Add(d.timeOfDeath.ToString());
                item.SubItems.Add(d.dateOfDeath.ToShortDateString());
                item.SubItems.Add(d.patient.firstname + " " + d.patient.middlename + " " + d.patient.lastname);
            }
        }
    }
}
