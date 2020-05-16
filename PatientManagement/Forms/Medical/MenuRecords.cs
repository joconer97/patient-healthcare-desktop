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
    public partial class MenuRecords : MetroFramework.Forms.MetroForm
    {
        public MenuRecords()
        {
            InitializeComponent();
        }

        private void MenuRecords_Load(object sender, EventArgs e)
        {
            InitListView();
            PopulateList();
        }

        private void InitListView()
        {
            lsvRecords.Columns.Add("ID#", 200);
            lsvRecords.Columns.Add("TYPE", 100);
            lsvRecords.Columns.Add("DATE", 150);
            lsvRecords.Columns.Add("PATIENT NAME", 300);


            lsvRecords.View = View.Details;
            lsvRecords.GridLines = true;
            lsvRecords.FullRowSelect = true;
            lsvRecords.HideSelection = false;
            lsvRecords.MultiSelect = false;
        }

        private void PopulateList()
        {
            var medicalRecords = Classes.MedicalRecordHelper.GetMedicalRecords();

            ListViewItem item;

            foreach(var m in medicalRecords)
            {
                item = lsvRecords.Items.Add(m.id.ToString());
                item.SubItems.Add(m.type);
                item.SubItems.Add(m.date.ToShortDateString());
                item.SubItems.Add(m.patient.firstname + " " + m.patient.middlename.Substring(0, 1) + " " + m.patient.lastname);
            }
        }
    }
}
