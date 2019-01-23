namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceAchDebit : StripeEntity<SourceAchDebit>
    {
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
