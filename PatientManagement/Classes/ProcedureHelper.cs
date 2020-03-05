using System;
using System.Collections.Generic;
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
                catch (Exception e)
                {

                    return;
                }
            }
        }
    }
}
