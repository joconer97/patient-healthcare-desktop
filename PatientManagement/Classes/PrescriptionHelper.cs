using System;
using System.Collections.Generic;
using System.Data;
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

        public static List<Prescription> ListPrescription(int id,string type)
        {
            List<Prescription> prescriptions = new List<Prescription>();

            SqlParameter[] spParams = {
                    new SqlParameter("@typeID",id),
                    new SqlParameter("@type",type)
                };


            using (DAL dal = new DAL())
            {


                try
                {
                    var data = dal.ExecuteQuery("spPrescription",spParams).Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        prescriptions.Add(new Prescription()
                        {
                            hrs = dr.Field<int>("hours"),
                            medicine = dr.Field<string>("medicine")

                        });
                    }

                    return prescriptions;

                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
    }
}
