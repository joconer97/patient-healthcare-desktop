using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class MedicineRequest
    {
        public int id { get; set; }
        public int transactionID { get; set; }
        public int admittedID { get; set; }
        public string status { get; set; }
        public decimal price { get; set; }
        public string name { get; set; }
    }
}
