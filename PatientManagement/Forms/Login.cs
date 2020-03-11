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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        User currentUser = null;

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if(isValidUser())
            {
                SuccessfulLogin();
                return;
            }

            MessageBox.Show("Incorrect Credentials");
        }

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
                    new Forms.DoctorForm.CheckUpList(currentUser).ShowDialog();
                    //OUT-PATIENT DOCTOR
                    break;
                case 1:
                    new Forms.DoctorForm.AdmissionList(currentUser).ShowDialog();
                    //IN-PATIENT DOCTOR
                    break;
                case 2:
                    new Forms.NurseForm.OutNurseMain(currentUser).ShowDialog();
                    //OUT-PATIENT NURSE
                    break;
                case 3:
                    new Forms.NurseForm.InNurseMain(currentUser).ShowDialog();
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
                    new Forms.Laboratory.LaboratoryList().ShowDialog();
                    //LABORATORY
                    break;
                case 8:
                    new Forms.CentralSupply.CentralSupply().ShowDialog();
                    break;
            }
        }
    }
}
