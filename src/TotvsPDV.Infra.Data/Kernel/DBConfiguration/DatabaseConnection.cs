using Microsoft.Extensions.Configuration;
using System.IO;

namespace TotvsPDV.Infra.Data.Kernel.DBConfiguration
{
    internal class DatabaseConnection
    {
        public static IConfiguration ConnectionConfiguration
        {
            get
            {
                IConfigurationRoot Configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                return Configuration;
            }
        }
    }
}
