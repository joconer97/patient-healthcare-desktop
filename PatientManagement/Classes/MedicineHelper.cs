using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class MedicineHelper
    {
        public static void SaveMedicine(Medicine medicine)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@name", medicine.name),
                    new SqlParameter("@price",medicine.price),
                    new SqlParameter("@quantity",medicine.quantity),
                };

                dal.ExecuteQuery("spSaveMedicine", spParams);
            }
        }

        public static void UpdateMedicineQuantity(Medicine medicine)
        {
            using (DAL dal = new DAL())
            {
                int type = 0;

                SqlParameter[] spParams = {
                    new SqlParameter("@id", medicine.id),
                    new SqlParameter("@quantity",medicine.quantity),
                    new SqlParameter("@type",type),
                };
                try
                {
                    dal.ExecuteQuery("spUpdateItems", spParams);

                }
                catch (Exception)
                {

                }

            }
        }

        public static List<Medicine> Medicines()
        {
            List<Medicine> medicines = new List<Medicine>();

            using (DAL dal = new DAL())
            {


                try
                {
                    var data = dal.ExecuteQuery("spMedicines").Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        medicines.Add(new Medicine()
                        {
                            id = dr.Field<int>("id"),
                            name = dr.Field<string>("name"),
                            price = dr.Field<decimal>("price"),
                            quantity = dr.Field<int>("quantity")
                        });
                    }

                    return medicines;

                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
    }
}
