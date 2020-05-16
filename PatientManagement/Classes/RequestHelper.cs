using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class RequestHelper
    {
        public static void SaveDishargeRequest(DischargeRequest request)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@id",request.id),
                    new SqlParameter("@admissionID",request.admission.id),
                    new SqlParameter("@isPaid",request.isPaid),
                    new SqlParameter("@status",request.status),
                    new SqlParameter("@philhealth_code",request.philhealthCode),
                    new SqlParameter("@philhealth_cover",request.philhealthCover),
                    new SqlParameter("@rate",request.rate)
                };

                dal.ExecuteQuery("spRequestDischarge", spParams);
            }
        }

        public static List<DischargeRequest> GetDischargeRequests()
        {
            List<DischargeRequest> dischargeRequests = null;

            using (DAL dal = new DAL())
            {
                try
                {
                    var data = dal.ExecuteQuery("spSelectRequest").Tables[0];

                    dischargeRequests = new List<DischargeRequest>();

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        dischargeRequests.Add(new DischargeRequest()
                        {
                            id = dr.Field<int>(0),
                            admission = new Admission()
                            {
                                id = dr.Field<int>(1),
                                admittedDate = dr.Field<DateTime>("admittedDate"),
                                patient = new Patient()
                                {
                                    id = dr.Field<string>(7),
                                    firstname = dr.Field<string>("firstname"),
                                    middlename = dr.Field<string>("middlename"),
                                    lastname = dr.Field<string>("lastname")
                                },

                            },
                            isPaid = dr.Field<int>(2),
                            status = dr.Field<string>(3),
                            philhealthCode = dr.Field<string>(4),
                            philhealthCover = dr.Field<decimal>(5),
                            rate = dr.Field<int>(6),

                        });
                    }

                }
                catch (Exception e)
                {

                    return null;
                }
            }

            return dischargeRequests;
        }
    }
}
