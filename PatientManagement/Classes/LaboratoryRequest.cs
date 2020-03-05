using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class LaboratoryRequest
    {
        public int id { get; set; }
        public int doctorID { get; set; }
        public int typeID { get; set; }
        public string type { get; set; }
        public string status { get; set; }

        public List<TestType> testTypes { get; set; }
    }
}
