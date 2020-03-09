﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class BillHelper
    {
        public static void SaveBill(Bill bill)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@transactionID",bill.transactionID),
                    new SqlParameter("@admissionID",bill.admittedID),
                };

                dal.ExecuteQuery("spSaveBill", spParams);
            }
        }

        public static List<Bill> BillList()
        {
            List<Bill> bills = null; ;

            using (DAL dal = new DAL())
            {
                var data = dal.ExecuteQuery("spBillList").Tables[0];

                bills = new List<Bill>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    bills.Add(new Bill()
                    {
                        admittedID = dr.Field<int>(4),

                        patient = new Patient()
                        {
                            id = dr.Field<string>("id"),
                            firstname = dr.Field<string>("firstname"),
                            middlename = dr.Field<string>("middlename"),
                            lastname = dr.Field<string>("lastname"),
                        }
                    });
                }

                return bills;
            }
        }

        public static List<MedicineRequest> GetMedicineRequests(int admissionID)
        {
            List<MedicineRequest> medicineRequests = null;

            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@admissionID",admissionID),
                };
                var data = dal.ExecuteQuery("spGetMedicineRequest",spParams).Tables[0];

                medicineRequests = new List<MedicineRequest>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    medicineRequests.Add(new MedicineRequest()
                    {
                        id = dr.Field<int>("id"),
                        transactionID = dr.Field<int>("transactionID"),
                        admittedID = dr.Field<int>("admissionID"),
                        price = dr.Field<decimal>("price"),
                        name = dr.Field<string>("name")

                    });
                }

                return medicineRequests;
            }
        }
    }
}
