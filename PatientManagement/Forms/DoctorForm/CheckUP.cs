using Newtonsoft.Json;
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

namespace PatientManagement.Forms.DoctorForm
{
    public partial class CheckUP : MetroFramework.Forms.MetroForm
    {
        List<string> medicines = new List<string>();
        List<Classes.Prescription> prescriptions = new List<Classes.Prescription>();
        int id = 0;
        string cc = "";
        int doctorID = 0;
        Classes.Patient currentPatient;
        Classes.Checkup checkup = null;
        public CheckUP(Classes.Checkup checkup)
        {
            InitializeComponent();
            id = checkup.id;
            doctorID = checkup.user.id;
            this.checkup = checkup;
            currentPatient = checkup.patient;
            txtFullname.Text = checkup.patient.firstname + " " + checkup.patient.lastname;
            txtGender.Text = checkup.patient.gender.ToString();
            txtAge.Text = (DateTime.Now.Year - checkup.patient.birthdate.Year).ToString();
            txtBP.Text = checkup.blood_pressure;
            txtPR.Text = checkup.pulse_rate;
            txto2sat.Text = checkup.o2sat;
            txtrr.Text = checkup.respiratory_rate;
            txtGCS.Text = checkup.gcs;
            cc = checkup.cc;
            txtTemp.Text = checkup.temperature + "°C";
            InitListView();
            InitListView2();
            PopulateList(checkup.patientID);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void CheckUP_Load(object sender, EventArgs e)
        {
            json();
        }

        private void json()
        {
            using (StreamReader r = new StreamReader(@"E:\drugs.json"))
            {
                string json = r.ReadToEnd();
                medicines = JsonConvert.DeserializeObject<List<string>>(json);

                cmbMedicine.DataSource = medicines;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isExist()) return;

            if(txtHrs.Text != "0")
            prescriptions.Add(new Classes.Prescription()
            {
                medicine = cmbMedicine.SelectedItem.ToString(),
                hrs = Int32.Parse(txtHrs.Text)
            });
            PopulateList2();

        }

        private bool isExist()
        {
            foreach(Classes.Prescription prescription in prescriptions)
            {
                if (prescription.medicine == cmbMedicine.SelectedItem.ToString())
                    return true;
            }

            return false;
        }
        private void InitListView()
        {
            lsvRecord.Columns.Add("Records", 200);

            lsvRecord.View = View.Details;
            lsvRecord.GridLines = true;
            lsvRecord.FullRowSelect = true;
            lsvRecord.HideSelection = false;
            lsvRecord.MultiSelect = false;
        }
        private void InitListView2()
        {
            lsvMedicine.Columns.Add("Medicine", 200);
            lsvMedicine.Columns.Add("Time (hrs)", 200);

            lsvMedicine.View = View.Details;
            lsvMedicine.GridLines = true;
            lsvMedicine.FullRowSelect = true;
            lsvMedicine.HideSelection = false;
            lsvMedicine.MultiSelect = false;
        }

        private void PopulateList(string patientID)
        {
          
        }

        private void PopulateList2()
        {
            lsvMedicine.Items.Clear();
            ListViewItem item;
            foreach (var r in prescriptions)
            {
                item = lsvMedicine.Items.Add(r.medicine);
                item.SubItems.Add(r.hrs.ToString());
            }
        }

        private void txtHrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Firebase.Firebase firebase = new Firebase.Firebase();

            if (Classes.CheckupHelper.SaveCheckUP("", "", "", "", "", "", id, txtAssesment.Text, txtManagement.Text,"Discharged",1,"","","",doctorID) != 0)
            {
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Error added");
            }

            foreach (Classes.Prescription prescription in prescriptions)
            {
                Classes.PrescriptionHelper.savePrescription(prescription, id, "checkup");

            }
            Classes.Checkup tempCheckup = this.checkup;
            tempCheckup.management = txtManagement.Text;
            tempCheckup.assesment = txtAssesment.Text;
            tempCheckup.prescriptions = prescriptions;
            tempCheckup.isTreated = 1;
            tempCheckup.status = "Discharged";


            firebase.UpdateCheckUp(tempCheckup);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private bool admissionRequestExisted(string patientID)
        {
            var tempAdmissionList = Classes.AdmissionHelper.Admissions();

            var data = from a in tempAdmissionList
                       where a.patient.id == patientID && a.isAdmitted == 0
                       select a;

           foreach(var d in data.AsEnumerable())
           {
                if(d.patient.id == patientID)
                {
                    return true;
                }
           }

            return false;

        }

        private void btnAdmissionRequest_Click(object sender, EventArgs e)
        {
            Firebase.Firebase firebase = new Firebase.Firebase();

            if (admissionRequestExisted(this.checkup.patientID))
            {
                MessageBox.Show("Patient already request for admission");
                return;
            }

            Classes.AdmissionHelper.SaveAdmission(new Classes.Admission()
            {
                patient = currentPatient,
                respiratory_rate = txtrr.Text,
                blood_pressure = txtBP.Text,
                pulse_rate = txtPR.Text,
                gcs = txtGCS.Text,
                o2sat = txto2sat.Text,
                temperature = txtTemp.Text,
                cc = this.cc

            });

            if (Classes.CheckupHelper.SaveCheckUP("", "", "", "", "", "", id, txtAssesment.Text, txtManagement.Text,"Pending for Admission", 0) != 0)
            {
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Error added");
            }

            Classes.Checkup tempCheckup = this.checkup;
            tempCheckup.management = txtManagement.Text;
            tempCheckup.assesment = txtAssesment.Text;
            tempCheckup.prescriptions = prescriptions;
            tempCheckup.isTreated = 0;
            tempCheckup.status = "Pending for Admission";

            firebase.UpdateCheckUp(tempCheckup);


            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnLabRequest_Click(object sender, EventArgs e)
        {
            new Forms.Laboratory.LaboratoryRequest(checkup.user,checkup).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAssesment.Text == "")
            {
                MessageBox.Show("Please fill up this assesment box");
                return;
            }

            if(txtManagement.Text == "")
            {
                MessageBox.Show("Please fill up this management box");
                return;
            }

            var confirmation = MessageBox.Show("Do you really want to print medical certificate?", "PHC", MessageBoxButtons.OKCancel);

            if (confirmation != DialogResult.OK)
                return;

            printPreviewDialog1.ShowDialog();

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
            e.Graphics.DrawString("Medical Certificate", new Font("Times new roman", 15, FontStyle.Bold), Brushes.Black, new Point(350, 120));

            //body
            e.Graphics.DrawString("Date :" + DateTime.Now.ToShortDateString(), new Font("Times new roman", 12, FontStyle.Regular), Brushes.Black, new Point(550, 200));
            e.Graphics.DrawString("To Whom It May Concern:", new Font("Times new roman", 12, FontStyle.Regular), Brushes.Black, new Point(100, 280));

            //main body
            string patientFullName = currentPatient.firstname + " " + currentPatient.middlename.Substring(0, 1) + " " + currentPatient.lastname;
            e.Graphics.DrawString("THIS IS TO CERTIFY that "+ patientFullName + " of " + currentPatient.address, new Font("Times new roman", 12, FontStyle.Regular), Brushes.Black, new Point(100, 350));

            e.Graphics.DrawString("Was examined and treated at the Naga City Hospital on " + DateTime.Now.ToShortDateString() + "with the following diagnosis:", new Font("Times new roman", 12, FontStyle.Regular), Brushes.Black, new Point(100, 380));

            int counter = 440;
            int counter2 = 100;

            string assesment = "Sed placerat lectus vel dui pulvinar, eget pretium augue molestie. Phasellus imperdiet neque ut orci semper semper. Nullam dapibus bibendum ipsum ac dictum. Nunc interdum metus a ex suscipit, vel lobortis ex posuere. Quisque vel sem placerat, consectetur risus in, mattis mauris. Suspendisse potenti. Morbi maximus mollis enim quis tempor. Suspendisse luctus velit nulla, eu feugiat turpis dapibus vel. Aenean sit amet feugiat turpis. Vivamus eu odio sit amet nunc ultricies placerat sed ut quam. Suspendisse eget posuere magna, tempus consectetur justo. Nulla varius, mi non aliquet mattis, leo nisi molestie elit, ac commodo lacus neque in metus. Maecenas semper tincidunt ex et gravida. Etiam a interdum velit, eget gravida lectus.";


            for (int i = 0; i <= assesment.Length - 1;i+=counter2)
            {
               
                try
                {
                    e.Graphics.DrawString(assesment.Substring(i, counter2), new Font("Times new roman", 12, FontStyle.Underline), Brushes.Black, new Point(90, counter));
                }
                catch (Exception)
                {
                    e.Graphics.DrawString(assesment.Substring(i,(assesment.Length - i)), new Font("Times new roman", 12, FontStyle.Underline), Brushes.Black, new Point(90, counter));
                }

                counter += 40;
            }

            e.Graphics.DrawString("And would need medical attention for " +  checkup.user.firstname + " " + checkup.user.lastname + " days barring complication", new Font("Times new roman", 12, FontStyle.Regular), Brushes.Black, new Point(90, counter + 30));


            e.Graphics.DrawString(checkup.user.firstname + " " + checkup.user.lastname, new Font("Times new roman", 12, FontStyle.Regular), Brushes.Black, new Point(600, 930));
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), new Point(600, 950), new Point(760,950));
            e.Graphics.DrawString("(Attending Physician)", new Font("Times new roman", 12, FontStyle.Regular), Brushes.Black, new Point(600, 950));
        }
    }
}
