using OfficeOpenXml;
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

namespace PatientManagement.Forms.CentralSupply
{
    public partial class CentralSupply : MetroFramework.Forms.MetroForm
    {
        public CentralSupply()
        {
            InitializeComponent();
            Init();
            PopulateList();
        }


        private void Init()
        {
            lsvMedical.Columns.Add("#", 200);
            lsvMedical.Columns.Add("Name", 200);
            lsvMedical.Columns.Add("Price", 280);
            lsvMedical.Columns.Add("Quantity", 280);



            lsvMedical.View = View.Details;
            lsvMedical.GridLines = true;
            lsvMedical.FullRowSelect = true;
            lsvMedical.HideSelection = false;
            lsvMedical.MultiSelect = false;
        }
        private void PopulateList()
        {
            ListViewItem item;
            var medicalSupplies = Classes.MedicalSupplyHelper.MedicalSupplies();
            lsvMedical.Items.Clear();
       
            foreach(var m in medicalSupplies)
            {
                item = lsvMedical.Items.Add(m.id.ToString());
                item.SubItems.Add(m.name);
                item.SubItems.Add(m.price.ToString());
                item.SubItems.Add(m.quantity.ToString());
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(new Forms.CentralSupply.ImportMedicalSupply().ShowDialog() == DialogResult.OK)
            {
                PopulateList();
            }
        }
       
        private void metroButton2_Click(object sender, EventArgs e)
        {
            //SaveMedicalSupply();
        }
    }
}
