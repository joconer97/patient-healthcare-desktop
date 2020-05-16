using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.Pharmacy
{
    public partial class Pharmacy : MetroFramework.Forms.MetroForm
    {
        public Pharmacy()
        {
            InitializeComponent();
            InitListView();
            PopulateList();
            InitListView2();
            PopulateListView2();
        }

        List<Classes.Bill> request = null;

        private void InitListView()
        {
            lsvMedicine.Columns.Add("ID", 200);
            lsvMedicine.Columns.Add("Name", 200);
            lsvMedicine.Columns.Add("Price", 280);
            lsvMedicine.Columns.Add("Quantity", 280);



            lsvMedicine.View = View.Details;
            lsvMedicine.GridLines = true;
            lsvMedicine.FullRowSelect = true;
            lsvMedicine.HideSelection = false;
            lsvMedicine.MultiSelect = false;
        }

        private void InitListView2()
        {
            lsvMedicineRequest.Columns.Add("#", 200);
            lsvMedicineRequest.Columns.Add("Firstname", 200);
            lsvMedicineRequest.Columns.Add("Middlename", 280);
            lsvMedicineRequest.Columns.Add("Lastname", 280);



            lsvMedicineRequest.View = View.Details;
            lsvMedicineRequest.GridLines = true;
            lsvMedicineRequest.FullRowSelect = true;
            lsvMedicineRequest.HideSelection = false;
            lsvMedicineRequest.MultiSelect = false;
        }

        private void PopulateListView2()
        {
            request = Classes.BillHelper.BillList();
            
            ListViewItem item;
            int ctr = 0;
            foreach(var p in request)
            {
                item = lsvMedicineRequest.Items.Add((++ctr).ToString());
                item.SubItems.Add(p.patient.firstname);
                item.SubItems.Add(p.patient.middlename);
                item.SubItems.Add(p.patient.lastname);
            }
        }


        
        private void PopulateList()
        {
            ListViewItem item;
            lsvMedicine.Items.Clear();
            var medicines = Classes.MedicineHelper.Medicines();
            int counter = 1;

            foreach(var m in medicines)
            {
                item = lsvMedicine.Items.Add((counter++).ToString());
                item.SubItems.Add(m.name);
                item.SubItems.Add(m.price.ToString());
                item.SubItems.Add(m.quantity.ToString());
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(new Forms.Pharmacy.ImportMedicine().ShowDialog() == DialogResult.OK)
            {
                PopulateList();
            }
        }


        private void lsvMedicineRequest_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;

            try
            {
                index = lsvMedicineRequest.SelectedItems[0].Index;
            }
            catch (Exception)
            {

                throw;
            }

            new Forms.Pharmacy.MedicineRequest(request[index].admittedID).ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //SaveMedicines();
        }
    }
}
