﻿using System;
using System.Collections.Generic;
using System.Data;
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
                    new SqlParameter("@urgency",request.urgency),
                    new SqlParameter("@patientID",request.patient.id),
                    new SqlParameter("@id",(request.id != 0)?request.id:0),
                    new SqlParameter("@result",request.result)

                };

                return (int)dal.ExecuteQueryScalar("spSaveLabRequest", spParams);
            }
        }


        public static void SaveLaboratoryType(TestType type)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@name", type.name),
                    new SqlParameter("@labRequestID",type.labRequestID),


                };

                dal.ExecuteNonQuery("spSaveTestType", spParams);
            }
        }


        public static List<LaboratoryRequest> LaboratoryRequestsList()
        {
            List<LaboratoryRequest> requests = new List<LaboratoryRequest>();

            using (DAL dal = new DAL())
            {
                try
                {
                    var data = dal.ExecuteQuery("spLaboratoryRequest").Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        requests.Add(new LaboratoryRequest()
                        {
                            id = dr.Field<int>("id"),
                            type = dr.Field<string>("type"),
                            typeID = dr.Field<int>("typeID"),
                            status = dr.Field<string>("status"),
                            urgency = dr.Field<string>("urgency"),
                            patient = new Patient()
                            {
                                id = dr.Field<string>(14),
                                firstname = dr.Field<string>(15),
                                middlename = dr.Field<string>(16),
                                lastname = dr.Field<string>(17),
                                gender = char.Parse(dr.Field<string>(18)),
                                contact = dr.Field<string>(19),
                                birthdate = dr.Field<DateTime>(20),
                                address = dr.Field<string>(26)
                            },
                            user = new User()
                            {
                                id = dr.Field<int>(8),
                                firstname = dr.Field<string>(11),
                                lastname = dr.Field<string>(12),
                                position = dr.Field<string>(13),

                            }
                        });
                    }

                    return requests;

                }
                catch (Exception e)
                {

                    return null;
                }
            }
        }

        public static List<TestType> TestTypeList(int laboratoryID)
        {
            List<TestType> testTypes = new List<TestType>();

            using (DAL dal = new DAL())
            {
                try
                {

                    SqlParameter[] spParams = {
                        new SqlParameter("@labRequestID", laboratoryID),
                    };

                    var data = dal.ExecuteQuery("spLaboratoryTypes",spParams).Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        testTypes.Add(new TestType()
                        {
                            labRequestID = laboratoryID,
                            name = dr.Field<string>("name")
                        });                   
                    }

                    return testTypes;

                }
                catch (Exception e)
                {

                    return null;
                }
            }
        }
    }
}
