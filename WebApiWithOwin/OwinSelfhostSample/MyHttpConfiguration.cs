using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinSelfhostSample
{
    public class MyHttpConfiguration : HttpConfiguration
    {
        public MyHttpConfiguration()
        {
            ConfigureRoutes();
            ConfigureJsonSerialization();
        }

        private void ConfigureRoutes()
        {
            Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private void ConfigureJsonSerialization()
        {
            Formatters.Clear();
            Formatters.Add(new JsonMediaTypeFormatter());
            Formatters.JsonFormatter.SerializerSettings.Re‌​ferenceLoopHandling = ReferenceLoopHandling.Ignore;
            var jsonSettings = Formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
