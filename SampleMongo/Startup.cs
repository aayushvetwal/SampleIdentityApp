using System;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Sample.Startup))]

namespace Sample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            string conn = ConfigurationManager.ConnectionStrings["SampleDbConn"].ConnectionString;
            app.Use

        }
    }
}
