using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Stripe
{
    public static class Configuration
    {
        static string _ApiKey = "";

        internal static string GetApiKey()
        {
            if (_ApiKey == "")
            {
                _ApiKey = ConfigurationManager.AppSettings["StripeApiKey"];
            }
            return _ApiKey;
        }

        public static void SetApiKey(string newApiKey)
        {
            _ApiKey = newApiKey;
        }
    }
}
