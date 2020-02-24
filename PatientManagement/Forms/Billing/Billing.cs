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
        public Billing()
        {
            InitializeComponent();
            InitListViewBillApproval();
            InitListViewPatientBill();
        }

        private void InitListViewPatientBill()
        {
            lsvPatientBill.Columns.Add("PIN", 200);
            lsvPatientBill.Columns.Add("Fullname", 280);
            lsvPatientBill.Columns.Add("Total Bill", 100);




            lsvPatientBill.View = View.Details;
            lsvPatientBill.GridLines = true;
            lsvPatientBill.FullRowSelect = true;
            lsvPatientBill.HideSelection = false;
            lsvPatientBill.MultiSelect = false;
        }

        private void InitListViewBillApproval()
        {
            lsvBillApproval.Columns.Add("PIN", 200);
            lsvBillApproval.Columns.Add("Fullname", 280);
            lsvBillApproval.Columns.Add("Request", 500);
            lsvBillApproval.Columns.Add("Price", 50);



            lsvBillApproval.View = View.Details;
            lsvBillApproval.GridLines = true;
            lsvBillApproval.FullRowSelect = true;
            lsvBillApproval.HideSelection = false;
            lsvBillApproval.MultiSelect = false;
        }
    }
}
