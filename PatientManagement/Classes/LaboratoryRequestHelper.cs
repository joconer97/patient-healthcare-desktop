using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class LaboratoryRequestHelper
    {
        public static int SaveLaboratoryRequest(LaboratoryRequest request)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@doctorID", request.doctorID),
                    new SqlParameter("@type",request.type),
                    new SqlParameter("@typeID",request.typeID),
                    new SqlParameter("@status",request.status),

                };

                return (int)dal.ExecuteQueryScalar("spSaveLabRequest", spParams);
            }
        }
    }
}
