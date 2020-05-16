using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class UserHelper
    {
        public static User login(string username,string password)
        {
            User user = null;
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password)
                };

                try
                {
                    var data = dal.ExecuteQuery("spUserLogin", spParams).Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        user = new User()
                        {
                            id = dr.Field<int>("id"),
                            username = dr.Field<string>("username"),
                            password = dr.Field<string>("password"),
                            firstname = dr.Field<string>("firstname"),
                            lastname = dr.Field<string>("lastname"),
                            position = dr.Field<string>("position")

                        };
                    }

                }
                catch (Exception)
                {

                    return null;
                }

                return user;
            }
        }

        public static void SaveUser(User user)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@username", user.username),
                    new SqlParameter("@password", user.password),
                    new SqlParameter("@firstname", user.firstname),
                    new SqlParameter("@lastname", user.lastname),
                    new SqlParameter("@position", user.position),

                };

                try
                {
                    dal.ExecuteQuery("spSaveUser", spParams);
                    return;
                }
                catch (Exception)
                {

                    return;
                }
            }
        }

        public static List<User> GetInPatientDoctors()
        {
            List<User> doctors = null;

            using (DAL dal = new DAL())
            {
                try
                {
                    var data = dal.ExecuteQuery("spGetInPatientDoctor").Tables[0];
                    doctors = new List<User>();

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        doctors.Add(new User()
                        {
                            id = dr.Field<int>("id"),
                            firstname = dr.Field<string>("firstname"),
                            lastname = dr.Field<string>("lastname"),
                            position = dr.Field<string>("position")

                        });
                    }

                }
                catch (Exception)
                {

                    return null;
                }

                return doctors;
            }
        }
    }
}
