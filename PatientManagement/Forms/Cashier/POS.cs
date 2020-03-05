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
            InitListTransaction();
        }

        string currentList = "";
        decimal totalPrice = 0;
        Classes.Transaction transaction = new Classes.Transaction();
        List<Classes.Medicine> medicines = null;
        List<Classes.MedicalSupply> medicalSupply = null;

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            if (currentList == "Medicine")
                return;

            currentList = "Medicine";
            InitListMedicine();
            PopulateMedicine();
        }
        private void InitListTransaction()
        {
            lsvTransaction.Columns.Add("Name", 100);
            lsvTransaction.Columns.Add("Price", 100);
            lsvTransaction.Columns.Add("Quantity", 100);
            lsvTransaction.Columns.Add("Type", 100);

            lsvTransaction.View = View.Details;
            lsvTransaction.GridLines = true;
            lsvTransaction.FullRowSelect = true;
            lsvTransaction.HideSelection = false;
            lsvTransaction.MultiSelect = false;
        }

        private void InitListMedicine()
        {
            lsvProduct.Clear();

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

        private void PopulateMedicine()
        {
           medicines = Classes.MedicineHelper.Medicines();

            ListViewItem item;

            foreach(var m in medicines)
            {
                item = lsvProduct.Items.Add(m.name);
                item.SubItems.Add("Medicine");
                item.SubItems.Add(m.price.ToString());
                item.SubItems.Add(m.quantity.ToString());
            }
        }
        private void InitListMedicalSupply()
        {
            lsvProduct.Clear();

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

        private void PopulateMedicalSupply()
        {
            medicalSupply = Classes.MedicalSupplyHelper.MedicalSupplies();

            ListViewItem item;

            foreach (var m in medicalSupply)
            {
                item = lsvProduct.Items.Add(m.name);
                item.SubItems.Add("Medical Supply");
                item.SubItems.Add(m.price.ToString());
                item.SubItems.Add(m.quantity.ToString());
            }
        }

        private void btnMedicalSupply_Click(object sender, EventArgs e)
        {
            if (currentList == "MedicalSupply")
                return;

            currentList = "MedicalSupply";

            InitListMedicalSupply();
            PopulateMedicalSupply();
        }

        private void lsvProduct_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                index = lsvProduct.SelectedItems[0].Index;
            }
            catch (Exception)
            {

                throw;
            }

            AddItem(index);
            PopulateTransactionList();

        }
        private void PopulateTransactionList()
        {
            ListViewItem item;
            lsvTransaction.Items.Clear();
            foreach(var m in transaction.medicines)
            {
                item = lsvTransaction.Items.Add(m.name);
                item.SubItems.Add(m.price.ToString());
                item.SubItems.Add(m.quantity.ToString());
                item.SubItems.Add("Medicine");
            }

            foreach (var m in transaction.medicalSupplies)
            {
                item = lsvTransaction.Items.Add(m.name);
                item.SubItems.Add(m.price.ToString());
                item.SubItems.Add(m.quantity.ToString());
                item.SubItems.Add("Medical Supply");
            }
        }

        private void AddItem(int index)
        {
            switch(currentList)
            {
                case "Medicine":
                    transaction.medicines.Add(new Classes.Medicine()
                    {
                        name = medicines[index].name,
                        price = medicines[index].price,
                        quantity = 1
                    });
                    totalPrice += medicines[index].price;
                    break;
                case "MedicalSupply":
                    transaction.medicalSupplies.Add(new Classes.MedicalSupply()
                    {
                        name = medicalSupply[index].name,
                        price = medicalSupply[index].price,
                        quantity = 1
                    });
                    totalPrice += medicalSupply[index].price;
                    break;
                default:
                    break;
            }

            txtTotal.Text = totalPrice.ToString();
        }


    }
}
