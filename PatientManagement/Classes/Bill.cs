    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class Bill
    {
        public int id { get; set; }
        public string name { get; set; }
        public int transactionID { get; set; }
        public int admittedID { get; set; }
        public string status { get; set; }

        public Patient patient { get; set; }

        public decimal total { get; set; }

        public DateTime date { get; set; }

        public string type { get; set; }
        public int isPaid { get; set; }

    }
}
