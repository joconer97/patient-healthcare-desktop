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
        public AdmissionRequest(Classes.Admission admission)
        {
            InitializeComponent();
            this.admission = admission;
            timer1.Start();
            Init();
            AvailableRoom();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();

            Classes.Admission admission = new Classes.Admission()
            {
                id = this.admission.id,
                patient = this.admission.patient,
                admittedDate = dtpDateAdmitted.Value,
                admittedTime = new TimeSpan(dt.Hour,dt.Minute,dt.Second),
                timesAdmitted = Int32.Parse(txtTImesAdmitted.Text),
                ward = txtWard.Text,
                roomNo = Int32.Parse(cmbBedNo.SelectedItem.ToString()),
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
                employeeID = 1,
            };


            Classes.AdmissionHelper.SaveAdmission(admission);


        }

        private void AvailableRoom()
        {
            List<Classes.Admission> admissions = Classes.AdmissionHelper.Admissions();

            foreach (var admission in admissions)
            {
                if (admission.isAdmitted == 1)
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
                    if(usedRooms.Count == 0)
                    {
                        availableRooms.Add(new Classes.Room()
                        {
                            roomNo = i,
                            bedNo = j
                        });
                        continue;
                    }
                    foreach (var room in usedRooms)
                    {
                        if (room.bedNo == j && room.roomNo == i)
                        {
                            Console.WriteLine("USED " + room.roomNo.ToString() + " " + room.bedNo.ToString());
                            continue;
                        }
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

        private void cmbRoomNo_SelectedValueChanged(object sender, EventArgs e)
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
