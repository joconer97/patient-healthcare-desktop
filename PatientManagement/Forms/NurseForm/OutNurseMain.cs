﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManagement.Classes;

namespace PatientManagement.Forms.NurseForm
{
    public partial class OutNurseMain : MetroFramework.Forms.MetroForm
    {
        User currentUser = null;
        public OutNurseMain(User user)
        {
            InitializeComponent();
            currentUser = user;
            label2.Text = "Nurse " + user.firstname + " " + user.lastname; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form register = new Forms.PatientForm.RegisterPatient();

            var isSuccess = register.ShowDialog();

            if(isSuccess == DialogResult.OK)
            {
                MessageBox.Show("Successfully saved");
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form checkup = new Forms.PatientForm.CheckUPSearch();

            checkup.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Forms.Laboratory.LaboratoryResultList().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Forms.PatientForm.SearchPatient().ShowDialog();
        }
    }
}
