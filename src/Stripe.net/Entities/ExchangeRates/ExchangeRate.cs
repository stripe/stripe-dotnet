namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ExchangeRate : StripeEntity<ExchangeRate>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("rates")]
        public Dictionary<string, decimal> Rates { get; set; }
    }
}
