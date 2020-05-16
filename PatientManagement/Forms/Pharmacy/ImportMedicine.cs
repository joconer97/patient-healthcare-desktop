using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManagement.Firebase;
using Newtonsoft.Json;

namespace PatientManagement.Forms.Pharmacy
{
    public partial class ImportMedicine : Form
    {
        public ImportMedicine()
        {
            InitializeComponent();
            InitListView();
        }
        List<Classes.Medicine> medicines = new List<Classes.Medicine>();
    
        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "excel files (*.xls)|*.xlsx*";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string path = openFileDialog.FileName;
            FileInfo fileInfo = new FileInfo(path);

            ExcelPackage package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
            List<string> medicineJson = new List<string>();
            // get number of rows and columns in the sheet
            int rows = worksheet.Dimension.Rows; // 20
            int columns = worksheet.Dimension.Columns; // 7
            int counter = 0;
            // loop through the worksheet rows and columns
            for (int i = 1; i <= rows; i++)
            {
                decimal currentPrice = 0;
                string currentName = "";

                try
                {
                    currentPrice = decimal.Parse(worksheet.Cells["E" + i].Value.ToString());
                    currentName = worksheet.Cells["C" + i].Value.ToString();
                    medicineJson.Add(currentName);

                    medicines.Add(new Classes.Medicine()
                    {
                        price = currentPrice,
                        quantity = new Random().Next(1, 20),
                        name = currentName

                    });

                    counter++;
                }
                catch (Exception)
                {

                }
            }

            PopulateList();
            btnSave.Enabled = true;
        }

        private void PopulateList()
        {
            ListViewItem item;
            lsvMedicine.Items.Clear();
            int counter = 1;

            foreach (var m in medicines)
            {
                item = lsvMedicine.Items.Add((counter++).ToString());
                item.SubItems.Add(m.name);
                item.SubItems.Add(m.price.ToString());
                item.SubItems.Add(m.quantity.ToString());
            }
        }

        private void InitListView()
        {
            lsvMedicine.Columns.Add("ID", 200);
            lsvMedicine.Columns.Add("Name", 200);
            lsvMedicine.Columns.Add("Price", 280);
            lsvMedicine.Columns.Add("Quantity", 280);



            lsvMedicine.View = View.Details;
            lsvMedicine.GridLines = true;
            lsvMedicine.FullRowSelect = true;
            lsvMedicine.HideSelection = false;
            lsvMedicine.MultiSelect = false;
        }
        private void SaveMedicines()
        {
            foreach (var m in medicines)
            {
                Classes.MedicineHelper.SaveMedicine(new Classes.Medicine()
                {
                    price = m.price,
                    name = m.name,
                    quantity = m.quantity
                });
            }

            List<Classes.Medicine> tempMedicines = Classes.MedicineHelper.Medicines();
            SaveToFirebase(tempMedicines);
            MessageBox.Show("Sucessfully saved!");
            btnSave.Enabled = false;
        }

        private void SaveToFirebase(List<Classes.Medicine> tempMedicines)
        {
            Firebase.Firebase firebase = new Firebase.Firebase();

            firebase.InsertMedicine(tempMedicines);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveMedicines();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
