using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientManagement.Classes;

namespace PatientManagement.Firebase
{
    public class Firebase
    {
        IFirebaseConfig config;
        IFirebaseClient client;

        public Firebase()
        {
            config = new FirebaseConfig
            {
                AuthSecret = "8cRE1Gd0l1wHjdo2xOLMGBowt4196aAiLoDvBeFU",
                BasePath = "https://my-project-1560234682747.firebaseio.com"
            };
            client = new FireSharp.FirebaseClient(config);
        }
        public async void InsertPatientMember(Patient patient)
        {
            SetResponse response = await client.SetAsync("Patient/" + patient.id, patient);
            var result = response.ResultAs<Patient>();

            Console.WriteLine("Successfully saved");
        }

        public async void UpdatePatientMember(Patient patient)
        {
            var response = await client.UpdateAsync("Patient/" + patient.id, patient);
            var result = response.ResultAs<Patient>();

            Console.WriteLine("Successfully updated");
        }
        public async void InsertCheckUp(Checkup checkup)
        {
            SetResponse response = await client.SetAsync("Checkup/" +checkup.id,checkup);
            var result = response.ResultAs<Checkup>();

            Console.WriteLine("Successfully saved");
        }

        public async void UpdateCheckUp(Checkup checkup)
        {
            var response = await client.UpdateAsync("Checkup/" + checkup.id, checkup);
            var result = response.ResultAs<Checkup>();

            Console.WriteLine("Successfully saved");
        }

        public async void InsertAdmission(Admission admission)
        {
            SetResponse response = await client.SetAsync("Admission/" + admission.id, admission);
            var result = response.ResultAs<Checkup>();

            Console.WriteLine("Successfully saved");
        }

        public async void UpdateAdmission(Admission admission)
        {
            var response = await client.UpdateAsync("Admission/" + admission.id, admission);
            var result = response.ResultAs<Checkup>();

            Console.WriteLine("Successfully saved");
        }
    
        public async void InsertMedicine(List<Medicine> medicines)
        {
            foreach(var m in medicines)
            {
                SetResponse response = await client.SetAsync("Medicine/" + m.id, m);
                var result = response.ResultAs<Medicine>();

                Console.WriteLine("Successfully saved");
            }
        }

        public async void UpdateQuantityMedicine(List<Medicine> medicines)
        {
            foreach (var m in medicines)
            {
                var response = await client.UpdateAsync("Medicine/" + m.id, m);
                var result = response.ResultAs<Medicine>();

                Console.WriteLine("Successfully update");
            }
        }

        public async void InsertBill(Bill bill)
        {

            SetResponse response = await client.SetAsync("Bill/" + bill.id, bill);
            var result = response.ResultAs<Bill>();

            Console.WriteLine("Successfully saved");

        }

        public async void UpdateBill(Bill bill)
        {

            var response = await client.UpdateAsync("Bill/" + bill.id, bill);
            var result = response.ResultAs<Bill>();

            Console.WriteLine("Successfully saved");

        }

    }
}
