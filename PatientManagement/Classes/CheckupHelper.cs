using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class CheckupHelper
    {
        public static bool SaveCheckUP(string patientID,string bp,string temperature,string pr,string timeArrived,string cc,int id,string assesment,string management,int isTreated = 0,string rr = "",string gcs = "",string o2sat = "",int doctorID = 0)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@patientID", patientID),
                    new SqlParameter("@bp", bp),
                    new SqlParameter("@temperature", temperature),
                    new SqlParameter("@pr", pr),
                    new SqlParameter("@time_arrived",timeArrived),
                    new SqlParameter("@cc", cc),
                    new SqlParameter("@id", id),
                    new SqlParameter("@assesment", assesment),
                    new SqlParameter("@management", management),
                    new SqlParameter("@isTreated", isTreated),
                    new SqlParameter("@date", DateTime.Now.ToShortDateString()),
                    new SqlParameter("@rr", rr),
                    new SqlParameter("@gcs", gcs),
                    new SqlParameter("@o2sat", o2sat),
                    new SqlParameter("doctorID",doctorID)

                };
                try
                {
                    dal.ExecuteQuery("spSaveCheckup", spParams);

                }
                catch (Exception)
                {

                    return false;
                }

                return true;
              
            }
        }

        public static List<Checkup> ListCheckup()
        {
            using (DAL dal = new DAL())
            {
                List<Checkup> checkups = new List<Checkup>();
                try
                {
                    var data = dal.ExecuteQuery("spCheckupList").Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        checkups.Add(new Checkup()
                        {
                            id = dr.Field<int>(0),
                            patientID = dr.Field<string>(1),
                            blood_pressure = dr.Field<string>(2),
                            temperature = dr.Field<string>(3),
                            pulse_rate = dr.Field<string>(4),
                            respiratory_rate = dr.Field<string>("rr"),
                            gcs = dr.Field<string>("gcs"),
                            o2sat = dr.Field<string>("o2sat"),
                            cc = dr.Field<string>("cc"),
                            time_arrived = dr.Field<TimeSpan>(5),
                            isTreated = dr.Field<int>(6),
                            patient = new Patient()
                            {
                                id = dr.Field<string>("patientID"),
                                firstname = dr.Field<string>("firstname"),
                                middlename = dr.Field<string>("middlename"),
                                lastname = dr.Field<string>("lastname"),
                                gender = char.Parse(dr.Field<string>("gender")),
                                birthdate = dr.Field<DateTime>("birthyear"),
                                address = dr.Field<string>("address"),
                                religion = dr.Field<string>("religion"),
                                citizenship = dr.Field<string>("citizenship"),
                                occupation = dr.Field<string>("occupation"),
                                contact = dr.Field<string>("contact")

                            }

                        });
                    }

                    return checkups;

                }
                catch (Exception)
                {

                    return null;
                }

            }
        }
    }
}
