using System;
using System.Collections.Generic;
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
    }
}
