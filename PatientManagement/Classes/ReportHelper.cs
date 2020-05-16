using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class ReportHelper
    {
        public static void SaveReport(Report report)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@admissionID",report.admissionID),
                    new SqlParameter("@employeeID",report.employeeID),
                    new SqlParameter("@notes",report.notes),
                    new SqlParameter("@bp",report.bp),
                    new SqlParameter("@pr",report.pr),
                    new SqlParameter("@rr",report.rr),
                    new SqlParameter("@temperature",report.temperature),
                    new SqlParameter("@gcs",report.gcs),
                    new SqlParameter("@o2sat",report.o2sat),
                    new SqlParameter("@date",report.date)

            };

                dal.ExecuteQueryScalar("spSaveReport", spParams);
            }
        }


        public static List<Report> ViewReport(int id)
        {
            List<Report> reports = new List<Report>();

            SqlParameter[] spParams = {
                    new SqlParameter("@admissionID",id),
                };

            using (DAL dal = new DAL())
            {

                try
                {
                    var data = dal.ExecuteQuery("spViewReport", spParams).Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        reports.Add(new Report()
                        {
                            id = dr.Field<int>(0),
                            admissionID = dr.Field<int>(1),
                            employeeID = dr.Field<int>(2),
                            notes = dr.Field<string>(3),
                            bp = dr.Field<string>(4),
                            pr = dr.Field<string>(5),
                            rr = dr.Field<string>(6),
                            temperature = dr.Field<string>(7),
                            gcs = dr.Field<string>(8),
                            o2sat = dr.Field<string>(9),
                            date = dr.Field<DateTime>(10)
                        });
                    }

                    return reports;

                }
                catch (Exception e)
                {

                    return null;
                }
            }
        }
    }
}
