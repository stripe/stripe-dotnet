namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ExchangeRate : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("rates")]
        public Dictionary<string, decimal> Rates { get; set; }
    }
}
