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
    public partial class AdmissionReportList : MetroFramework.Forms.MetroForm
    {
        Classes.Admission admission = null;
        List<Classes.Report> reports = null;
        public AdmissionReportList(Classes.Admission admission)
        {
            InitializeComponent();
            this.admission = admission;
        }

        private void AdmissionReportList_Load(object sender, EventArgs e)
        {
            reports = Classes.ReportHelper.ViewReport(admission.id);
            InitDateTime();
            InitViewList();
            PopulateList();
        }
        private void InitDateTime()
        {
            metroDateTime1.MinDate = admission.admittedDate;
            metroDateTime1.MaxDate = DateTime.Now;

            metroDateTime1.Value = admission.admittedDate;

            metroDateTime2.MinDate = admission.admittedDate;
            metroDateTime2.MaxDate = DateTime.Now;

        }
        private void InitViewList()
        {
            lsvList.Columns.Add("Date", 200);
            lsvList.Columns.Add("BP", 100);
            lsvList.Columns.Add("TEMP", 100);
            lsvList.Columns.Add("O2SAT", 100);
            lsvList.Columns.Add("PR", 100);
            lsvList.Columns.Add("RR", 100);
            lsvList.Columns.Add("GCS", 100);


            lsvList.View = View.Details;
            lsvList.GridLines = true;
            lsvList.FullRowSelect = true;
            lsvList.HideSelection = false;
            lsvList.MultiSelect = false;
        }
        private void PopulateList()
        {
            lsvList.Items.Clear();
            var tempReport = FilterReport();
            ListViewItem item;

            foreach(var r in tempReport)
            {
                item = lsvList.Items.Add(r.date.ToShortDateString());
                item.SubItems.Add(r.bp);
                item.SubItems.Add(r.temperature + "°C");
                item.SubItems.Add(r.o2sat);
                item.SubItems.Add(r.pr);
                item.SubItems.Add(r.rr);
                item.SubItems.Add(r.gcs);
            }
        }


        private List<Classes.Report> FilterReport()
        {
            List<Classes.Report> tempReports = new List<Classes.Report>();

            var date1 = metroDateTime1.Value;
            var date2 = metroDateTime2.Value;

            var data = from r in reports
                       where r.date.Date >= date1.Date && r.date.Date <= date2.Date
                       select r;

            foreach(var d in data.AsEnumerable())
            {
                tempReports.Add(new Classes.Report()
                {
                    id = d.id,
                    admissionID = d.admissionID,
                    employeeID = d.employeeID,
                    date = d.date,
                    bp = d.bp,
                    gcs = d.gcs,
                    notes = d.notes,
                    o2sat = d.o2sat,
                    pr = d.pr,
                    rr = d.rr,
                    temperature = d.temperature
                });
            }

            return tempReports;
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {
            PopulateList();
        }
    }
}
