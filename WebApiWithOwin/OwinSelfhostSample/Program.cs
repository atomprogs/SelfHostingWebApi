using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OwinSelfhostSample
{
    class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:3456/";

            // Start OWIN host 

            try
            {
                WebApp.Start<Startup>(url: baseAddress);
                Console.WriteLine("Employee Service is started at " + baseAddress);
                // Create HttpCient and make a request to api/values 
                //HttpClient client = new HttpClient();

                //var response = client.GetAsync(baseAddress + "api/values").Result;

                //Console.WriteLine(response);
                //Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                //response = client.GetAsync(baseAddress + "api/Employees/GetEmployees").Result;

                //Console.WriteLine(response);
                //Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            //using (WebApp.Start<Startup>(url: baseAddress))
            //{
            //    // Create HttpCient and make a request to api/values 
            //    HttpClient client = new HttpClient();

            //    var response = client.GetAsync(baseAddress + "api/values").Result;

            //    Console.WriteLine(response);
            //    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            //}

            Console.ReadLine();
        }
    }
}
