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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.username = txtUsername.Text;
            user.password = txtPassword.Text;

            if(user.isValid())
            {
                MessageBox.Show("Successfully Login");
                Form form = new NurseForm.NurseMain();

                this.Hide();
                form.ShowDialog();
                this.Close();

                return;
            }

            MessageBox.Show("Failed to Login");

        }
    }
}
