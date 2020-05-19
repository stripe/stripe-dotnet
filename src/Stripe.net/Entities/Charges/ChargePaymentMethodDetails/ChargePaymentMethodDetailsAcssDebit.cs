namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsAcssDebit : StripeEntity<ChargePaymentMethodDetailsAcssDebit>
    {
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("institution_number")]
        public string InstitutionNumber { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("transit_number")]
        public string TransitNumber { get; set; }
    }
}
