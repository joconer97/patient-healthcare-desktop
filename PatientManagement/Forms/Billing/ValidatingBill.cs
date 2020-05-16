using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.Billing
{
    public partial class ValidatingBill : MetroFramework.Forms.MetroForm
    {
        decimal totalAmount = 0;
        decimal validatedAmount = 0;
        Classes.DischargeRequest request = null;
        int totalStay = 0;
        public ValidatingBill(decimal totalAmount,Classes.DischargeRequest request)
        {
            InitializeComponent();
            this.totalAmount = totalAmount;
            this.request = request;
            txtTotalBill.Text = totalAmount.ToString();
            InitTotalStay();
        }

        private void txtCover_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void InitTotalStay()
        {
            totalStay = (int)(DateTime.Now - request.admission.admittedDate).TotalDays;
            txtTotalStay.Text = totalStay.ToString();
        }

        private void txtCover_TextChanged(object sender, EventArgs e)
        {
            if (txtCover.Text == "")
            {
                txtTotalBill.Text = (totalAmount + totalStay * ((txtRate.Text == "")?0:Int32.Parse(txtRate.Text))).ToString(); ;
                return;
            }

            validatedAmount = (totalAmount - (decimal.Parse(txtCover.Text)));

            txtTotalBill.Text = validatedAmount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.RequestHelper.SaveDishargeRequest(new Classes.DischargeRequest()
            {
                id = request.id,
                status = "Validated",
                philhealthCode = txtPhilhealth.Text,
                philhealthCover = decimal.Parse(txtCover.Text),
                isPaid = 0,
                admission = request.admission,
                rate = (txtRate.Text == "") ? 0 : Int32.Parse(txtRate.Text)
            });

            MessageBox.Show("Successfully updated");

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (txtRate.Text == "")
            {
                validatedAmount = (totalAmount - ((txtCover.Text == "") ? 0 : decimal.Parse(txtCover.Text)));
                txtTotalBill.Text = validatedAmount.ToString();
                return;
            }

            validatedAmount = totalAmount + totalStay * Int32.Parse(txtRate.Text);
            txtTotalBill.Text = validatedAmount.ToString();
        }
    }
}
