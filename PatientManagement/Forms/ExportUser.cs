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

namespace PatientManagement.Forms
{
    public partial class ExportUser : Form
    {
        public ExportUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            // loop through the worksheet rows and columns
            for (int i = 2; i <= rows; i++)
            {
                decimal currentPrice = new Random().Next(100, 1000);
                string currentUserName = "";
                string currentPassword = "";
                string currentFirstName = "";
                string currentLastName = "";
                string currentPosition = "";

                try
                {
                    currentUserName = worksheet.Cells["A" + i].Value.ToString();
                    currentPassword = worksheet.Cells["B" + i].Value.ToString();
                    currentFirstName = worksheet.Cells["C" + i].Value.ToString();
                    currentLastName = worksheet.Cells["D" + i].Value.ToString();
                    currentPosition = worksheet.Cells["E" + i].Value.ToString();

                    Classes.UserHelper.SaveUser(new Classes.User()
                    {
                        username = currentUserName,
                        password = currentPassword,
                        firstname = currentFirstName,
                        lastname = currentLastName,
                        position = currentPosition

                    });

                }
                catch (Exception)
                {

                }
            }
        }
    }
}
