using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class Report
    {
        public int id { get; set; }
        public int admissionID { get; set; }

        public int employeeID { get; set; }
        public string notes { get; set; }
        public string bp { get; set; }
        public string pr { get; set; }
        public string rr { get; set; }
        public string temperature { get; set; }
        public string gcs { get; set; }
        public string o2sat { get; set; }
        public DateTime date { get; set; }
    }
}
