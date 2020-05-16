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
    public partial class DischargeModal : MetroFramework.Forms.MetroForm
    {
        Classes.DischargeRequest request = null;
        List<Classes.Bill> bills = null;
        int totalStay = 0;
        decimal totalAmount = 0;
        decimal change = 0;
        public DischargeModal(Classes.DischargeRequest request)
        {
            InitializeComponent();
            this.request = request;
        }
        private void InitListView()
        {
            lsvSummary.Columns.Add("PIN", 200);
            lsvSummary.Columns.Add("Fullname", 280);
            lsvSummary.Columns.Add("Type", 100);
            lsvSummary.Columns.Add("Price", 50);
            lsvSummary.Columns.Add("Date", 50);




            lsvSummary.View = View.Details;
            lsvSummary.GridLines = true;
            lsvSummary.FullRowSelect = true;
            lsvSummary.HideSelection = false;
            lsvSummary.MultiSelect = false;
        }

        private void PopulateList()
        {
            ListViewItem item;

            bills = Classes.BillHelper.GetSummaryBills(this.request.admission.id);

            foreach (var b in bills)
            {
                item = lsvSummary.Items.Add(request.admission.patient.id);
                item.SubItems.Add(request.admission.patient.firstname + " " + request.admission.patient.lastname);
                item.SubItems.Add(b.type);
                item.SubItems.Add(b.total.ToString());
                item.SubItems.Add(b.date.ToShortDateString());
                totalAmount += b.total;
            }

        }

        private void DischargeModal_Load(object sender, EventArgs e)
        {
            InitListView();
            PopulateList();
            InitTotalStay();
            ComputePrice();
        }

        private void ComputePrice()
        {

            totalAmount += request.rate * totalStay;
            txtTotal2.Text = totalAmount.ToString();
            totalAmount -= request.philhealthCover;
            txtTotal.Text = totalAmount.ToString();
        }

        private void InitTotalStay()
        {
            totalStay = (int)(DateTime.Now - request.admission.admittedDate).TotalDays;
            txtNoStay.Text = totalStay.ToString();
            txtRate.Text = request.rate.ToString();
            txtphilhealth.Text = request.philhealthCover.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if(MessageBox.Show("Do you want to continue?","PHC",MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            UpdateBill();
            PrintReceipt();
            

        }

        private void UpdateBill()
        {
            Firebase.Firebase firebase = new Firebase.Firebase();

            foreach (var b in bills)
            {
                b.isPaid = 1;
                Classes.BillHelper.SaveBill(b);
                b.patient = request.admission.patient;
                firebase.UpdateBill(b);
            }
        }


        private void PrintReceipt()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //for (int x = 0; x < 1000; x += 50)
            //{
            //    e.Graphics.DrawString(x.ToString(), new Font("Times new roman", 11, FontStyle.Bold), Brushes.Black, new Point(x, 10));
            //}

            //for (int y = 0; y < 1000; y += 50)
            //{
            //    e.Graphics.DrawString(y.ToString(), new Font("Times new roman", 11, FontStyle.Bold), Brushes.Black, new Point(10, y));
            //}
            //header
            e.Graphics.DrawString("Naga City Hospital", new Font("Times new roman", 15, FontStyle.Bold), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString("Penafrancia Ave, Baranagay Peñafrancia, Naga, 4400 Camarines Sur", new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(200, 80));


            //body
            e.Graphics.DrawString("PIN : ", new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(100, 150));
            e.Graphics.DrawString("NAME : ", new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(100, 180));
            e.Graphics.DrawString("PHILHEALTH : ", new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(100, 210));


            e.Graphics.DrawString(request.admission.patient.id, new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(150, 150));
            e.Graphics.DrawString(request.admission.patient.firstname + " " + request.admission.patient.lastname, new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(150, 180));
            e.Graphics.DrawString(request.philhealthCode, new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(200, 210));


            //bill header
            e.Graphics.DrawString("DATE", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(100, 300));
            e.Graphics.DrawString("TYPE", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(200, 300));
            e.Graphics.DrawString("PRICE", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(300, 300));

            //bill body
            int counter = 340;
            foreach (var b in bills)
            {
                e.Graphics.DrawString(b.date.ToShortDateString(), new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(100,counter));
                e.Graphics.DrawString(b.type, new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(200, counter));
                e.Graphics.DrawString(b.total.ToString(), new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(300, counter));

                counter += 20;
            }

            counter += 30;
            //final header
            e.Graphics.DrawString("No. of stay :", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(100, counter + 30));
            e.Graphics.DrawString("Room Rate :", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(100, counter + 60));

            e.Graphics.DrawString((DateTime.Now.Day - request.admission.admittedDate.Day).ToString(), new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(200, counter + 30));
            e.Graphics.DrawString(request.rate.ToString(), new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(200, counter + 60));

            e.Graphics.DrawString("TOTAL :", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(550, counter + 30));
            e.Graphics.DrawString("PHILHEALTH :", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(550, counter + 60));
            e.Graphics.DrawString("PAYMENT :", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(550, counter + 90));
            e.Graphics.DrawString("CHANGE :", new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(550, counter + 120));

            e.Graphics.DrawString(totalAmount.ToString(), new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(620, counter + 30));
            e.Graphics.DrawString(request.philhealthCover.ToString(), new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(670, counter + 60));
            e.Graphics.DrawString(txtPayment.Text, new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(650, counter + 90));
            e.Graphics.DrawString(txtChange.Text, new Font("Times new roman", 10, FontStyle.Bold), Brushes.Black, new Point(650, counter + 120));
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            if (txtPayment.Text == "")
                return;

            change = Int32.Parse(txtPayment.Text) - totalAmount;

            txtChange.Text = change.ToString();
        }
    }
}
