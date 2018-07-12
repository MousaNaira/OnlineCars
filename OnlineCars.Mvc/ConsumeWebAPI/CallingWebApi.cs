using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace OnlineCars.Mvc.ConsumeWebAPI
{
    public  class CallingWebApi
    {
        static HttpClient client = new HttpClient();
        public CallingWebApi()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        
        public async Task<string> GetAllCars()
        {
            string URL = "http://localhost:6240/api/OnlineCars";

            HttpResponseMessage response = await client.GetAsync(URL);
            string JsonResult = await response.Content.ReadAsStringAsync();
            return JsonResult;

        }
    }
}