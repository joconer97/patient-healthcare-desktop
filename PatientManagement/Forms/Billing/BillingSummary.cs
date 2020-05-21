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
        Classes.DischargeRequest request = null;
        decimal totalAmount = 0;
        public BillingSummary(Classes.DischargeRequest request)
        {
            InitializeComponent();
            this.request = request;
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

            var bills = Classes.BillHelper.GetSummaryBills(this.request.admission.id);
            
            foreach(var b in bills)
            {
                if (b.isPaid != 0)return;

                item = lsvSummary.Items.Add(request.admission.patient.id);
                item.SubItems.Add(request.admission.patient.firstname + " " + request.admission.patient.lastname);
                item.SubItems.Add(b.type);
                item.SubItems.Add(b.status);
                item.SubItems.Add(b.total.ToString());
                item.SubItems.Add(b.date.ToShortDateString());
                totalAmount += b.total;
            }


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new ValidatingBill(totalAmount,request).ShowDialog();
        }

        private void BillingSummary_Load(object sender, EventArgs e)
        {

        }
    }
}
