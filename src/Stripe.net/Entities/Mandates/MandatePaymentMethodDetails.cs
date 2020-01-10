namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetails : StripeEntity<MandatePaymentMethodDetails>
    {
        /// <summary>
        /// If this mandate is associated with a AU BECS Debit payment method, this hash contains
        /// mandate information specific to the AU BECS Debit payment method.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        public MandatePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        /// <summary>
        /// If this mandate is associated with a card payment method, this hash contains mandate
        /// information specific to the card payment method.
        /// </summary>
        [JsonProperty("card")]
        public MandatePaymentMethodDetailsCard Card { get; set; }

        /// <summary>
        /// If this mandate is associated with a SEPA debit payment method, this hash contains
        /// mandate information specific to the SEPA debit payment method.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public MandatePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// The type of the payment method associated with this mandate. An additional hash is
        /// included with a name matching this value. It contains mandate information specific to
        /// the payment method.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
