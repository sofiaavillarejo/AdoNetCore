using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AdoNetCore.Helpers
{
    public class HelperConfiguration
    {
        public static string GetConnectionString()
        {
            //pasamos aqui todo el codigo para recuperar la conexion del Form14
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true); //parámetros opcionales: false es que es obligatorio, si el fichero cambia que lo recargue
            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("SqlTajamar");
            return connectionString;
        }
    }
}
