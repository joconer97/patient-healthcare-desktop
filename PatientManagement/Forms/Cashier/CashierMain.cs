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
    public partial class CashierMain : Form
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
    }
}
