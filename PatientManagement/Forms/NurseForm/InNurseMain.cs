using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.NurseForm
{
    public partial class InNurseMain : MetroFramework.Forms.MetroForm
    {
        Classes.User currentUser = null;
        public InNurseMain(Classes.User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new InpatientAdmissionList(currentUser).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Forms.PatientForm.AdmissionRequestList(currentUser).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Forms.Laboratory.LaboratoryResultList().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
