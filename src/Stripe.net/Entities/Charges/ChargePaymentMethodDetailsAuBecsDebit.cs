namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsAuBecsDebit : StripeEntity<ChargePaymentMethodDetailsAuBecsDebit>
    {
        [JsonProperty("bsb_number")]
        public string BsbNumber { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("mandate")]
        public string Mandate { get; set; }
    }
}
