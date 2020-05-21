using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class Deceased
    {
        public int id { get; set; }
        public int admissionID { get; set; }
        public TimeSpan timeOfDeath {get;set;}
        public DateTime dateOfDeath { get; set; }

        public Patient patient { get; set; }
        public string report { get; set; }
    }
}
