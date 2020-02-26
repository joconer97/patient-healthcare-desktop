using PatientManagement.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            int department = comboBox1.SelectedIndex;

            switch (department)
            {
                case 0:
                    new Forms.DoctorForm.CheckUpList().ShowDialog();
                    //OUT-PATIENT DOCTOR
                    break;
                case 1:
                    new Forms.DoctorForm.AdmissionList().ShowDialog();
                    //IN-PATIENT DOCTOR
                    break;
                case 2:
                    new Forms.NurseForm.NurseMain().ShowDialog();
                    //OUT-PATIENT NURSE
                    break;
                case 3:
                    new Forms.NurseForm.InNurseMain().ShowDialog();
                    //IN-PATIENT NURSE
                    break;
                case 4:
                    new Forms.Pharmacy.Pharmacy().ShowDialog();
                    //PHARMACY
                    break;
                case 5:
                    new Forms.Billing.Billing().ShowDialog();
                    //BILLING
                    break;
                case 6:
                    new Forms.Cashier.CashierMain().ShowDialog();
                    //CASHIER
                    break;
                case 7:
                    //new Forms
                    //LABORATORY
                    break;
            }
            //User user = new User();

            //user.username = txtUsername.Text;
            //user.password = txtPassword.Text;

            //if (user.isValid())
            //{
            //    MessageBox.Show("Successfully Login");
            //    Form form = new NurseForm.NurseMain();

            //    this.Hide();
            //    form.ShowDialog();
            //    this.Close();

            //    return;
            //}

            //MessageBox.Show("Failed to Login");
        }
    }
}
