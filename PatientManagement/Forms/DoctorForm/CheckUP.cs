using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.DoctorForm
{
    public partial class CheckUP : MetroFramework.Forms.MetroForm
    {
        public CheckUP(Classes.Checkup checkup)
        {
            InitializeComponent();
            txtFullname.Text = checkup.patient.firstname + " " + checkup.patient.lastname;
            txtGender.Text = checkup.patient.gender.ToString();
            txtAge.Text = (DateTime.Now.Year - checkup.patient.birthdate.Year).ToString();
            txtBP.Text = checkup.blood_pressure;
            txtPR.Text = checkup.pulse_rate;
            txtTemp.Text = checkup.temperature + "°C";
        }

        private void CheckUP_Load(object sender, EventArgs e)
        {
            
        }
    }
}
