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

        /// <summary>
        /// The type of the payment method associated with this mandate. An additional hash is
        /// included on <c>payment_method_details</c> with a name matching this value. It contains
        /// mandate information specific to the payment method.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
