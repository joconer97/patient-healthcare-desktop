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
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
            InitListView();
            PopulatListView();
        }

        private void InitListView()
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

        private void PopulatListView()
        {
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
                }


            };

            ListViewItem item;

            foreach (var c in products)
            {
                item = lsvProduct.Items.Add(c.name);
                item.SubItems.Add(c.type);
                item.SubItems.Add(c.price.ToString());
                item.SubItems.Add(c.quantity.ToString());

            }
        }
    }
}
