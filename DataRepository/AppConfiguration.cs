using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Common.Configuration
{
    public class AppConfiguration : Configuration
    {
        public AppConfiguration()
        {
            ConfigBuilder();
        }

        public override void ConfigBuilder()
        {
            foreach (string key in ConfigurationManager.AppSettings.AllKeys)
                AddProperty(key, ConfigurationManager.AppSettings[key]);
        }
    }
}
