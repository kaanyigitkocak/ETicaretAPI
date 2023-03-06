using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
  static class Configuration
  {
    static public string ConnectionString
    {
      get
      {
        ConfigurationManager configurationManager = new ConfigurationManager();
        configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "C:\\Users\\Algos YK\\Desktop\\Projects\\GitHub\\ETicaretAPI\\ETicaretAPI\\Presentation\\ETicaretAPI"));
        configurationManager.AddJsonFile("appsettings.json");
        return configurationManager.GetConnectionString("PostgreSql");
      }
    }
  }
}
