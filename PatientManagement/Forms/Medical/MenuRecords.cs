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
        List<Classes.MedicalRecord> medicalRecords = null;
        List<Classes.MedicalRecord> summaryRecords = null;
        public MenuRecords()
        {
            InitializeComponent();
        }

        private void MenuRecords_Load(object sender, EventArgs e)
        {
            InitListView();
            PopulateList();
            FillSummaryRecords();
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
            medicalRecords = Classes.MedicalRecordHelper.GetMedicalRecords();

            ListViewItem item;
            lsvRecords.Items.Clear();

            foreach (var m in medicalRecords)
            {
                item = lsvRecords.Items.Add(m.id.ToString());
                item.SubItems.Add(m.type);
                item.SubItems.Add(m.date.ToShortDateString());
                item.SubItems.Add(m.patient.firstname + " " + m.patient.middlename.Substring(0, 1) + " " + m.patient.lastname);
            }
        }
        private void FilterPopulate()
        {
            var filterRecords = FilterRecord(textBox1.Text);

            ListViewItem item;

            lsvRecords.Items.Clear();

            foreach (var m in filterRecords)
            {
                item = lsvRecords.Items.Add(m.id.ToString());
                item.SubItems.Add(m.type);
                item.SubItems.Add(m.date.ToShortDateString());
                item.SubItems.Add(m.patient.firstname + " " + m.patient.middlename.Substring(0, 1) + " " + m.patient.lastname);
            }
        }
        private void FillSummaryRecords()
        {
            summaryRecords = Classes.MedicalRecordHelper.GetSummaryMedicalRecords();
        }

        private List<Classes.MedicalRecord> FilterSummaryRecords(int admissionID)
        {
            List<Classes.MedicalRecord> medicalRecords = new List<Classes.MedicalRecord>();

            var data = from r in summaryRecords
                       where r.typeID == admissionID
                       select r;

            foreach(var d in data.AsEnumerable())
            {
                medicalRecords.Add(d);
            }

            return medicalRecords;

            
        }

        private void lsvRecords_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                index = lsvRecords.SelectedItems[0].Index;
            }
            catch (Exception)
            {

            }
            //IF admission record
            var selectedRecords = medicalRecords[index];

            if(selectedRecords.type == "ADMITTED")
            {
                var selectedSummaryRecords = FilterSummaryRecords(selectedRecords.id);

                new Forms.Medical.MedicalRecordSummary(selectedSummaryRecords).ShowDialog();
            }
            else
            {

            }
        }

        private List<Classes.MedicalRecord> FilterRecord(string lastname)
        {
            List<Classes.MedicalRecord> records = new List<Classes.MedicalRecord>();

            var data = from r in medicalRecords
                       where r.patient.lastname == lastname
                       select r;

            foreach(var d in data.AsEnumerable())
            {
                records.Add(d);
            }

            return records;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                PopulateList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterPopulate();
        }
    }
}
