namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsAuBecsDebit : StripeEntity<ChargePaymentMethodDetailsAuBecsDebit>
    {
        /// <summary>
        /// Bank-State-Branch number of the bank account.
        /// </summary>
        [JsonProperty("bsb_number")]
        public string BsbNumber { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// ID of the mandate used to make this payment.
        /// </summary>
        [JsonProperty("mandate")]
        public string Mandate { get; set; }
    }
}
