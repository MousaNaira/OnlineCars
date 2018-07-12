using OnlineCars.Models;
using OnlineCars.Mvc.ConsumeWebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace OnlineCars.Mvc.Controllers
{
    public class SearchController : Controller
    {
        static HttpClient client = new HttpClient();


        // GET: Search
        public ActionResult Get()
        {
            // CallingWebApi _Obj = new ConsumeWebAPI.CallingWebApi();
            //var X= _Obj.GetAllCars();

            //  client.BaseAddress = new Uri();

            Response.AddHeader("Refresh", "5");

            IEnumerable<CarViewModel> Cars = null;

            //HTTP GET
            var responseTask = client.GetAsync("http://localhost:6240/api/OnlineCars/Get");
            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<CarViewModel>>();
                readTask.Wait();

                Cars = readTask.Result;
            }
            else //web api sent error response 
            {
                //log response status here..

                //students = Enumerable.Empty<StudentViewModel>();

                //ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            }
        

            return View(Cars);
        }


        public ActionResult GetSome(int PageNumber=1)
        {
            Session["PageNumber"] = PageNumber;

            IEnumerable<CarViewModel> Cars = null;

            //HTTP GET
            var responseTask = client.GetAsync("http://localhost:6240/api/OnlineCars/GetSome?PageNumber=1");
            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<CarViewModel>>();
                readTask.Wait();

                Cars = readTask.Result;
            }
            else //web api sent error response 
            {
                //log response status here..

                //students = Enumerable.Empty<StudentViewModel>();

                //ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            }


            return View(Cars);
        }


        [HttpGet]
        public ActionResult LoadMore()
        {
            int PageNumber =(int) Session["PageNumber"];
            Session["PageNumber"] = PageNumber++;
            IEnumerable<CarViewModel> Cars = null;

            var responseTask = client.GetAsync("http://localhost:6240/api/OnlineCars/GetSome?PageNumber="+ PageNumber);
            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<CarViewModel>>();
                readTask.Wait();

                Cars = readTask.Result;
            }
            else //web api sent error response 
            {
                //log response status here..

                //students = Enumerable.Empty<StudentViewModel>();

                //ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            }


            return View("Get",Cars);
          

        }



    }
}