using Microsoft.Owin.Cors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http;

namespace OwinSelfhostSample
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            var policy = new CorsPolicy()
            {
                AllowAnyHeader = true,
                AllowAnyMethod = true,
                SupportsCredentials = true
            };

            // list of domains that are allowed can be added here.
            policy.Origins.Add("http://localhost:17332");
            policy.Origins.Add("http://localhost:21457");
           
            appBuilder.UseCors(new CorsOptions
            {
                PolicyProvider = new CorsPolicyProvider
                {
                    PolicyResolver = context => Task.FromResult(policy)
                }
            });
            appBuilder.UseWebApi(config);
        }



    }


}