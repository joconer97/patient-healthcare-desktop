﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public static class AdmissionHelper
    {
        public static int SaveAdmission(Admission admission)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@id",admission.id),
                    new SqlParameter("@patientID",admission.patient.id),
                    new SqlParameter("@admittedDate",admission.admittedDate),
                    new SqlParameter("@admittedTime",admission.admittedTime),
                    new SqlParameter("@dischargeDate",admission.dischargedDate),
                    new SqlParameter("@dischargeTime",admission.dischargedTime),
                    new SqlParameter("@timesAdmitted",admission.timesAdmitted),
                    new SqlParameter("@ward",admission.ward),
                    new SqlParameter("@roomNo",admission.roomNo),
                    new SqlParameter("@bedNo",admission.bedNo),
                    new SqlParameter("@fatherName",admission.fatherName),
                    new SqlParameter("@fAddress",admission.fAddress),
                    new SqlParameter("@fOccupation",admission.fOccupation),
                    new SqlParameter("@fEmployer",admission.fEmployer),
                    new SqlParameter("@motherName",admission.motherName),
                    new SqlParameter("@mAddress",admission.mAddress),
                    new SqlParameter("@mOccupation",admission.mOccupation),
                    new SqlParameter("@mEmployer",admission.mEmployer),
                    new SqlParameter("@spouseName",admission.spouseName),
                    new SqlParameter("@sAddress",admission.sAddress),
                    new SqlParameter("@sOccupation",admission.sOccupation),
                    new SqlParameter("@sEmployer",admission.sEmployer),
                    new SqlParameter("@captainName",admission.captainName),
                    new SqlParameter("@companionName",admission.companionName),
                    new SqlParameter("@cRelationship",admission.cRelationship),
                    new SqlParameter("@cAddress",admission.cAddress),
                    new SqlParameter("@eName",admission.eName),
                    new SqlParameter("@eRelationship",admission.eRelationship),
                    new SqlParameter("@eAddress",admission.eAddress),
                    new SqlParameter("@contact",admission.contact),
                    new SqlParameter("@isAdmitted",admission.isAdmitted),
                    new SqlParameter("@isDischarged",admission.isDischarged),
                    new SqlParameter("@isTransferred ",admission.isTransferred),
                    new SqlParameter("@employeeID ",admission.doctorID),
                    new SqlParameter("@bp", admission.blood_pressure),
                    new SqlParameter("@temperature", admission.temperature),
                    new SqlParameter("@pr",admission.pulse_rate),
                    new SqlParameter("@cc", admission.cc),
                    new SqlParameter("@rr", admission.respiratory_rate),
                    new SqlParameter("@gcs", admission.gcs),
                    new SqlParameter("@o2sat", admission.o2sat),
                    new SqlParameter("@nurseID", admission.nurseID),


                };

                try
                {
                    dal.ExecuteQuery("spSaveAdmission", spParams);
                    return 1;
                }
                catch (Exception)
                {

                    return 0;
                }
            }
        }

        public static List<Admission> Admissions()
        {
            List<Admission> admissions = new List<Admission>();

            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                };

                try
                {
                    var data = dal.ExecuteQuery("spAdmissionList", spParams).Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        admissions.Add(new Admission() {
                            patient = new Patient()
                            {
                                id = dr.Field<string>("patientID"),
                                firstname = dr.Field<string>("firstname"),
                                middlename = dr.Field<string>("middlename"),
                                lastname = dr.Field<string>("lastname"),
                                gender = char.Parse(dr.Field<string>("gender")),
                                contact = dr.Field<string>("contact"),
                                birthdate = dr.Field<DateTime>("birthyear"),
                                emergency_contact = dr.Field<string>("contact_emergency"),
                                isRegistered = dr.Field<int>("isRegistered"),
                                religion = dr.Field<string>("religion"),
                                citizenship = dr.Field<string>("citizenship"),
                                occupation = dr.Field<string>("occupation"),
                                address = dr.Field<string>("address"),
                                birthplace = dr.Field<string>("birthplace"),
                            },
                            id = dr.Field<int>("id"),
                            admittedDate = dr.Field<DateTime>("admittedDate"),
                            admittedTime = dr.Field<TimeSpan>("admittedTime"),
                            timesAdmitted = dr.Field<int>("timesAdmitted"),
                            ward = dr.Field<string>("ward"),
                            roomNo = dr.Field<int>("roomNo"),
                            bedNo = dr.Field<int>("bedNo"),
                            fatherName = dr.Field<string>("fatherName"),
                            fAddress = dr.Field<string>("fAddress"),
                            fEmployer = dr.Field<string>("fEmployer"),
                            fOccupation = dr.Field<string>("fOccupation"),
                            motherName = dr.Field<string>("motherName"),
                            mAddress = dr.Field<string>("mAddress"),
                            mOccupation = dr.Field<string>("mOccupation"),
                            mEmployer = dr.Field<string>("mEmployer"),
                            spouseName = dr.Field<string>("spouseName"),
                            sAddress = dr.Field<string>("sAddress"),
                            sOccupation = dr.Field<string>("sOccupation"),
                            sEmployer = dr.Field<string>("sEmployer"),
                            captainName = dr.Field<string>("captainName"),
                            companionName = dr.Field<string>("companionName"),
                            cRelationship = dr.Field<string>("cRelationship"),
                            cAddress = dr.Field<string>("cAddress"),
                            eName = dr.Field<string>("eName"),
                            eRelationship = dr.Field<string>("eRelationship"),
                            eAddress = dr.Field<string>("eAddress"),
                            contact = dr.Field<string>("contact"),
                            isAdmitted = dr.Field<int>("isAdmitted"),
                            isDischarged = dr.Field<int>("isDischarged"),
                            dischargedDate = (dr.Field<int>("isDischarged") == 1) ? dr.Field<DateTime>("dischargeDate") : DateTime.Now,
                            dischargedTime = (dr.Field<int>("isDischarged") == 1) ? dr.Field<TimeSpan>("dischargeTime") : new TimeSpan(0, 0, 0),
                            blood_pressure = dr.Field<string>("bp"),
                            cc = dr.Field<string>("cc"),
                            pulse_rate = dr.Field<string>("pr"),
                            respiratory_rate = dr.Field<string>("rr"),
                            temperature = dr.Field<string>("temperature"),
                            o2sat = dr.Field<string>("o2sat"),
                            gcs = dr.Field<string>("gcs"),
                            nurseID = dr.Field<int>("nurseID")

                        });


                    }

                    return admissions;

                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

        public static List<Admission> GetAdmittedList()
        {
            List<Admission> admissions = new List<Admission>();

            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                };

                try
                {
                    var data = dal.ExecuteQuery("spGetAdmission", spParams).Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        admissions.Add(new Admission()
                        {
                            patient = new Patient()
                            {
                                id = dr.Field<string>("patientID"),
                                firstname = dr.Field<string>("firstname"),
                                middlename = dr.Field<string>("middlename"),
                                lastname = dr.Field<string>("lastname"),
                                gender = char.Parse(dr.Field<string>("gender")),
                                contact = dr.Field<string>(47),
                                birthdate = dr.Field<DateTime>("birthyear"),
                                emergency_contact = dr.Field<string>("contact_emergency"),
                                isRegistered = dr.Field<int>("isRegistered"),
                                religion = dr.Field<string>("religion"),
                                citizenship = dr.Field<string>("citizenship"),
                                occupation = dr.Field<string>("occupation"),
                                address = dr.Field<string>("address"),
                                birthplace = dr.Field<string>("birthplace"),
                            },
                            doctor = new User()
                            {
                                firstname = dr.Field<string>(59),
                                lastname = dr.Field<string>(60),
                                id = dr.Field<int>(56)
                            },
                            nurse = new User()
                            {
                                firstname = dr.Field<string>(65),
                                lastname = dr.Field<string>(66)
                            },
                            id = dr.Field<int>("id"),
                            admittedDate = dr.Field<DateTime>("admittedDate"),
                            admittedTime = dr.Field<TimeSpan>("admittedTime"),
                            timesAdmitted = dr.Field<int>("timesAdmitted"),
                            ward = dr.Field<string>("ward"),
                            roomNo = dr.Field<int>("roomNo"),
                            bedNo = dr.Field<int>("bedNo"),
                            fatherName = dr.Field<string>("fatherName"),
                            fAddress = dr.Field<string>("fAddress"),
                            fEmployer = dr.Field<string>("fEmployer"),
                            fOccupation = dr.Field<string>("fOccupation"),
                            motherName = dr.Field<string>("motherName"),
                            mAddress = dr.Field<string>("mAddress"),
                            mOccupation = dr.Field<string>("mOccupation"),
                            mEmployer = dr.Field<string>("mEmployer"),
                            spouseName = dr.Field<string>("spouseName"),
                            sAddress = dr.Field<string>("sAddress"),
                            sOccupation = dr.Field<string>("sOccupation"),
                            sEmployer = dr.Field<string>("sEmployer"),
                            captainName = dr.Field<string>("captainName"),
                            companionName = dr.Field<string>("companionName"),
                            cRelationship = dr.Field<string>("cRelationship"),
                            cAddress = dr.Field<string>("cAddress"),
                            eName = dr.Field<string>("eName"),
                            eRelationship = dr.Field<string>("eRelationship"),
                            eAddress = dr.Field<string>("eAddress"),
                            contact = dr.Field<string>("contact"),
                            isAdmitted = dr.Field<int>("isAdmitted"),
                            isDischarged = dr.Field<int>("isDischarged"),
                            dischargedDate = (dr.Field<int>("isDischarged") == 1) ? dr.Field<DateTime>("dischargeDate") : DateTime.Now,
                            dischargedTime = (dr.Field<int>("isDischarged") == 1) ? dr.Field<TimeSpan>("dischargeTime") : new TimeSpan(0, 0, 0),
                            blood_pressure = dr.Field<string>("bp"),
                            cc = dr.Field<string>("cc"),
                            pulse_rate = dr.Field<string>("pr"),
                            respiratory_rate = dr.Field<string>("rr"),
                            temperature = dr.Field<string>("temperature"),
                            o2sat = dr.Field<string>("o2sat"),
                            gcs = dr.Field<string>("gcs"),
                            nurseID = dr.Field<int>("nurseID")

                        });


                    }

                    return admissions;

                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

        public static Admission SearchAdmission(string patientID)
        {
            Admission admission = null;

            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@patientID",patientID),
                };

                var data = dal.ExecuteQuery("spSearchAdmittedPatient", spParams).Tables[0];

                foreach (DataRow dr in data.AsEnumerable())
                {
                    admission = new Admission()
                    {
                        id = dr.Field<int>(0),
                        patient = new Patient()
                        {
                            id = dr.Field<string>(1),
                            firstname = dr.Field<string>(2),
                            middlename = dr.Field<string>(3),
                            lastname = dr.Field<string>(4),
                        }
                    };
                }
                return admission;
            }

        }
    }
}
