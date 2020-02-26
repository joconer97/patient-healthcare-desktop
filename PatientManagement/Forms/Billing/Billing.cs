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
        List<Classes.Request> requests = new List<Classes.Request>();
        public Billing()
        {
            InitializeComponent();
            InitListViewBillApproval();
            InitListViewPatientBill();
            InitRequestList();
            PopulatListView();
            PopulateBillList();
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
            lsvProduct.Columns.Add("Name", 100);
            lsvProduct.Columns.Add("Type", 100);
            lsvProduct.Columns.Add("Price", 100);
            lsvProduct.Columns.Add("Quantity", 100);




            lsvProduct.View = View.Details;
            lsvProduct.GridLines = true;
            lsvProduct.FullRowSelect = true;
            lsvProduct.HideSelection = false;
            lsvProduct.MultiSelect = false;
        }

        private void InitRequestList()
        {
            lsvRequest.Columns.Add("Name", 100);
            lsvRequest.Columns.Add("Type", 100);
            lsvRequest.Columns.Add("Price", 100);
            lsvRequest.Columns.Add("Quantity", 100);




            lsvRequest.View = View.Details;
            lsvRequest.GridLines = true;
            lsvRequest.FullRowSelect = true;
            lsvRequest.HideSelection = false;
            lsvRequest.MultiSelect = false;
        }

        private void PopulatListView()
        {
            ListViewItem item;

            foreach (var c in products)
            {
                item = lsvProduct.Items.Add(c.name);
                item.SubItems.Add(c.type);
                item.SubItems.Add(c.price.ToString());
                item.SubItems.Add(c.quantity.ToString());

            }
        }

        private void PopulatRequestList()
        {
            ListViewItem item;

            lsvRequest.Items.Clear();

            foreach (var c in requests)
            {
                item = lsvRequest.Items.Add(c.name);
                item.SubItems.Add(c.type);
                item.SubItems.Add(c.price.ToString());
                item.SubItems.Add(c.quantity.ToString());

            }
        }

        private void PopulateBillList()
        {
            ListViewItem item;

            lsvRequest.Items.Clear();


            item = lsvPatientBill.Items.Add("10536732");
            item.SubItems.Add("Arnel Joshua Payongayong");
            item.SubItems.Add("1523.00");

        }

        List<Classes.Product> products = new List<Classes.Product>()
            {

                new Classes.Product()
                {
                    name = "Biogesic",
                    type = "Medicine",
                    price = 7,
                    quantity = 35
                },
                new Classes.Product()
                {
                    name = "Prep",
                    type = "Medical Supply",
                    price = 7,
                    quantity = 50
                },
                new Classes.Product()
                {
                    name = "Scrub",
                    type = "Medical Supply",
                    price = 7,
                    quantity = 60
                },
                new Classes.Product()
                {
                    name = "Alcohol Pads",
                    type = "Medical Supply",
                    price = 7,
                    quantity = 30
                },
                 new Classes.Product()
                {
                    name = "Radiology",
                    type = "Laboratory",
                    price = 400,
                    quantity = 1
                }


            };

        private void lsvProduct_DoubleClick(object sender, EventArgs e)
        {
            int si = 0;

            try
            {
                si = lsvProduct.SelectedItems[0].Index;
            }
            catch
            {
                return;
            }

            requests.Add(new Classes.Request()
            {
                name = products[si].name,
                price = products[si].price,
                quantity = 1,
                type = products[si].type
                
            });

            PopulatRequestList();

        }

        private void lsvPatientBill_DoubleClick(object sender, EventArgs e)
        {
            new Forms.Billing.BillingSummary().ShowDialog();
        }
    }
}
