using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class PrescriptionHelper
    {
        public static void savePrescription(Prescription prescription,int id,string type)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@medicine",prescription.medicine),
                    new SqlParameter("@typeID",id),
                    new SqlParameter("@type",type),
                    new SqlParameter("@hours",prescription.hrs)
                };

                dal.ExecuteQuery("spSavePrescription", spParams);
            }
        }
    }
}
