using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.PatientForm
{
    public partial class AdmissionRequest : Form
    {
        Classes.Admission admission;
        List<Classes.Room> usedRooms = new List<Classes.Room>();
        List<Classes.Room> availableRooms = new List<Classes.Room>();
        Classes.User currentUser = null;
        public AdmissionRequest(Classes.Admission admission,Classes.User user)
        {
            InitializeComponent();
            this.admission = admission;
            timer1.Start();
            Init();
            AvailableRoom();
            currentUser = user;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
          
            
            Classes.Admission admission = new Classes.Admission()
            {
                id = this.admission.id,
                patient = this.admission.patient,
                admittedDate = dtpDateAdmitted.Value,
                admittedTime = new TimeSpan(DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second),
                timesAdmitted = Int32.Parse(txtTImesAdmitted.Text),
                ward = txtWard.Text,
                roomNo = Int32.Parse(cmbRoomNo.SelectedItem.ToString()),
                bedNo = Int32.Parse(cmbBedNo.SelectedItem.ToString()),
                fatherName = txtFName.Text,
                fAddress = txtFAddress.Text,
                fOccupation = txtFOccupation.Text,
                fEmployer = txtFEmployer.Text,
                motherName = txtMName.Text,
                mAddress = txtMAddress.Text,
                mOccupation = txtMOccupation.Text,
                mEmployer = txtMEmployer.Text,
                spouseName = txtSName.Text,
                sAddress = txtSAddress.Text,
                sOccupation = txtSOccupation.Text,
                sEmployer = txtSEmployer.Text,
                captainName = txtCaptain.Text,
                companionName = txtCName.Text,
                cRelationship = txtCRelation.Text,
                cAddress = txtCAddress.Text,
                eName = txtEName.Text,
                eRelationship = txtERelation.Text,
                eAddress = txtEAddress.Text,
                contact = txtEContact.Text,
                isAdmitted = 1,
                isDischarged = 0,
                doctorID = RandomDoctors(),
                blood_pressure = this.admission.blood_pressure,
                cc = this.admission.cc,
                pulse_rate = this.admission.pulse_rate,
                respiratory_rate = this.admission.respiratory_rate,
                o2sat = this.admission.o2sat,
                gcs = this.admission.gcs,
                temperature = this.admission.temperature,
                nurseID = currentUser.id

            };


            Classes.AdmissionHelper.SaveAdmission(admission);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;


        }

        private List<Classes.User> GetDoctors()
        {
            return Classes.UserHelper.GetInPatientDoctors();
        }

        private int RandomDoctors()
        {
            List<Classes.User> doctors = GetDoctors();

            int index = new Random().Next(0, doctors.Count - 1);

            return doctors[index].id;

        }

        private void AvailableRoom()
        {
            List<Classes.Admission> admissions = Classes.AdmissionHelper.Admissions();

            foreach (var admission in admissions)
            {
                if (admission.isAdmitted == 1 && admission.isDischarged == 0)
                {
                    usedRooms.Add(new Classes.Room()
                    {
                        roomNo = admission.roomNo,
                        bedNo = admission.bedNo
                    });
                }
            }

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    bool isUsed = false;
                    foreach(var r in usedRooms)
                    {
                        if(r.roomNo == i && r.bedNo == j)
                        {
                            isUsed = true;
                        }
                    }

                    if(!isUsed)
                    {
                        availableRooms.Add(new Classes.Room()
                        {
                            roomNo = i,
                            bedNo = j
                        });
                    }   
                    
                }
            }
        }

        private void Init()
        {
            txtPName.Text = admission.patient.firstname + " " + admission.patient.middlename + " " + admission.patient.lastname;
            txtPAge.Text = (DateTime.Now.Year - admission.patient.birthdate.Year).ToString();
            txtPBirthplace.Text = "Makati";
            txtPDateOfBirth.Text = admission.patient.birthdate.ToShortDateString();
            txtPReligion.Text = admission.patient.religion;
            txtPSex.Text = admission.patient.gender.ToString();
            txtPAddress.Text = admission.patient.address;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();

            txtAdmittedTime.Text = dt.ToLocalTime().ToShortTimeString();
        }

        private void cmbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomNo.SelectedItem.ToString() == "1")
            {
                cmbBedNo.Items.Clear();
                foreach (var b in availableRooms)
                {
                    if (b.roomNo == 1)
                    {
                        cmbBedNo.Items.Add(b.bedNo);
                    }
                }
            }
            else
            {
                cmbBedNo.Items.Clear();
                foreach (var b in availableRooms)
                {
                    if (b.roomNo == 2)
                    {
                        cmbBedNo.Items.Add(b.bedNo);
                    }
                }
            }
        }
    }
}
