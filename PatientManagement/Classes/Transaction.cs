using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class Transaction
    {
        public List<Medicine> medicines;
        public List<MedicalSupply> medicalSupplies;
        public List<Laboratory> laboratories;
        public string status { get; set; }
        public Transaction()
        {
            medicines = new List<Medicine>();
            medicalSupplies = new List<MedicalSupply>();
            laboratories = new List<Laboratory>();
        }
      
    }
}
