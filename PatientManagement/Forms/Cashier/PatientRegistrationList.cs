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
    public partial class PatientRegistrationList : MetroFramework.Forms.MetroForm
    {
        public PatientRegistrationList()
        {
            InitializeComponent();
            InitListView();
            PopulateListView();
        }
        List<Classes.Patient> patients = null;

        private void InitListView()
        {
            lsvPatientPending.Columns.Add("PIN", 200);
            lsvPatientPending.Columns.Add("Fullname", 350);
            lsvPatientPending.Columns.Add("Gender", 140);
            lsvPatientPending.Columns.Add("Status");



            lsvPatientPending.View = View.Details;
            lsvPatientPending.GridLines = true;
            lsvPatientPending.FullRowSelect = true;
            lsvPatientPending.HideSelection = false;
            lsvPatientPending.MultiSelect = false;
        }

        private void PopulateListView()
        {
            ListViewItem item;
            patients = GetPendingPatients();

            lsvPatientPending.Items.Clear();
            foreach(var p in patients)
            {
                if(p.isRegistered == 0)
                {
                    item = lsvPatientPending.Items.Add(p.id);
                    item.SubItems.Add(p.firstname + " " + p.middlename + " " + p.lastname);
                    item.SubItems.Add(p.gender.ToString());
                    item.SubItems.Add("Pending");
                }
            }
        }

        private List<Classes.Patient> GetPendingPatients()
        {
            List<Classes.Patient> tempPatients = Classes.PatientHelper.GetPatients();
            List<Classes.Patient> pendingPatients = new List<Classes.Patient>();

            var data = from patient in tempPatients
                       where patient.isRegistered == 0
                       select patient;

            foreach(var dr in data.AsEnumerable())
            {
                pendingPatients.Add(new Classes.Patient()
                {
                    id = dr.id,
                    firstname = dr.firstname,
                    middlename = dr.middlename,
                    lastname = dr.lastname,
                    gender = dr.gender,
                    contact = dr.contact,
                    birthdate = dr.birthdate,
                    emergency_contact = dr.emergency_contact,
                    isRegistered = dr.isRegistered,
                    address = dr.address,
                    citizenship = dr.citizenship,
                    religion = dr.religion,
                    birthplace = dr.birthplace,
                    occupation = dr.occupation,     
                    
                });
            }

            return pendingPatients;

        }

        private void lsvPatientPending_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                index = lsvPatientPending.SelectedItems[0].Index;
            }
            catch (Exception r)
            {

                MessageBox.Show(r.ToString());
            }

            if(new Forms.Cashier.PatientRegistrationPayment(patients[index]).ShowDialog() == DialogResult.OK)
            {
                GetPendingPatients();
                PopulateListView();
            }
        }
    }
}
