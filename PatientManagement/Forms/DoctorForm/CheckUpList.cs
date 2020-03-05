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
    public partial class CheckUpList : MetroFramework.Forms.MetroForm
    {
        Classes.User currentUser = null;
        public CheckUpList(Classes.User user)
        {
            InitializeComponent();
            InitializeList();
            PopulateList();
            currentUser = user;
            label2.Text = "Dr. " + user.firstname + " " + user.lastname;
        }
        List<Classes.Checkup> checkups = new List<Classes.Checkup>();
        private void InitializeList()
        {
            lsvCheckup.Columns.Add("PIN", 200);
            lsvCheckup.Columns.Add("Fullname", 280);
            lsvCheckup.Columns.Add("Sex", 30);
            lsvCheckup.Columns.Add("Age", 50);
            lsvCheckup.Columns.Add("Blood Pressure", 100);
            lsvCheckup.Columns.Add("Temperature °C", 100);
            lsvCheckup.Columns.Add("Pulse Rate", 100);
            lsvCheckup.Columns.Add("Time Arrived", 150);
            lsvCheckup.Columns.Add("Type", 150);



            lsvCheckup.View = View.Details;
            lsvCheckup.GridLines = true;
            lsvCheckup.FullRowSelect = true;
            lsvCheckup.HideSelection = false;
            lsvCheckup.MultiSelect = false;
            lsvCheckup.BackColor = Color.AliceBlue;
        }

        private void PopulateList()
        {
            checkups = Classes.CheckupHelper.ListCheckup();
            int ctr = 0;
            lsvCheckup.Items.Clear();
            ListViewItem item;
            
            foreach (var c in checkups)
            {
                item = lsvCheckup.Items.Add(c.patientID);
                item.SubItems.Add(c.patient.firstname + " " + c.patient.lastname);
                item.SubItems.Add(c.patient.gender.ToString());
                item.SubItems.Add((DateTime.Now.Year - c.patient.birthdate.Year).ToString());
                item.SubItems.Add(c.blood_pressure);
                item.SubItems.Add(c.temperature);
                item.SubItems.Add(c.pulse_rate);
                item.SubItems.Add(c.time_arrived.ToString());
                item.SubItems.Add((ctr % 2 == 0)?"Follow-up":"Check-up");
                ctr++;

            }
        }


        private void lsvCheckup_DoubleClick_1(object sender, EventArgs e)
        {
            int si = 0;
            try
            {
                si = lsvCheckup.SelectedItems[0].Index;
            }
            catch
            {

            }
            checkups[si].user = currentUser;
            Form form = new DoctorForm.CheckUP(checkups[si]);

            if(form.ShowDialog() == DialogResult.OK)
            {
                PopulateList();
            }
        }
    }
}
