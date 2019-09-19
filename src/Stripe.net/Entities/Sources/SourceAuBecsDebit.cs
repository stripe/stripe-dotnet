namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceAuBecsDebit : StripeEntity<SourceAuBecsDebit>
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("bsb_number")]
        public string BsbNumber { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last3")]
        public string Last3 { get; set; }
    }
}
