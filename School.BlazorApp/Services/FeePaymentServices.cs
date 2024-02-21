using SchoolApp.Models.DataModels;
using System.Net.Http.Json;

namespace School.BlazorApp.Services
{
    public class FeePaymentServices
    {
        private string apiUrl = "https://localhost:7225/api/FeePayments";

        private string apiUrlStructure = "https://localhost:7225/api/FeeStructures";


        private readonly HttpClient http;

        public FeePaymentServices(HttpClient http)
        {
            this.http = http;
        }

        public Task<List<FeePayment>> getFeePayments()

        {
            return http.GetFromJsonAsync<List<FeePayment>>(apiUrl);

        }
        public Task<FeePayment> GetFeePayment(int id)
        {
            return http.GetFromJsonAsync<FeePayment>($"{this.apiUrl}/{id}");
        }
        public Task<HttpResponseMessage> SaveFeePayment (FeePayment feePayment)
        {
            return http.PostAsJsonAsync<FeePayment>(apiUrl, feePayment);
        }
        public Task<HttpResponseMessage> UpdateFeePayment(FeePayment feePayment)
        {
            return http.PutAsJsonAsync<FeePayment>($"{this.apiUrl}/{feePayment.FeePaymentId}", feePayment);
        }

        public Task<HttpResponseMessage> DeleteFeePayment(int id)
        {
            return http.DeleteAsync($"{apiUrl}/{id}");
        }

        public Task<List<FeeStructure>> getFeeStructure()

        {
            return http.GetFromJsonAsync<List<FeeStructure>>(apiUrlStructure);

        }
    }
}