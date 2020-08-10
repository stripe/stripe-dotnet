namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsAcssDebit : StripeEntity<ChargePaymentMethodDetailsAcssDebit>
    {
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("institution_number")]
        public string InstitutionNumber { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("mandate")]
        public string Mandate { get; set; }

        [JsonProperty("transit_number")]
        public string TransitNumber { get; set; }
    }
}
