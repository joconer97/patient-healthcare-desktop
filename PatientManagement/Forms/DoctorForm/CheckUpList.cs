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
    public partial class CheckUpList : Form
    {
        public CheckUpList()
        {
            InitializeComponent();
            InitializeList();
            PopulateList();
        }
        List<Classes.Checkup> checkups = new List<Classes.Checkup>();
        private void InitializeList()
        {
            lsvCheckup.Columns.Add("#", 30);
            lsvCheckup.Columns.Add("PIN", 200);
            lsvCheckup.Columns.Add("Fullname", 200);
            lsvCheckup.Columns.Add("Sex", 50);
            lsvCheckup.Columns.Add("Age", 100);
            lsvCheckup.Columns.Add("Blood Pressure", 200);
            lsvCheckup.Columns.Add("Temperature °C", 200);
            lsvCheckup.Columns.Add("Pulse Rate", 200);
            lsvCheckup.Columns.Add("Time Arrived", 150);



            lsvCheckup.View = View.Details;
            lsvCheckup.GridLines = true;
            lsvCheckup.FullRowSelect = true;
            lsvCheckup.HideSelection = false;
            lsvCheckup.MultiSelect = false;
        }

        private void PopulateList()
        {
            int ctr = 0;
            checkups = Classes.CheckupHelper.ListCheckup();
            lsvCheckup.Items.Clear();
            ListViewItem item;
            
            foreach (var c in checkups)
            {
                item = lsvCheckup.Items.Add((++ctr).ToString());
                item.SubItems.Add(c.patientID);
                item.SubItems.Add(c.patient.firstname + " " + c.patient.lastname);
                item.SubItems.Add(c.patient.gender.ToString());
                item.SubItems.Add((DateTime.Now.Year - c.patient.birthdate.Year).ToString());
                item.SubItems.Add(c.blood_pressure);
                item.SubItems.Add(c.temperature);
                item.SubItems.Add(c.pulse_rate);
                item.SubItems.Add(c.time_arrived.ToString());

            }
        }

        private void lsvCheckup_DoubleClick(object sender, EventArgs e)
        {
            int si = 0;
            try
            {
                si = lsvCheckup.SelectedItems[0].Index;
            }
            catch
            {
                
            }
            Form form = new DoctorForm.CheckUP();
            form.ShowDialog();
            MessageBox.Show(checkups[si].patient.firstname);
        }
    }
}
