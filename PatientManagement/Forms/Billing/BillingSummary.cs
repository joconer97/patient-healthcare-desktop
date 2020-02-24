using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.Billing
{
    public partial class BillingSummary : MetroFramework.Forms.MetroForm
    {
        public BillingSummary()
        {
            InitializeComponent();
            InitListView();
        }

        private void InitListView()
        {
            lsvSummary.Columns.Add("PIN", 200);
            lsvSummary.Columns.Add("Fullname", 280);
            lsvSummary.Columns.Add("Details", 100);
            lsvSummary.Columns.Add("Price", 50);
            lsvSummary.Columns.Add("Date", 50);




            lsvSummary.View = View.Details;
            lsvSummary.GridLines = true;
            lsvSummary.FullRowSelect = true;
            lsvSummary.HideSelection = false;
            lsvSummary.MultiSelect = false;
        }
    }
}
