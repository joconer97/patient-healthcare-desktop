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
    public partial class PatientRegistrationPayment : Form
    {
        Classes.Patient patient = null;
        public PatientRegistrationPayment(Classes.Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            DisplayingPatientInfo();

        }

        private void DisplayingPatientInfo()
        {
            txtFirstname.Text = patient.firstname;
            txtMiddleName.Text = patient.middlename;
            txtLastname.Text = patient.lastname;
            cmbGender.Text = patient.gender.ToString();
            txtBirthplace.Text = patient.birthplace;
            txtOccupation.Text = patient.occupation;
            txtReligion.Text = patient.religion;
            txtAddress.Text = patient.address;
            txtEmergencyContact.Text = patient.emergency_contact;
            dtpBirthdate.Value = patient.birthdate;
            txtContact.Text = patient.contact;
            txtCitizenship.Text = patient.citizenship;

            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //for (int x = 0; x < 1000; x += 50)
            //{
            //    e.Graphics.DrawString(x.ToString(), new Font("Times new roman", 11, FontStyle.Bold), Brushes.Black, new Point(x, 10));
            //}

            //for (int y = 0; y < 1000; y += 50)
            //{
            //    e.Graphics.DrawString(y.ToString(), new Font("Times new roman", 11, FontStyle.Bold), Brushes.Black, new Point(10, y));
            //}
            //header
            e.Graphics.DrawString("Naga City Hospital", new Font("Times new roman", 15, FontStyle.Bold), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString("Penafrancia Ave, Baranagay Peñafrancia, Naga, 4400 Camarines Sur", new Font("Times new roman", 12, FontStyle.Bold), Brushes.Black, new Point(200, 80));
            e.Graphics.DrawString("Patient Membership ID", new Font("Times new roman", 15, FontStyle.Bold), Brushes.Black, new Point(300, 120));


            //body
            e.Graphics.DrawString(patient.lastname, new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(50, 185 + 10));
            e.Graphics.DrawString(patient.firstname, new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(300, 185 + 10));
            e.Graphics.DrawString(patient.middlename, new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(500, 185 + 10));
            e.Graphics.DrawString("LASTNAME", new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(50, 220 + 10));
            e.Graphics.DrawString("FIRSTNAME", new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(300, 220 + 10));
            e.Graphics.DrawString("MIDDLENAME", new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(500, 220 + 10));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(50, 210 + 10), new Point(760, 210 + 10));

            //ADDRESS
            e.Graphics.DrawString(patient.address, new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(110, 260));
            e.Graphics.DrawString("Address : ", new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(50, 260));

            e.Graphics.DrawString(patient.contact, new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(400+patient.address.Length, 260));
            e.Graphics.DrawString("Contact: ", new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(350 + patient.address.Length, 260));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(50, 280), new Point(760, 280));

            e.Graphics.DrawString("Birthdate & Birthplace : ", new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(50, 260 + 50));
            e.Graphics.DrawString(patient.birthdate.ToShortDateString() + " & " + patient.birthplace, new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(200, 260 + 50));

            e.Graphics.DrawString("Gender: ", new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(420 + patient.address.Length, 260 + 50));
            e.Graphics.DrawString(patient.gender.ToString(), new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(470 + patient.address.Length, 260 + 50));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(50, 280 + 50), new Point(760, 280 + 50));


            //PIN
            e.Graphics.DrawString("PIN :" + patient.id, new Font("Times new roman", 10, FontStyle.Regular), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(50, 170), new Point(350, 170));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            (printPreviewDialog1 as Form).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            Classes.PatientHelper.MembershipStatus(patient);

            MessageBox.Show("Identification card is printing.....");

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
