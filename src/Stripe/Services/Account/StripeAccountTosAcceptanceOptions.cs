using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountTosAcceptanceOptions
    {
        [JsonProperty("tos_acceptance[date]")]
        public string Date { get; set; }

        [JsonProperty("tos_acceptance[ip]")]
        public string Ip { get; set; }
    }
}
