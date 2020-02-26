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
            PopulateList();
        }

        private void InitListView()
        {
            lsvSummary.Columns.Add("PIN", 200);
            lsvSummary.Columns.Add("Fullname", 280);
            lsvSummary.Columns.Add("Product Name", 100);
            lsvSummary.Columns.Add("Price", 50);
            lsvSummary.Columns.Add("Quantity", 50);
            lsvSummary.Columns.Add("Date", 50);




            lsvSummary.View = View.Details;
            lsvSummary.GridLines = true;
            lsvSummary.FullRowSelect = true;
            lsvSummary.HideSelection = false;
            lsvSummary.MultiSelect = false;
        }

        private void PopulateList()
        {
            ListViewItem item;

            item = lsvSummary.Items.Add("10532523");
            item.SubItems.Add("Arnel Joshua Payongayong");
            item.SubItems.Add("Biogesic");
            item.SubItems.Add("8");
            item.SubItems.Add("5");
            item.SubItems.Add("02/22/2020");


            item = lsvSummary.Items.Add("10532523");
            item.SubItems.Add("Arnel Joshua Payongayong");
            item.SubItems.Add("Radiology");
            item.SubItems.Add("670");
            item.SubItems.Add("1");
            item.SubItems.Add("02/22/2020");

        }
    }
}
