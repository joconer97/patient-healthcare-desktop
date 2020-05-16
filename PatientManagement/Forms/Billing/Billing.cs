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
    public partial class Billing : MetroFramework.Forms.MetroForm
    {
        List<Classes.DischargeRequest> requests = null;
        public Billing()
        {
            InitializeComponent();
            InitListViewPatientBill();
            PopulateBillList();
        }

        private void InitListViewPatientBill()
        {
            lsvPatientBill.Columns.Add("PIN", 200);
            lsvPatientBill.Columns.Add("Fullname", 280);


            lsvPatientBill.View = View.Details;
            lsvPatientBill.GridLines = true;
            lsvPatientBill.FullRowSelect = true;
            lsvPatientBill.HideSelection = false;
            lsvPatientBill.MultiSelect = false;
        }


        private void PopulateBillList()
        {
            ListViewItem item;
            requests = Classes.RequestHelper.GetDischargeRequests();


            lsvPatientBill.Items.Clear();

            foreach (var r in requests)
            {
                item = lsvPatientBill.Items.Add(r.admission.patient.id);
                item.SubItems.Add(r.admission.patient.firstname + " " + r.admission.patient.lastname);
            }
        }


        private void lsvPatientBill_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                index = lsvPatientBill.SelectedItems[0].Index;
            }
            catch { }

            new Forms.Billing.BillingSummary(requests[index]).ShowDialog();
        }
    }
}
