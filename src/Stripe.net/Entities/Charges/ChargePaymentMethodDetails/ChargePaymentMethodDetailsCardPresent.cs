namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsCardPresent : StripeEntity<ChargePaymentMethodDetailsCardPresent>
    {
        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("emv_auth_data")]
        public string EmvAuthData { get; set; }

        [JsonProperty("exp_month")]
        public long ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("funding")]
        public string Funding { get; set; }

        [JsonProperty("generated_card")]
        public string GeneratedCardId { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("read_method")]
        public string ReadMethod { get; set; }

        [JsonProperty("receipt")]
        public ChargePaymentMethodDetailsCardPresentReceipt Receipt { get; set; }
    }
}
