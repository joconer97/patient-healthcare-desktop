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
    public partial class CashierMain : MetroFramework.Forms.MetroForm
    {
        public CashierMain()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Forms.Cashier.POS().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Forms.Cashier.Payment().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Forms.Cashier.PatientRegistrationList().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Forms.Cashier.LaboratoryRequest().ShowDialog();
        }
    }
}
