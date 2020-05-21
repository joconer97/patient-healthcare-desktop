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
    public partial class PaymentModal : MetroFramework.Forms.MetroForm
    {
        Classes.LaboratoryRequest request = null;
        public PaymentModal(Classes.LaboratoryRequest request)
        {
            InitializeComponent();
            this.request = request;
            FillUpTextBox();
        }

        private void FillUpTextBox()
        {
            txtPatient.Text = request.patient.firstname + " " + request.patient.middlename + " " + request.patient.lastname;
            txtPatientID.Text = request.patient.id;
            txtPatientID2.Text = request.patient.id;
            txtPrice.Text = request.price.ToString();
            txtRequester.Text = request.user.firstname + " " + request.user.lastname;
        }

        private void rdbCash_CheckedChanged(object sender, EventArgs e)
        {
            panelCash.Visible = true;
            panel1.Visible = false;
        }

        private void rdbBill_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelCash.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            decimal payment = decimal.Parse(txtPayment.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            if(payment < price)
            {
                MessageBox.Show("Insufficient payment");
                return;
            }

            Classes.TransactionHelper.SaveTransaction(new Classes.Transaction()
            {
                type = "Laboratory",
                typeID = request.id,
                status = "Cash",
                date = DateTime.Now
            });

            request.isPaid = "Paid";
            Classes.LaboratoryRequestHelper.SaveLaboratoryRequest(request);

            MessageBox.Show("Sucessful transaction");
            PrintReceipt();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void PrintReceipt()
        {
            (printPreviewDialog1 as Form).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtChange.Text = (Int32.Parse(txtPayment.Text) - Int32.Parse(txtPrice.Text)).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Classes.Admission admission = Classes.AdmissionHelper.SearchAdmission(txtPatientID.Text);
            Firebase.Firebase firebase = new Firebase.Firebase();

            int transactionID = Classes.TransactionHelper.SaveTransaction(new Classes.Transaction()
            {
                type = "Laboratory",
                typeID = request.id,
                status = "Bill",
                date = DateTime.Now
            });

            int tempID = Classes.BillHelper.SaveBill(new Classes.Bill()
            {
                id = 0,
                admittedID = admission.id,
                transactionID = transactionID,
                isPaid  = 0,
            });

            firebase.InsertBill(new Classes.Bill()
            {
                id = tempID,
                name = "Laboratory",
                type = "Laboratory",
                patient = new Classes.Patient()
                {
                    id = txtPatientID.Text
                },
                total = decimal.Parse(txtPrice.Text),
                isPaid = 0,
                admittedID = admission.id,
                date = DateTime.Now
            });

            request.isPaid = "Paid";
            Classes.LaboratoryRequestHelper.SaveLaboratoryRequest(request);

            MessageBox.Show("Sucessful transaction");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Naga City Hospital", new Font("Times new roman", 15, FontStyle.Bold), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString("Penafrancia Ave, Baranagay Peñafrancia, Naga, 4400 Camarines Sur", new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(200, 80));


            //body
            e.Graphics.DrawString("PIN : ", new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(100, 150));
            e.Graphics.DrawString("NAME : ", new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(100, 180));


            e.Graphics.DrawString(request.patient.id, new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(150, 150));
            e.Graphics.DrawString(request.patient.firstname + " " + request.patient.lastname, new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(150, 180));
          


            //bill header
            e.Graphics.DrawString("DATE", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(100, 300));
            e.Graphics.DrawString("TYPE", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(200, 300));
            e.Graphics.DrawString("PRICE", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(300, 300));

            //bill body
            int counter = 340;

            e.Graphics.DrawString(request.date.ToShortDateString(), new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(100, counter));
            e.Graphics.DrawString(request.type, new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(200, counter));
            e.Graphics.DrawString(txtPrice.Text, new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(300, counter));

                counter += 20;


            counter += 30;
            //final header

            e.Graphics.DrawString("TOTAL :", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(550, counter + 30));
            e.Graphics.DrawString("PAYMENT :", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(550, counter + 90));
            e.Graphics.DrawString("CHANGE :", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(550, counter + 120));

            e.Graphics.DrawString(txtPrice.ToString(), new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(620, counter + 30));
            e.Graphics.DrawString(txtPayment.Text, new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(650, counter + 90));
            e.Graphics.DrawString(txtChange.Text, new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(650, counter + 120));
        }
    }
}
