using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class MedicalRecordHelper
    {
        public static List<MedicalRecord> GetMedicalRecords()
        {
            List<MedicalRecord> records = new List<MedicalRecord>();

            using (DAL dal = new DAL())
            {
                try
                {
                    var data = dal.ExecuteQuery("spGetAllMedical").Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        records.Add(new MedicalRecord()
                        {
                            id = dr.Field<int>(0),
                            type = dr.Field<string>(1),
                            date = dr.Field<DateTime>(3),
                            patient = new Patient()
                            {
                                id = dr.Field<string>(4),
                                firstname = dr.Field<string>(5),
                                middlename = dr.Field<string>(6),
                                lastname = dr.Field<string>(7),
                                gender = char.Parse(dr.Field<string>(8)),
                                contact = dr.Field<string>(9),
                                birthdate = dr.Field<DateTime>(10),
                                emergency_contact = dr.Field<string>(11),
                                isRegistered = dr.Field<int>(12),
                                religion = dr.Field<string>(13),
                                citizenship = dr.Field<string>(14),
                                occupation = dr.Field<string>(15),
                                address = dr.Field<string>(16),
                                birthplace = dr.Field<string>(17),
                            }
                        });
                    }

                    return records;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public static List<MedicalRecord> GetSummaryMedicalRecords()
        {
            List<MedicalRecord> medicalRecords = null;

            using (DAL dal = new DAL())
            {
                var data = dal.ExecuteQuery("spGetSummaryReport").Tables[0];

                medicalRecords = new List<MedicalRecord>();

                foreach(DataRow dr in data.AsEnumerable())
                {
                    medicalRecords.Add(new MedicalRecord()
                    {
                        id = dr.Field<int>(0),
                        typeID = dr.Field<int>(1),
                        type = dr.Field<string>(2),
                        date = dr.Field<DateTime>(3)
                    });
                }

                return medicalRecords;

            }
                
        }

    }
}
