namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsBacsDebit : StripeEntity<ChargePaymentMethodDetailsBacsDebit>
    {
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("mandate")]
        public string Mandate { get; set; }

        [JsonProperty("sort_code")]
        public string SortCode { get; set; }
    }
}
