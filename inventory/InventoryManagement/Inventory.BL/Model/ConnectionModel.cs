using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class ConnectionModel
    {
        public string connection { get; set; }
        public ConnectionModel()
        {
            var config = GetConfiguration();
            connection = config.GetSection("ConnectionStrings").GetSection("InventoryDB").Value;
        }

        public IConfigurationRoot GetConfiguration()
        {
            var build = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return build.Build();
        }
    }


}
