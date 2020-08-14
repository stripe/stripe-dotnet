namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationMerchantData : StripeEntity<AuthorizationMerchantData>
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
    }
}
