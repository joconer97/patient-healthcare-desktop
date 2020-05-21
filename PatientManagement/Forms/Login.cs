using PatientManagement.Classes;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        User currentUser = null;

        private bool isValidUser()
        {
            User user = new User();

            user.username = txtUsername.Text;
            user.password = txtPassword.Text;

            currentUser = UserHelper.login(user.username, user.password);

            if (currentUser != null)
            {
                return true;
            }

            return false;
        }

        private void SuccessfulLogin()
        {
            int department = comboBox1.SelectedIndex;

            switch (department)
            {
                case 0:
                    if(currentUser.position != "OPD-DOCTOR")
                    {
                        MessageBox.Show("Incorrect Credentials");
                        return;
                    }
                    this.Hide();
                    new Forms.DoctorForm.OutPatientMain(currentUser).ShowDialog();
                    new Login().ShowDialog();
                    //OUT-PATIENT DOCTOR
                    break;
                case 1:
                    if (currentUser.position != "INPATIENT-DOCTOR")
                    {
                        MessageBox.Show("Incorrect Credentials");
                        return;
                    }
                    this.Hide();
                    new Forms.DoctorForm.InPatientMain(currentUser).ShowDialog();
                    new Login().ShowDialog();
                    //IN-PATIENT DOCTOR
                    break;
                case 2:
                    if (currentUser.position != "OPD-NURSE")
                    {
                        MessageBox.Show("Incorrect Credentials");
                        return;
                    }
                    this.Hide();
                    new Forms.NurseForm.OutNurseMain(currentUser).ShowDialog();
                    new Login().ShowDialog();
                    //OUT-PATIENT NURSE
                    break;
                case 3:
                    if (currentUser.position != "INPATIENT-NURSE")
                    {
                        MessageBox.Show("Incorrect Credentials");
                        return;
                    }
                    this.Hide();
                    new Forms.NurseForm.InNurseMain(currentUser).ShowDialog();
                    new Login().ShowDialog();
                    //IN-PATIENT NURSE
                    break;
                case 4:
                    if (currentUser.position != "PHARMACY")
                    {
                        MessageBox.Show("Incorrect Credentials");
                        return;
                    }
                    this.Hide();
                    new Forms.Pharmacy.Pharmacy().ShowDialog();
                    new Login().ShowDialog();
                    //PHARMACY
                    break;
                case 5:
                    if (currentUser.position != "BILLING")
                    {
                        MessageBox.Show("Incorrect Credentials");
                        return;
                    }
                    this.Hide();
                    new Forms.Billing.Billing().ShowDialog();
                    new Login().ShowDialog();
                    //BILLING
                    break;
                case 6:
                    if (currentUser.position != "CASHIER")
                    {
                        MessageBox.Show("Incorrect Credentials");
                        return;
                    }
                    this.Hide();
                    new Forms.Cashier.CashierMain().ShowDialog();
                    new Login().ShowDialog();
                    //CASHIER
                    break;
                case 7:
                    if (currentUser.position != "LABORATORY")
                    {
                        MessageBox.Show("Incorrect Credentials");
                        return;
                    }
                    this.Hide();
                    new Forms.Laboratory.LaboratoryList().ShowDialog();
                    new Login().ShowDialog();
                    //LABORATORY
                    break;
                case 8:
                    if (currentUser.position != "CSR-CLERK")
                    {
                        MessageBox.Show("Incorrect Credentials");
                        return;
                    }
                    this.Hide();
                    new Forms.CentralSupply.CentralSupply().ShowDialog();
                    new Login().ShowDialog();
                    break;
                case 9:
                    if (currentUser.position != "RECORDS")
                    {
                        MessageBox.Show("Incorrect Credentials");
                        return;
                    }
                    this.Hide();
                    new Forms.Medical.MenuRecords().ShowDialog();
                    new Login().ShowDialog();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValidUser())
            {
                SuccessfulLogin();
                return;
            }

            MessageBox.Show("Incorrect Credentials");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
