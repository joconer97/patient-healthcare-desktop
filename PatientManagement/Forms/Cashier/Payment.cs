using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManagement.Classes;

namespace PatientManagement.Forms.Cashier
{
    public partial class Payment : MetroFramework.Forms.MetroForm
    {
        List<Classes.DischargeRequest> requests = null;
        public Payment()
        {
            InitializeComponent();
            InitListView();
            PopulatListView();
        }

        private void InitListView()
        {
            lsvPayment.Columns.Add("PIN", 200);
            lsvPayment.Columns.Add("Fullname", 280);
            lsvPayment.Columns.Add("Romm / Bed Rate", 100);
            lsvPayment.Columns.Add("Status", 100);




            lsvPayment.View = View.Details;
            lsvPayment.GridLines = true;
            lsvPayment.FullRowSelect = true;
            lsvPayment.HideSelection = false;
            lsvPayment.MultiSelect = false;
        }

        private void PopulatListView()
        {

            requests = GetValidatedDischarge();

            ListViewItem item;

            foreach (var c in requests)
            {
                item = lsvPayment.Items.Add(c.admission.patient.id);
                item.SubItems.Add(c.admission.patient.firstname + " " + c.admission.patient.lastname);
                item.SubItems.Add(c.rate.ToString());
                item.SubItems.Add(c.status);

            }
        }

        private List<DischargeRequest> GetValidatedDischarge()
        {
            List<Classes.DischargeRequest> requests = Classes.RequestHelper.GetDischargeRequests();

            var data = from r in requests
                       where r.status == "Validated"
                       select r;

            List<Classes.DischargeRequest> temp = new List<Classes.DischargeRequest>();

            foreach(var d in data.AsEnumerable())
            {
                temp.Add(new DischargeRequest()
                {
                    id = d.id,
                    admission = d.admission,
                    isPaid = d.isPaid,
                    philhealthCode = d.philhealthCode,
                    philhealthCover = d.philhealthCover,
                    rate = d.rate,
                    status = d.status
                });
            }

            return temp;
        }

        private void lsvPayment_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                index = lsvPayment.SelectedItems[0].Index;
            }
            catch (Exception)
            {
            }

            new DischargeModal(requests[index]).ShowDialog();
        }
    }
}
