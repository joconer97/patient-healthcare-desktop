using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class ProcedureHelper
    {
        public static void SaveProcedure(Procedure procedure)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@admissionID",procedure.admissionID),
                    new SqlParameter("@procedureNo",procedure.procedureNo),
                    new SqlParameter("@procedureName",procedure.procedureName),
                };

                try
                {
                    dal.ExecuteQuery("spSaveProcedure", spParams);
                    return;
                }
                catch (Exception)
                {

                    return;
                }
            }
        }

        public static List<Procedure> ListProcedure(int id)
        {
            List<Procedure> procedures = new List<Procedure>();

            SqlParameter[] spParams = {
                    new SqlParameter("@admissionID",id),
                };


            using (DAL dal = new DAL())
            {


                try
                {
                    var data = dal.ExecuteQuery("spProcedure", spParams).Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        procedures.Add(new Procedure()
                        {
                            admissionID = id,
                            id = dr.Field<int>("id"),
                            procedureNo = dr.Field<int>("procedureNo"),
                            procedureName = dr.Field<string>("procedureName")
                        });
                    }

                    return procedures;

                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
    }
}
