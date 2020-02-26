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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            InitListView();
            PopulatListView();
        }

        private void InitListView()
        {
            lsvPayment.Columns.Add("PIN", 200);
            lsvPayment.Columns.Add("Fullname", 280);
            lsvPayment.Columns.Add("Price", 100);
            lsvPayment.Columns.Add("Type", 100);




            lsvPayment.View = View.Details;
            lsvPayment.GridLines = true;
            lsvPayment.FullRowSelect = true;
            lsvPayment.HideSelection = false;
            lsvPayment.MultiSelect = false;
        }

        private void PopulatListView()
        {
            List<Classes.Request> requests = new List<Classes.Request>()
            {
                new Classes.Request()
                {
                    patient = new Classes.Patient()
                    {
                        id = "100523523",
                        firstname = "Arnel",
                        lastname = "Payongayong"
                    },
                    type = "Discharge Bill",
                    price = 350
                },

                new Classes.Request()
                {
                    patient = new Classes.Patient()
                    {
                        id = "100523524",
                        firstname = "Laurence",
                        lastname = "Rubis"
                    },
                    type = "Discharge Bill",
                    price = 500
                },

                new Classes.Request()
                {
                    patient = new Classes.Patient()
                    {
                        id = "100523525",
                        firstname = "Adrian",
                        lastname = "Espano"
                    },
                    type = "Discharge Bill",
                    price = 150
                },

                new Classes.Request()
                {
                    patient = new Classes.Patient()
                    {
                        id = "100523527",
                        firstname = "Jeff",
                        lastname = "Sarte"
                    },
                    type = "Discharge Bill",
                    price = 500
                },

            };

            ListViewItem item;

            foreach (var c in requests)
            {
                item = lsvPayment.Items.Add(c.patient.id);
                item.SubItems.Add(c.patient.firstname + " " + c.patient.lastname);
                item.SubItems.Add(c.type);
                item.SubItems.Add(c.price.ToString());

            }
        }
    }
}
