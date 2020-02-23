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
        public static void saveMedicalRecord(MedicalRecord record)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@pin", record.pin),
                    new SqlParameter("@details",record.details)
                };

                dal.ExecuteQuery("spSaveMedicalRecords",spParams);
            }
        }

        public static List<MedicalRecord> medicalRecords(string patientID)
        {
            List<MedicalRecord> records = new List<MedicalRecord>();

            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@patientID", patientID),
                };

                try
                {
                    var data = dal.ExecuteQuery("spGetRecords", spParams).Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        records.Add(new MedicalRecord()
                        {
                            details = dr.Field<string>(2)
                        });
                    }

                    return records;

                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
    }
}
