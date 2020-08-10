namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsIdeal : StripeEntity<ChargePaymentMethodDetailsIdeal>
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("bic")]
        public string Bic { get; set; }

        [JsonProperty("iban_last4")]
        public string IbanLast4 { get; set; }

        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
