using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration.Json;
using System.IO;

namespace DAL
{
    public class ConnectionStringManager
    {

        public string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",optional:true,reloadOnChange:true);
            return builder.Build().GetSection("ConnectionStrings").GetSection("CoffeeShopDB").Value;
        }

    }
}
