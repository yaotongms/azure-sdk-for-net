using Azure;
using Azure.Data.AppConfiguration;
using Azure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigToy
{
    internal class Common
    {
        public static ConfigurationClient GetClient()
        {
            return new ConfigurationClient(new Uri("https://annelo-azconfig-01.azconfig.io"), new DefaultAzureCredential());
        }

        public static void PrintContent(Response response)
        {
            Console.WriteLine("response.Content: ");
            Console.WriteLine(response.Content.ToString());
        }
    }
}
