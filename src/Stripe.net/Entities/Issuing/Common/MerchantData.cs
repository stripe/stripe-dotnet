namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class MerchantData : StripeEntity<MerchantData>
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("network_id")]
        public string NetworkId { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
