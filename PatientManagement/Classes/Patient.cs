using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class Patient
    {
        public string id { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public DateTime birthdate { get; set; }
        public char gender { get; set; }
        public string religion { get; set; }
        public string citizenship { get; set; }
        public string address { get; set; }
        public string occupation { get; set; }
        public string contact { get; set; }
        public string emergency_contact { get; set; }
        public int isRegistered { get; set; }


        

    }
}
