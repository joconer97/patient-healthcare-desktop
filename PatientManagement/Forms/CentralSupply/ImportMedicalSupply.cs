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

namespace PatientManagement.Forms.CentralSupply
{
    public partial class ImportMedicalSupply : MetroFramework.Forms.MetroForm
    {
        public ImportMedicalSupply()
        {
            InitializeComponent();
            Init();
        }
        List<Classes.MedicalSupply> medicalSupplies = new List<Classes.MedicalSupply>();
        private void btnOpenExcel_Click(object sender, EventArgs e)
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

            // get number of rows and columns in the sheet
            int rows = worksheet.Dimension.Rows; // 20
            int columns = worksheet.Dimension.Columns; // 7
            int counter = 0;
            // loop through the worksheet rows and columns
            for (int i = 2; i <= rows; i++)
            {
                decimal currentPrice = new Random().Next(100, 1000);
                string currentName = "";

                try
                {
                    currentName = worksheet.Cells["A" + i].Value.ToString();

                    medicalSupplies.Add(new Classes.MedicalSupply
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
        }
        private void SaveMedicalSupply()
        {
            foreach (var m in medicalSupplies)
            {
                Classes.MedicalSupplyHelper.SaveMedical(m);
            }
            MessageBox.Show("Saved");
        }

        private void Init()
        {
            lsvMedical.Columns.Add("#", 200);
            lsvMedical.Columns.Add("Name", 200);
            lsvMedical.Columns.Add("Price", 280);
            lsvMedical.Columns.Add("Quantity", 280);



            lsvMedical.View = View.Details;
            lsvMedical.GridLines = true;
            lsvMedical.FullRowSelect = true;
            lsvMedical.HideSelection = false;
            lsvMedical.MultiSelect = false;
        }
        private void PopulateList()
        {
            ListViewItem item;
            lsvMedical.Items.Clear();

            foreach (var m in medicalSupplies)
            {
                item = lsvMedical.Items.Add(m.id.ToString());
                item.SubItems.Add(m.name);
                item.SubItems.Add(m.price.ToString());
                item.SubItems.Add(m.quantity.ToString());
            }
        }


        private void btn_Click(object sender, EventArgs e)
        {
            SaveMedicalSupply();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
