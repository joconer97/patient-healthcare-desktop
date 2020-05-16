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
    public partial class POS : MetroFramework.Forms.MetroForm
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
        List<Classes.LaboratoryRequest> laboratoryRequests = null;

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

        private void InitListLaboratory()
        {
            lsvProduct.Clear();

            lsvProduct.Columns.Add("Name", 100);
            lsvProduct.Columns.Add("Type", 100);
            lsvProduct.Columns.Add("Price", 100);




            lsvProduct.View = View.Details;
            lsvProduct.GridLines = true;
            lsvProduct.FullRowSelect = true;
            lsvProduct.HideSelection = false;
            lsvProduct.MultiSelect = false;
        }

        private void PopulateLaboratoryRequest()
        {
            laboratoryRequests = Classes.LaboratoryRequestHelper.LaboratoryRequestsList();
           
            ListViewItem item;
            int index = 0;
            foreach (var m in laboratoryRequests)
            {
                if(m.isPaid == "Pending")
                {
                    List<Classes.TestType> testTypes = Classes.LaboratoryRequestHelper.TestTypeList(m.id);
                    m.price = GetTypePrices(testTypes);
                    item = lsvProduct.Items.Add(m.patient.id);
                    item.SubItems.Add("Laboratory");
                    item.SubItems.Add(m.price.ToString());
                }
               

                index++;
            }
        }

        private decimal GetTypePrices(List<Classes.TestType> testTypes)
        {
            var laboratory = Classes.LaboratoryHelper.Laboratories();
            decimal price = 0;

            foreach(var t in testTypes)
            {
                foreach(var l in laboratory)
                {
                    if(t.name == l.name)
                    {
                        price += l.price;
                    }
                }
            }
            return price;
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

            foreach(var m in transaction.laboratories)
            {
                item = lsvTransaction.Items.Add(m.patient.id);
                item.SubItems.Add(m.price.ToString());
                item.SubItems.Add("Laboratory");
            }
        }

        private void AddItem(int index)
        {
            switch(currentList)
            {
                case "Medicine":
                    AddMedicine(index);
                    break;
                case "MedicalSupply":
                    AddMedicalSupply(index);
                    break;
                case "Laboratory":
                    var tempRequest = laboratoryRequests[index];
                    transaction.laboratories.Add(tempRequest);
                    totalPrice += laboratoryRequests[index].price;
                    break;

                default:
                    break;
            }

            txtTotal.Text = totalPrice.ToString();
        }

        private void AddMedicine(int index)
        {
            if (medicineIsExist(medicines[index].id))
            {
                int i = getMedicineIndex(medicines[index].id);

                if(transaction.medicines[i].quantity >= medicines[index].quantity)
                {
                    MessageBox.Show("The stock will be empty");
                    return;
                }
                transaction.medicines[i].quantity++;
            }
            else
            {
                transaction.medicines.Add(new Classes.Medicine()
                {
                    id = medicines[index].id,
                    name = medicines[index].name,
                    price = medicines[index].price,
                    quantity = 1
                });

            }
            totalPrice += medicines[index].price;
        }

        private void AddMedicalSupply(int index)
        {
            if (medicalSupplyExist(medicalSupply[index].id))
            {
                int i = getMedicalSupplyIndex(medicalSupply[index].id);

                if (transaction.medicalSupplies[index].quantity >= medicalSupply[index].quantity)
                {
                    MessageBox.Show("The stock will be empty");
                    return;
                }
                transaction.medicalSupplies[index].quantity++;
            }
            else
            {
                transaction.medicalSupplies.Add(new Classes.MedicalSupply()
                {
                    id = medicalSupply[index].id,
                    name = medicalSupply[index].name,
                    price = medicalSupply[index].price,
                    quantity = 1
                });
            }
            totalPrice += medicalSupply[index].price;
        }

        private int getMedicineIndex(int id)
        {
            int index = 0;

            foreach (var t in transaction.medicines)
            {
                if (t.id == id)
                {
                    return index;
                }
                index++;
            }

            return 0;
        }

        private int getMedicalSupplyIndex(int id)
        {
            int index = 0;

            foreach (var t in transaction.medicalSupplies)
            {
                if (t.id == id)
                {
                    return index;
                }
                index++;
            }
            return 0;
        }


        private bool medicineIsExist(int id)
        {
            if (transaction.medicines.Count == 0) return false;

            foreach(var t in transaction.medicines)
            {
                if(t.id == id)
                {
                    return true;
                }
            }
            return false;
        }

        private bool medicalSupplyExist(int id)
        {
            if (transaction.medicalSupplies.Count == 0) return false;

            foreach (var t in transaction.medicalSupplies)
            {
                if (t.id == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            List<Classes.Medicine> tempMedicines = new List<Classes.Medicine>();

            foreach (var m in transaction.medicines)
            {
                Classes.TransactionHelper.SaveTransaction(new Classes.Transaction()
                {
                    type = "Medicine",
                    typeID = m.id,
                    status = "Cash",
                    date = DateTime.Now
                });

                int index = getMedicineIndex(m.id);

                Classes.Medicine tempMedicine = medicines[index];

                tempMedicine.quantity -= m.quantity;

                tempMedicines.Add(tempMedicine);

                Classes.MedicineHelper.UpdateMedicineQuantity(new Classes.Medicine()
                {
                    id = m.id,
                    quantity = m.quantity
                });

            }

            Firebase.Firebase firebase = new Firebase.Firebase();

            firebase.UpdateQuantityMedicine(tempMedicines);

            foreach (var m in transaction.medicalSupplies)
            {
                Classes.TransactionHelper.SaveTransaction(new Classes.Transaction()
                {
                    type = "Medical Supply",
                    typeID = m.id,
                    status = "Cash",
                    date = DateTime.Now
                });

                Classes.MedicalSupplyHelper.UpdateMedicalSupplyQuantity(new Classes.MedicalSupply()
                {
                    id = m.id,
                    quantity = m.quantity
                });
            }

            foreach(var m in transaction.laboratories)
            {
                Classes.TransactionHelper.SaveTransaction(new Classes.Transaction()
                {
                    type = "Laboratory",
                    typeID = m.id,
                    status = "Cash",
                    date = DateTime.Now
                });

                m.isPaid = "Paid";
                Classes.LaboratoryRequestHelper.SaveLaboratoryRequest(m);
            }

            PrintReceipt();
            transaction.medicalSupplies.Clear();
            transaction.medicines.Clear();
            transaction.laboratories.Clear();
            txtTotal.Text = "0";
            MessageBox.Show("Successfully transactions");
            lsvTransaction.Items.Clear();
            lsvProduct.Clear();
            currentList = "";
            Clear();
        }


        private void metroButton2_Click(object sender, EventArgs e)
        {

            if(txtPatientID.Text == "")
            {
                MessageBox.Show("Please fill up the patient id");
            }

            int transactionID = 0;

            Classes.Admission admission = Classes.AdmissionHelper.SearchAdmission(txtPatientID.Text);

            if(admission == null)
            {
                MessageBox.Show("There no admitted patient with id of " + txtPatientID.Text);
                return;
            }

            txtFullname.Text = admission.patient.firstname + " " + admission.patient.middlename + " " + admission.patient.lastname;


            if(MessageBox.Show("Do you want to continue?","PHC",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            Firebase.Firebase firebase = new Firebase.Firebase();

            foreach (var m in transaction.medicines)
            {
                transactionID = Classes.TransactionHelper.SaveTransaction(new Classes.Transaction()
                {
                    type = "Medicine",
                    typeID = m.id,
                    status = "Bill",
                    date = DateTime.Now
                });

                int tempID = Classes.BillHelper.SaveBill(new Classes.Bill()
                {
                    id = 0,
                    admittedID = admission.id,
                    transactionID = transactionID,
                    isPaid = 0
                });

                firebase.InsertBill(new Classes.Bill()
                {
                    id = tempID,
                    name = m.name,
                    type = "Medicine",
                    patient = new Classes.Patient()
                    {
                        id = txtPatientID.Text
                    },
                    total = m.price,
                    isPaid = 0,
                    admittedID = admission.id,
                    date = DateTime.Now
                });
  
            }

            foreach (var m in transaction.medicalSupplies)
            {
                transactionID = Classes.TransactionHelper.SaveTransaction(new Classes.Transaction()
                {
                    type = "Medical Supply",
                    typeID = m.id,
                    status = "Bill",
                    date = DateTime.Now
                });

                int tempID = Classes.BillHelper.SaveBill(new Classes.Bill()
                {
                    id = 0,
                    admittedID = admission.id,
                    transactionID = transactionID,
                    isPaid = 0,
                });

                firebase.InsertBill(new Classes.Bill()
                {
                    id = tempID,
                    name = m.name,
                    type = "Medical Supply",
                    patient = new Classes.Patient()
                    {
                        id = txtPatientID.Text
                    },
                    total = m.price,
                    isPaid = 0,
                    admittedID = admission.id,
                    date = DateTime.Now
                });
            }
            MessageBox.Show("Saved!");
            Clear();
        }

        private void Clear()
        {
            lsvTransaction.Items.Clear();
            txtPatientID.Text = "PatientID";
            txtFullname.Text = "";

            txtPayment.Text = "";
            txtChange.Text = "";
            txtTotal.Text = "";
            transaction.medicalSupplies.Clear();
            transaction.medicines.Clear();
        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            if (currentList == "Laboratory")
                return;

            currentList = "Laboratory";
            InitListLaboratory();
            PopulateLaboratoryRequest();
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtChange.Text = (Int32.Parse(txtPayment.Text) - Int32.Parse(txtTotal.Text)).ToString();
            }
            catch (Exception)
            {
            }
          
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            for (int x = 0; x < 1000; x += 50)
            {
                e.Graphics.DrawString(x.ToString(), new Font("Times new roman", 11, FontStyle.Bold), Brushes.Black, new Point(x, 10));
            }

            for (int y = 0; y < 1000; y += 50)
            {
                e.Graphics.DrawString(y.ToString(), new Font("Times new roman", 11, FontStyle.Bold), Brushes.Black, new Point(10, y));
            }
            //header
            e.Graphics.DrawString("Naga City Hospital", new Font("Times new roman", 15, FontStyle.Bold), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString("Penafrancia Ave, Baranagay Peñafrancia, Naga, 4400 Camarines Sur", new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(200, 80));


            e.Graphics.DrawString("Item", new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(100, 150));
            e.Graphics.DrawString("Quantity", new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(350, 150));
            e.Graphics.DrawString("Price", new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(450, 150));

            int yCounter = 175;

            foreach (var m in transaction.medicines)
            {
                e.Graphics.DrawString(m.name, new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(100, yCounter));
                e.Graphics.DrawString(m.quantity.ToString(), new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(350, yCounter));
                e.Graphics.DrawString(m.price.ToString(), new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(450, yCounter));
                yCounter += 25;
            }

            foreach (var m in transaction.medicalSupplies)
            {
                e.Graphics.DrawString(m.name, new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(100, yCounter));
                e.Graphics.DrawString(m.quantity.ToString(), new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(350, yCounter));
                e.Graphics.DrawString(m.price.ToString(), new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(450, yCounter));
                yCounter += 25;
            }

            yCounter += 150;

            e.Graphics.DrawString("Payment", new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(530, yCounter));
            e.Graphics.DrawString("Total", new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(530, yCounter));
            e.Graphics.DrawString("Change", new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(530, yCounter));

            e.Graphics.DrawString(txtPayment.Text, new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(650, yCounter));
            e.Graphics.DrawString(txtTotal.Text, new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(650, yCounter));
            e.Graphics.DrawString(txtChange.Text, new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(650, yCounter));

        }

        private void PrintReceipt()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void POS_Load(object sender, EventArgs e)
        {
        }
    }
}
