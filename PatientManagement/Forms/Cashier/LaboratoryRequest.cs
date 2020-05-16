using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.Cashier
{
    public partial class LaboratoryRequest : MetroFramework.Forms.MetroForm
    {
        public LaboratoryRequest()
        {
            InitializeComponent();
            InitListView();
            PopulateLaboratoryRequest();
        }

        List<Classes.LaboratoryRequest> laboratoryRequests = null;
        private void InitListView()
        {
            lsvRequest.Clear();

            lsvRequest.Columns.Add("Name", 100);
            lsvRequest.Columns.Add("Type", 100);
            lsvRequest.Columns.Add("Price", 100);




            lsvRequest.View = View.Details;
            lsvRequest.GridLines = true;
            lsvRequest.FullRowSelect = true;
            lsvRequest.HideSelection = false;
            lsvRequest.MultiSelect = false;
        }

        private void PopulateLaboratoryRequest()
        {
            laboratoryRequests = GetPendingRequest();

            ListViewItem item;
            int index = 0;
            foreach (var m in laboratoryRequests)
            {
                if (m.isPaid == "Pending")
                {
                    List<Classes.TestType> testTypes = Classes.LaboratoryRequestHelper.TestTypeList(m.id);
                    m.price = GetTypePrices(testTypes);
                    item = lsvRequest.Items.Add(m.patient.id);
                    item.SubItems.Add("Laboratory");
                    item.SubItems.Add(m.price.ToString());
                    continue;
                }

                index++;
            }
        }

        private List<Classes.LaboratoryRequest> GetPendingRequest()
        {
            var temp = Classes.LaboratoryRequestHelper.LaboratoryRequestsList();
            List<Classes.LaboratoryRequest> tempLaboratoryRequests = new List<Classes.LaboratoryRequest>();

            var data = from t in temp
                       where t.isPaid == "Pending"
                       select t;

            foreach(var d in data.AsEnumerable())
            {
                tempLaboratoryRequests.Add(d);
            }

            return tempLaboratoryRequests;
        }

        private decimal GetTypePrices(List<Classes.TestType> testTypes)
        {
            var laboratory = Classes.LaboratoryHelper.Laboratories();
            decimal price = 0;

            foreach (var t in testTypes)
            {
                foreach (var l in laboratory)
                {
                    if (t.name == l.name)
                    {
                        price += l.price;
                    }
                }
            }
            return price;
        }

        private void lsvRequest_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                index = lsvRequest.SelectedItems[0].Index;
            }
            catch (Exception)
            {

                throw;
            }

            new Forms.Cashier.PaymentModal(laboratoryRequests[index]).ShowDialog();
        }
    }
}
