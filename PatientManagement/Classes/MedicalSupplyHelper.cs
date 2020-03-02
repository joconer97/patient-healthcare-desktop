using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class MedicalSupplyHelper
    {
        public static void SaveMedical(MedicalSupply medical)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@name", medical.name),
                    new SqlParameter("@price",medical.price),
                    new SqlParameter("@quantity",medical.quantity),
                };

                dal.ExecuteQuery("spSaveMedical", spParams);
            }
        }

        public static List<MedicalSupply> MedicalSupplies()
        {
            List<MedicalSupply> medicalSupplies = new List<MedicalSupply>();
            
            using (DAL dal = new DAL())
            {
                try
                {
                    var data = dal.ExecuteQuery("spMedicalSupply").Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                       medicalSupplies.Add(new MedicalSupply
                        {
                            id = dr.Field<int>("id"),
                            name = dr.Field<string>("name"),
                            price = dr.Field<decimal>("price"),
                            quantity = dr.Field<int>("quantity")
                        });
                    }

                    return medicalSupplies;

                }
                catch (Exception)
                {

                    return null;
                }
            }
                
        }
    }
}
