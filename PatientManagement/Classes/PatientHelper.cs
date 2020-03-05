using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class PatientHelper
    {
        public static int register(Patient patient)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@id", patient.id),
                    new SqlParameter("@firstname",patient.firstname),
                    new SqlParameter("@middlename",patient.middlename),
                    new SqlParameter("@lastname",patient.lastname),
                    new SqlParameter("@gender",patient.gender),
                    new SqlParameter("@birthyear",patient.birthdate.ToShortDateString()),
                    new SqlParameter("@birthplace",patient.birthplace),
                    new SqlParameter("@contact",patient.contact),
                    new SqlParameter("@address",patient.address),
                    new SqlParameter("@religion",patient.religion),
                    new SqlParameter("@occupation",patient.occupation),
                    new SqlParameter("@citizenship",patient.citizenship),
                    new SqlParameter("@contact_emergency",patient.emergency_contact),
                    new SqlParameter("@isRegistered",patient.isRegistered),
                };

                try
                {
                    dal.ExecuteQuery("spRegisterPatient", spParams);
                    return 1;
                }
                catch (Exception e)
                {

                    return 0;
                }
            }
        }

        public static List<Patient> search(string id,string lastname)
        {
            List<Patient> patients = new List<Patient>();

            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@patientID", id),
                    new SqlParameter("@lastname",lastname)
                };

                try
                {
                    var data = dal.ExecuteQuery("spSearchPatient", spParams).Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        patients.Add(new Patient()
                        {
                            id = dr.Field<string>(0),
                            firstname = dr.Field<string>(1),
                            middlename = dr.Field<string>(2),
                            lastname = dr.Field<string>(3),
                            gender = char.Parse(dr.Field<string>(4)),
                            contact = dr.Field<string>(5),
                            birthdate = dr.Field<DateTime>(6),
                            emergency_contact = dr.Field<string>(7),
                            isRegistered = dr.Field<int>(8),
                        });
                    }

                    return patients;

                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
    }
}
