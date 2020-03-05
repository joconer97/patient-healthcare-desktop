using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class Procedure
    {
        public int id { get; set; }
        public int admissionID { get; set; }
        public int procedureNo { get; set; }
        public string procedureName { get; set; }
    }
}
