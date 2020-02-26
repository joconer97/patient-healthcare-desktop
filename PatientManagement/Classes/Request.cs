using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class Request
    {
        public Patient patient { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int price { get; set; }

        public int quantity { get; set; }

    }
}
