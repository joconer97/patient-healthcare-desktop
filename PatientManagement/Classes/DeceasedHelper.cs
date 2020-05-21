using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class DeceasedHelper
    {
        public static void SaveDecesedReport(Deceased deceased)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@admissionID",deceased.admissionID),
                    new SqlParameter("@time_of_death",deceased.timeOfDeath),
                    new SqlParameter("@date_of_death",deceased.dateOfDeath),
                    new SqlParameter("@report",deceased.report),

                };

                dal.ExecuteNonQuery("spSaveDeceasedReport", spParams);
            }
        }

        public static List<Deceased> GetDeceases()
        {
            List<Deceased> deceaseds = new List<Deceased>();

            using (DAL dal = new DAL())
            {
                try
                {
                    var data = dal.ExecuteQuery("spGetDeceasedReport").Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        deceaseds.Add(new Deceased()
                        {
                            admissionID = dr.Field<int>(1),
                            timeOfDeath = dr.Field<TimeSpan>(2),
                            dateOfDeath = dr.Field<DateTime>(3),
                            report = dr.Field<string>(4),
                            patient = new Patient()
                            {
                                firstname = dr.Field<string>("firstname"),
                                middlename = dr.Field<string>("middlename"),
                                lastname = dr.Field<string>("lastname")
                            }
                        });
                    }
                    return deceaseds;

                }
                catch (Exception)
                {

                    return null;
                }
            }
              
            return null;
        }
    }
}
