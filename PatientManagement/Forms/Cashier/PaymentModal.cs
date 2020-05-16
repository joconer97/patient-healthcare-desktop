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
            Classes.TransactionHelper.SaveTransaction(new Classes.Transaction()
            {
                type = "Laboratory",
                typeID = request.id,
                status = "Cash",
                date = DateTime.Now
            });

            request.isPaid = "Paid";
            Classes.LaboratoryRequestHelper.SaveLaboratoryRequest(request);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
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
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
