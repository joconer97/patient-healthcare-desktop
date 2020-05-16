using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class Checkup
    {
        public int id { get; set; }
        public string patientID { get; set; }
        public string temperature { get; set; }
        public string blood_pressure { get; set; }
        public string pulse_rate { get; set; }
        public string respiratory_rate { get; set; }
        public string gcs { get; set; }
        public string o2sat { get; set; }
        public TimeSpan time_arrived { get; set; }
        public DateTime date { get; set; }
        public string cc { get; set; }
        public string assesment { get; set; }
        public string management { get; set; }
        public int isTreated { get; set; }

        public Patient patient { get; set; }

        public User user { get; set; }

        public string status { get; set; }

        public List<Prescription> prescriptions { get; set; }

    }
}
