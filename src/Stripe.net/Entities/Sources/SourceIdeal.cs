namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceIdeal : StripeEntity<SourceIdeal>
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("bic")]
        public string Bic { get; set; }

        [JsonProperty("iban_last4")]
        public string IbanLast4 { get; set; }
    }
}
