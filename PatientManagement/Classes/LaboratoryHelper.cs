using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class LaboratoryHelper
    {
        public static List<Laboratory> Laboratories()
        {
            List<Laboratory> laboratories = null;
            using (DAL dal = new DAL())
            {

                var data = dal.ExecuteQuery("spGetLaboratory").Tables[0];

                laboratories = new List<Laboratory>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    laboratories.Add(new Laboratory()
                    {
                        id = dr.Field<int>("id"),
                        name = dr.Field<string>("name"),
                        price = dr.Field<decimal>("price")
                    });
                }

                return laboratories;
            }
        }
    }
}
