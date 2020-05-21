using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class MedicalRecord
    {
        public int id { get; set; }
        public string type { get; set; }
        public int typeID { get; set; }
        public DateTime date { get; set; }
        public Patient patient { get; set; }

    }
}
