using FSDHAPi.Context;
using FSDHAPi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FSDHAPi.Controllers
{
    public class FDSHIdentityController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _clientFactory;
        private readonly RepositoryContext _db;



        public FDSHIdentityController(IConfiguration configuration, IHttpClientFactory client, RepositoryContext db)
        {
            _clientFactory = client;
            _configuration = configuration;
            _db = db;

        }



        [HttpPost]
        [Route("api/Balance/bvn/multiple")]
        public async Task<object> GetMultipleBVN([FromBody] BVN bn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("BVNUrl").Value.ToString();

            error.status = true;

            if (string.IsNullOrEmpty(bn.bvn))
            {
                return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            }


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
        [Route("api/Balance/bvn/single")]
        public async Task<object> GetSingleBVN([FromBody] BVN bn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("BVNSingleUrl").Value.ToString();

            error.status = true;

            if (string.IsNullOrEmpty(bn.bvn))
            {
                return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            }


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
        [Route("api/Balance/bvn/date")]
        public async Task<object> GetSingleBVNdate([FromBody] BVN bn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("BVNSingleUrlDate").Value.ToString();

            error.status = true;

            if (string.IsNullOrEmpty(bn.bvn))
            {
                return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            }


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
        [Route("api/Balance/bvn/otp")]
        public async Task<object> GetSingleBVNotp([FromBody] BVN bn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("BVNSingleOTPUrl").Value.ToString();

            error.status = true;

            if (string.IsNullOrEmpty(bn.bvn))
            {
                return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            }


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
        [Route("api/Balance/otp/validate")]
        public async Task<object> GetSingleBVNotpValidate([FromRoute] Otp bn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("BVNSingleOTPvalidateUrl").Value.ToString();

            error.status = true;

            if (string.IsNullOrEmpty(bn.RecordReference) && string.IsNullOrEmpty(bn.OTP))
            {
                return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            }


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
        [Route("api/Balance/bvn/iswatchlisted")]
        public async Task<object> GetBVNWatchlisted([FromBody] BVN bn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("isBvnWatchlistedUrl").Value.ToString();

            error.status = true;

            if (string.IsNullOrEmpty(bn.bvn))
            {
                return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            }


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
        [Route("api/Balance/bvn/validate")]
        public async Task<object> ValidateBVN([FromBody] ValidateBvnPayload bn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("ValidateBVNUrl").Value.ToString();

            error.status = true;

            if (string.IsNullOrEmpty(bn.bvn))
            {
                return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            }


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
        [Route("api/Balance/bvn/multiple")]
        public async Task<object> VerifyMultipleBVN([FromBody] BVN bn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("VerifymultipleBVNUrl").Value.ToString();

            error.status = true;

            if (string.IsNullOrEmpty(bn.bvn))
            {
                return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            }


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
        [Route("api/Balance/bvn/single")]
        public async Task<object> VerifySingleBVN([FromBody] verifySingleBVN bn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("VerifysingleBVNUrl").Value.ToString();

            error.status = true;

            if (string.IsNullOrEmpty(bn.bvn))
            {
                return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            }


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
        [Route("api/Balance/bvn/date")]
        public async Task<object> VerifySingleBVNdate([FromBody] verifySingleBVN bn)
        {
            ErrorResponse error = new ErrorResponse();
            var testkey = _configuration.GetSection("Token").Value.ToString();
            var baseaddress = _configuration.GetSection("VerifysingleBVNUrl").Value.ToString();

            error.status = true;

            if (string.IsNullOrEmpty(bn.bvn))
            {
                return new ErrorResponse { message = "Account Number Cannot be empty", status = false };
            }


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
