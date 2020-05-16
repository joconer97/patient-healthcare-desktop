using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class DischargeRequest
    {

        public int id { get; set; }
        public Admission admission { get; set; }
        public int isPaid { get; set; }
        public string status { get; set; }
        public string philhealthCode { get; set; }
        public decimal philhealthCover { get; set; }
        public int rate { get; set; }
    }
}
