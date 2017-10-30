using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeExchangeRates : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("rates")]
        public Dictionary<string, decimal> Rates { get; set; }
    }
}
