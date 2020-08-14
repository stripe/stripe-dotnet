namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetails : StripeEntity<MandatePaymentMethodDetails>
    {
        [JsonProperty("au_becs_debit")]
        public MandatePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public MandatePaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonProperty("card")]
        public MandatePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("sepa_debit")]
        public MandatePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
