using FSDHAPi.Context;
using FSDHAPi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FSDHAPi.Controllers
{
    [ApiController]
    public class FSDH360Controller : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _clientFactory;
        private readonly RepositoryContext _db;



        public FSDH360Controller(IConfiguration configuration, IHttpClientFactory client, RepositoryContext db)
        {
            _clientFactory = client;
            _configuration = configuration;
            _db = db;

        }



        [HttpPost]
        [Route("api/fdsh360/transaction/history")]
        public async Task<object> GetDynamicAccountTransactionHistory([FromBody] TransactionHistory fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("TransactionHistoryUrl").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }


        [HttpDelete]
        [Route("api/fdsh360/delete/dynamic/Account")]
        public async Task<object> UnasignDynamicAccount([FromRoute] Payload fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("DeleteDynamicAccountURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }

        [HttpPut]
        [Route("api/fdsh360/update/dynamic/Account")]
        public async Task<object> UpdateDynamicAccount([FromBody] UpdateDynamicAccount fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("PutDynamicAccountURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }

        [HttpPost]
        [Route("api/fdsh360/dynamic/account/create")]
        public async Task<object> CreateDynamicAccount(CreateDynamicAccountPayload fn)
        {
            CreateDynamicAccountPayload f = new CreateDynamicAccountPayload();
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("CreateDynamicAccountURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + testkey);
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }

        [HttpGet]
        [Route("api/fdsh360/get/dynamic/account")]
        public async Task<object> GetDynamicAccount([FromBody] GetDynamicAccount fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("GetDynamicAccountURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }

        [HttpGet]
        [Route("api/fdsh360/get/dynamic/account/bvn")]
        public async Task<object> GetDynamicAccountbyBVN([FromBody] GetDynamicAccountBVN fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("GetDynamicAccountBVNURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }

        [HttpPost]
        [Route("api/fdsh360/balance/collection")]
        public async Task<object> QueryBalanceCollectionAccount([FromBody] Payload fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("QueryBalanceCollectionBVNURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }

        [HttpGet]
        [Route("api/fdsh360/get/dynamic/account/accountNo")]
        public async Task<object> GetAllAssignedDynamicAccountbyAccountNumber([FromRoute] GetDynamicAccountByAccountNum fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("GetdynamicAccountByAcctNoURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }

        [HttpGet]
        [Route("api/fdsh360/get/dynamic/account/unassigned")]
        public async Task<object> GetAllUnAssignedDynamicAccount([FromRoute] GetUnAssignedDynamicAccount fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("GetUnassignedDynamicAccountURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }

        [HttpGet]
        [ApiVersion("1.0")]
        [Route("api/{v:apiVersion}/FSDH360/get/dynamic/account/assigned")]
        public async Task<object> GetAllAssignedDynamicAccount([FromRoute] GetUnAssignedDynamicAccount fn)
        {
            object respinfo = new object();
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("GetassignedDynamicAccountURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue($"Bearer", $"{testkey}");
               // client.DefaultRequestHeaders.Add("Authorization", "Bearer " + testkey);
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;


                if (resp.IsSuccessStatusCode)
                {

                    respinfo = JsonConvert.DeserializeObject<object>(banksResponse);


                }

                return (respinfo);
            }

        }







        //static account v1


        [HttpGet]
        [Route("api/fdsh360/get/static/account")]
        public async Task<object> GetAllStaticAccount([FromRoute] GetUnAssignedDynamicAccount fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("GetStaticAccountURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }

        [HttpPost]
        [Route("api/fdsh360/create/static/account")]
        public async Task<object> CreateaStaticAccount([FromBody] TransactionHistory fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("CreateStaticAccountURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }

        [HttpPut]
        [Route("api/fdsh360/update/static/account")]
        public async Task<object> UpdateStaticAccount([FromBody] TransactionHistory fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("CreateStaticAccountURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }


        [HttpGet]
        [Route("api/fdsh360/get/static/account")]
        public async Task<object> GetAStaticAccount([FromRoute] GetUnAssignedDynamicAccount fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("GetFSDHAccountURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }


        [HttpGet]
        [Route("api/fdsh360/get/static/account/all")]
        public async Task<object> GetAllStaticAccountCollection([FromRoute] GetAllStaticAccountBVN fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("GetAllFSDHAStaticccountURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }


        [HttpPost]
        [Route("api/fdsh360/query/balance/collection/account ")]
        public async Task<object> QuerybalanceCollection([FromBody]  Payload fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("QueryAllFSDHAStaticccountURL").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }

        [HttpGet]
        [Route("api/fdsh360/get/static/account/bvn")]
        public async Task<object> GetAllStaticAccountByBVN([FromRoute] GetAccountByBVN fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("GetStaticAcctBVN").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }

        [HttpPost]
        [Route("api/fdsh360/static/transaction/details ")]
        public async Task<object> GetTransactionHistory([FromBody] TransactionHistory fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("GetTransactionHistoryUrl").Value.ToString();

            error.status = true;

            //if (string.IsNullOrEmpty(py.AccountNumber))
            //{
            //    return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            //}


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {testkey}");
                client.BaseAddress = new Uri(baseaddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new System.TimeSpan(0, 0, 1, 0);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var banksResponse = resp.Content.ReadAsStringAsync().Result;

                return (banksResponse);
            }







        }




    }
}
