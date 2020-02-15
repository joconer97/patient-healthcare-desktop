using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class UserHelper
    {
        public static int login(string username,string password)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password)
                };

                return (int)dal.ExecuteQueryScalar("spUserLogin", spParams);
            }
        }
    }
}
