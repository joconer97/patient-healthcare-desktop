using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class Admission
    {
        public Admission()
        {
            id = 0;
            patient = null;
            admittedDate = DateTime.Now;
            admittedTime = new TimeSpan(0,0,0);
            timesAdmitted = 0;
            ward = "";
            contact = "";
            roomNo = 0;
            bedNo = 0;
            fatherName = "";
            fAddress = "";
            fOccupation = "";
            fEmployer = "";
            fEmployer = "";
            motherName = "";
            mAddress = "";
            mOccupation = "";
            mEmployer = "";
            spouseName = "";
            sAddress = "";
            sOccupation = "";
            sEmployer = "";
            captainName = "";
            companionName = "";
            cRelationship = "";
            cAddress = "";
            eName = "";
            eAddress = "";
            eRelationship = "";
            isAdmitted = 0;
            isDischarged = 0;
            isTransferred = 0;
            doctorID = 0;
            nurseID = 0;
            dischargedDate = DateTime.Now;
            dischargedTime = new TimeSpan(0, 0, 0);
            

        }
        public int id { get; set; }
        public int doctorID { get; set; }
        public int nurseID { get; set; }
        public Patient patient { get; set; }
        public User doctor { get; set; }
        public User nurse { get; set; }
        public DateTime admittedDate { get; set ; }
        public TimeSpan admittedTime { get; set; }
        public int timesAdmitted { get; set; }
        public string ward { get; set; }
        public int roomNo { get; set; }
        public int bedNo { get; set; }
        public string fatherName { get; set; }
        public string fAddress { get; set; }
        public string fOccupation { get; set; }
        public string fEmployer { get; set; }
        public string motherName { get; set; }
        public string mAddress { get; set; }
        public string mOccupation { get; set; }
        public string mEmployer { get; set; }
        public string spouseName { get; set; }
        public string sAddress { get; set; }
        public string sOccupation { get; set; }
        public string sEmployer { get; set; }
        public string captainName { get; set; }
        public string companionName { get; set; }
        public string cRelationship { get; set; }
        public string cAddress { get; set; }
        public string eName { get; set; }
        public string eRelationship { get; set; }
        public string eAddress { get; set; }
        public string contact { get; set; }
        public int isAdmitted { get; set; }
        public int isDischarged { get; set; }
        public int isTransferred { get; set; }

        public DateTime dischargedDate { get; set; }

        public TimeSpan dischargedTime { get; set; }

        public string temperature { get; set; }
        public string blood_pressure { get; set; }
        public string pulse_rate { get; set; }
        public string respiratory_rate { get; set; }
        public string gcs { get; set; }
        public string o2sat { get; set; }

        public string cc { get; set; }

        public List<Prescription> prescriptions { get; set; }
        public List<Procedure> procedures { get; set; }

        public static List<Admission> AdmissionRequest(List<Admission> admissions,int type)
        {
            List<Admission> tempAdmissions = new List<Admission>();

            foreach(var a in admissions)
            {
                if (a.isAdmitted == type)
                    tempAdmissions.Add(a);
            }

            return tempAdmissions;
        }
    }
}
