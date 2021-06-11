using FancyCashRegister.Domain.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCashRegister.Services.Data
{
    public class ConfigRepository
    {
        public const string KEY_LENGTE_PINCODE = "LengtePincode";
        public const string KEY_BEVESTIG_AFSLUITEN = "BevestigAfsluiten";
        public const string KEY_CONNECTIONSTRING = "developerland_kassa";

        public static Gebruiker HuidigeGebruiker { get; set; }

        public ConfigRepository()
        {

        }

        public T GetValue<T>(string key)
        {
            if (!ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                return default;
            }
            object val = ConfigurationManager.AppSettings[key];
            return (T)Convert.ChangeType(val, typeof(T));
        }

        public string GetValueAsString(string key)
        {
            try
            {
                if (ConfigurationManager.AppSettings.AllKeys.Contains(key))
                {
                    return ConfigurationManager.AppSettings[key];

                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }



        public Config GetAppConfig()
        {
            return new Config
            {
                LengtePincode = GetValue<int>(KEY_LENGTE_PINCODE),
                BevestigAfsluiten = GetValue<bool>(KEY_BEVESTIG_AFSLUITEN),
                ConnectionString = ConfigurationManager.ConnectionStrings[KEY_CONNECTIONSTRING].ConnectionString,
            };
        }
    }
}
