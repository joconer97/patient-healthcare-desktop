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
    public partial class AdmissionRequestList : Form
    {
        List<Classes.Admission> admissions = null;
        public AdmissionRequestList()
        {
            InitializeComponent();
            InitListView();
            PopulateListView();
        }

        private void InitListView()
        {
            lsvAdmission.Columns.Add("BED #", 200);
            lsvAdmission.Columns.Add("PIN", 200);
            lsvAdmission.Columns.Add("Fullname", 280);
            lsvAdmission.Columns.Add("Sex", 30);
            lsvAdmission.Columns.Add("Illness", 200);
            lsvAdmission.Columns.Add("Admission Date", 200);
            lsvAdmission.Columns.Add("Admission Time", 200);


            lsvAdmission.View = View.Details;
            lsvAdmission.GridLines = true;
            lsvAdmission.FullRowSelect = true;
            lsvAdmission.HideSelection = false;
            lsvAdmission.MultiSelect = false;
        }

        private void PopulateListView()
        {
            admissions = Classes.AdmissionHelper.Admissions();
            ListViewItem item;

            AvailableRoom(admissions);

            foreach (Classes.Admission admission in admissions)
            {
                if(admission.isAdmitted == 0)
                {
                    item = lsvAdmission.Items.Add(admission.bedNo.ToString());
                    item.SubItems.Add(admission.patient.id);
                    item.SubItems.Add(admission.patient.firstname + " " + admission.patient.middlename + " " + admission.patient.lastname);
                    item.SubItems.Add(admission.patient.gender.ToString());
                    item.SubItems.Add("Dengue");
                    item.SubItems.Add(admission.admittedDate.ToShortDateString());
                    item.SubItems.Add(admission.admittedTime.ToString());
                }

            }

        }

        private void AvailableRoom(List<Classes.Admission> admissions)
        {
            List<Classes.Room> usedRooms = new List<Classes.Room>();

            foreach (var admission in admissions)
            {
                if(admission.isAdmitted == 1)
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
                    foreach(var room in usedRooms)
                    {
                        if(room.bedNo == j && room.roomNo == i)
                        {
                            Console.WriteLine("USED " + room.roomNo.ToString() + " " + room.bedNo.ToString());
                        }
                    }
                }
            }
        }

        private void lsvAdmission_SelectedIndexChanged(object sender, EventArgs e)
        {
            int si = 0;

            try
            {
                si = lsvAdmission.SelectedItems[0].Index;
            }
            catch (Exception)
            {

            }

            new Forms.PatientForm.AdmissionRequest(admissions[si]).ShowDialog();
        }
    }
}
