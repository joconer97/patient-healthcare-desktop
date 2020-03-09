using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.Pharmacy
{
    public partial class MedicineRequest : Form
    {
        int admissionID = 0;
        public MedicineRequest(int admissionID)
        {
            InitializeComponent();
            this.admissionID = admissionID;
            InitListView();
            PopulateListView();
        }

        private void InitListView()
        {
            lsvMedicineRequest.Columns.Add("#", 200);
            lsvMedicineRequest.Columns.Add("Medicine Name", 200);
            lsvMedicineRequest.Columns.Add("Price", 280);



            lsvMedicineRequest.View = View.Details;
            lsvMedicineRequest.GridLines = true;
            lsvMedicineRequest.FullRowSelect = true;
            lsvMedicineRequest.HideSelection = false;
            lsvMedicineRequest.MultiSelect = false;
        }

        private void PopulateListView()
        {
            var bills = Classes.BillHelper.GetMedicineRequests(admissionID);
            int ctr = 0;
            ListViewItem item;

            foreach(var b in bills)
            {
                item = lsvMedicineRequest.Items.Add((++ctr).ToString());
                item.SubItems.Add(b.name);
                item.SubItems.Add(b.price.ToString());
            }
        }
    }
}
