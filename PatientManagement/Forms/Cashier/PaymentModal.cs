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
    public partial class PaymentModal : MetroFramework.Forms.MetroForm
    {
        public PaymentModal()
        {
            InitializeComponent();
            InitListView();
        }

        private void InitListView()
        {
            lsvPayment.Columns.Add("Medicine / Lab", 150);
            lsvPayment.Columns.Add("Price", 100);
            lsvPayment.Columns.Add("Quantity", 50);



            lsvPayment.View = View.Details;
            lsvPayment.GridLines = true;
            lsvPayment.FullRowSelect = true;
            lsvPayment.HideSelection = false;
            lsvPayment.MultiSelect = false;
        }
    }
}
