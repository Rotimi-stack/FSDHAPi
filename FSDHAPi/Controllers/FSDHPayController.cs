using FSDHAPi.Context;
using FSDHAPi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FSDHAPi.Controllers
{
    public class FSDHPayController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _clientFactory;
        private readonly RepositoryContext _db;


        
        public FSDHPayController(IConfiguration configuration, IHttpClientFactory client, RepositoryContext db)
        {
            _clientFactory = client;
            _configuration = configuration;
            _db = db;

        }



        [HttpGet]
        [Route("api/Balance/GetBalanceEnquiry")]
        public async Task<object> GetBalanceEnquiry([FromBody]Payload py)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("BaseAddress").Value.ToString();
          
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

                var stringContent = new StringContent(JsonConvert.SerializeObject(py), Encoding.UTF8, "Application/Json");
                var resp = await client.GetAsync(baseaddress);
                var balanceResponse =  resp.Content.ReadAsStringAsync().Result;

                DateTime requestTime;
                DateTime responseTime;

                TblRequestandResponseLog requestForDb = new TblRequestandResponseLog();


                switch (resp.StatusCode)
                {
                    case HttpStatusCode.OK:

                        if (resp.IsSuccessStatusCode)
                        {
                            requestTime = DateTime.Now;
                            responseTime = DateTime.Now;
                            requestForDb = new TblRequestandResponseLog() { RequestType = "BVNCreditBureau", RequestPayload = JsonConvert.SerializeObject(py), Response = JsonConvert.SerializeObject(balanceResponse), RequestTimestamp = DateTime.Now, ResponseTimestamp = DateTime.Now, RequestBaseUrl = baseaddress };
                            _db.tblRequestandResponseLog.Add(requestForDb);
                            await _db.SaveChangesAsync();
                        }
                        else if (resp.StatusCode == HttpStatusCode.BadGateway || (resp.StatusCode == HttpStatusCode.Unauthorized) || resp.StatusCode == HttpStatusCode.BadRequest || resp.StatusCode == HttpStatusCode.ServiceUnavailable || resp.StatusCode == HttpStatusCode.InternalServerError || resp.StatusCode == HttpStatusCode.NotFound)
                        {
                            responseTime = DateTime.Now;
                            requestForDb = new TblRequestandResponseLog() { Response = JsonConvert.SerializeObject(balanceResponse), RequestTimestamp = responseTime };
                            await _db.SaveChangesAsync();
                            error = JsonConvert.DeserializeObject<ErrorResponse>(balanceResponse);
                            return resp.StatusCode;
                        }
                        break;

                    default:
                        if (!resp.IsSuccessStatusCode)
                        {
                            return (HttpStatusCode.ExpectationFailed, "Something went wrong");
                        }
                        return (balanceResponse);
                }
                 return (balanceResponse);
            }

        }

        [HttpGet]
        [Route("api/Balance/GetBanks")]
        public async Task<object> GetBanks([FromBody] Banks bn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("BankAddress").Value.ToString();

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
        [Route("api/Balance/GetFundsTransferDetails")]
        public async Task<object> GetFundsTransferDetails([FromBody] Funds  fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("FundAddress").Value.ToString();

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
        [Route("api/Balance/PostFundsTransfer")]
        public async Task<object> PostFundsTransfer([FromBody] FundsTransfer fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("FundAddress").Value.ToString();

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
        [Route("api/Balance/GetFundsTransferHistory")]
        public async Task<object> GetFundsTransferHistory([FromBody] TransferHistory fn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("FundsHistoryUrl").Value.ToString();

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
