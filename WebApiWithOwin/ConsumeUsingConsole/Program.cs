using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeUsingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:3456/";
            try
            {
                WebClient proxy = new WebClient();
                byte[] abc = proxy.DownloadData((new Uri(baseAddress + "api/Employees/GetEmployees")));
                Stream strm = new MemoryStream(abc);
                DataContractSerializer obj = new DataContractSerializer(typeof(object));
                string result = obj.ReadObject(strm).ToString();
                //Console.WriteLine(client.DoWork("Rajeev Ranjan"));
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}
