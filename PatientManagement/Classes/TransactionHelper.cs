using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class TransactionHelper
    {
        public static int SaveTransaction(Transaction transaction)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@typeID",transaction.typeID),
                    new SqlParameter("@type",transaction.type),
                    new SqlParameter("@status",transaction.status),
                    new SqlParameter("@date",transaction.date.ToShortDateString()),
                };

                return (int)dal.ExecuteQueryScalar("spSaveTransaction", spParams);
            }
        }
    }
}
