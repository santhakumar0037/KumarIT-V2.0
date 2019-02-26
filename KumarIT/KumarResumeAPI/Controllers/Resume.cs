using System.IO;
using Microsoft.Extensions.Configuration;

namespace KumarResumeAPI.Controllers
{
    public class Resume
    {
        public static IConfigurationRoot Configuration { get; set; }

        public string ResumeService()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("ResumeConfiguration.json");
            Configuration = builder.Build();

            foreach (var item in Configuration.AsEnumerable() )
            {
                var url = item.Value;
                return url;
            }

            return null;
        }
    }
}

