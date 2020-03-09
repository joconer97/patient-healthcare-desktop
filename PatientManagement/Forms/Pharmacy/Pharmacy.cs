using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.Pharmacy
{
    public partial class Pharmacy : MetroFramework.Forms.MetroForm
    {
        public Pharmacy()
        {
            InitializeComponent();
            InitListView();
            PopulateList();
            InitListView2();
            PopulateListView2();
        }

        List<Classes.Bill> request = null;

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

        private void InitListView2()
        {
            lsvMedicineRequest.Columns.Add("#", 200);
            lsvMedicineRequest.Columns.Add("Firstname", 200);
            lsvMedicineRequest.Columns.Add("Middlename", 280);
            lsvMedicineRequest.Columns.Add("Lastname", 280);



            lsvMedicineRequest.View = View.Details;
            lsvMedicineRequest.GridLines = true;
            lsvMedicineRequest.FullRowSelect = true;
            lsvMedicineRequest.HideSelection = false;
            lsvMedicineRequest.MultiSelect = false;
        }

        private void PopulateListView2()
        {
            request = Classes.BillHelper.BillList();

            ListViewItem item;
            int ctr = 0;
            foreach(var p in request)
            {
                item = lsvMedicineRequest.Items.Add((++ctr).ToString());
                item.SubItems.Add(p.patient.firstname);
                item.SubItems.Add(p.patient.middlename);
                item.SubItems.Add(p.patient.lastname);
            }
        }


        
        private void PopulateList()
        {
            ListViewItem item;
            lsvMedicine.Items.Clear();
            int counter = 1;
            List<Classes.Medicine> medicines = Classes.MedicineHelper.Medicines();

            
            foreach(var m in medicines)
            {
                item = lsvMedicine.Items.Add((counter++).ToString());
                item.SubItems.Add(m.name);
                item.SubItems.Add(m.price.ToString());
                item.SubItems.Add(m.quantity.ToString());
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "excel files (*.xls)|*.xlsx*";
            if(openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

 
            string path = openFileDialog.FileName;
            FileInfo fileInfo = new FileInfo(path);

            ExcelPackage package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

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

                    Classes.MedicineHelper.SaveMedicine(new Classes.Medicine()
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


            MessageBox.Show(counter + " medicines have been saved");

        }

        private void lsvMedicineRequest_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                index = lsvMedicineRequest.SelectedItems[0].Index;
            }
            catch (Exception)
            {

                throw;
            }

            new Forms.Pharmacy.MedicineRequest(request[index].admittedID).ShowDialog();
        }
    }
}
