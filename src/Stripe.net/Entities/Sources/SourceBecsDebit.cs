namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceBecsDebit : StripeEntity
    {
        [JsonProperty("bsb_number")]
        public string BsbNumber { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("last3")]
        public string Last3 { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }
    }
}
