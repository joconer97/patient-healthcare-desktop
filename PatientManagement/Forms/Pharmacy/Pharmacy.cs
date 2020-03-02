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
    }
}
