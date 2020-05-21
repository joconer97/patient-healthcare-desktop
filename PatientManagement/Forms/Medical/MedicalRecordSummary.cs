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
    public partial class MedicalRecordSummary : MetroFramework.Forms.MetroForm
    {
        List<Classes.MedicalRecord> records = null;
        List<Classes.LaboratoryRequest> laboratoryRequests = null;
        List<Classes.Report> reports = null;
        public MedicalRecordSummary(List<Classes.MedicalRecord> records)
        {
            InitializeComponent();
            this.records = records;
        }

        private void MedicalRecordSummary_Load(object sender, EventArgs e)
        {
            InitListView();
            PopulateList();
        }

        private void InitializeReports()
        {
            laboratoryRequests = Classes.LaboratoryRequestHelper.LaboratoryRequestsList();
        }

        private void InitListView()
        {
            lsvRecords.Columns.Add("ID#", 200);
            lsvRecords.Columns.Add("TYPE", 100);
            lsvRecords.Columns.Add("DATE", 200);


            lsvRecords.View = View.Details;
            lsvRecords.GridLines = true;
            lsvRecords.FullRowSelect = true;
            lsvRecords.HideSelection = false;
            lsvRecords.MultiSelect = false;
        }

        private void PopulateList()
        {
            ListViewItem item;

            foreach(var r in records)
            {
                item = lsvRecords.Items.Add(r.id.ToString());
                item.SubItems.Add(r.type);
                item.SubItems.Add(r.date.ToShortDateString());
            }
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

            var selectedRecords = records[index];

            if(selectedRecords.type == "LABORATORY")
            {
                var data = Classes.LaboratoryRequestHelper.ViewLaboratoryRequest(selectedRecords.id);

                new Forms.Laboratory.LaboratoryResult(data).ShowDialog();
            }
            else
            {

            }
        }
    }
}
