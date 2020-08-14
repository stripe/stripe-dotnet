namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodAuBecsDebit : StripeEntity<PaymentMethodAuBecsDebit>
    {
        /// <summary>
        /// Six-digit number identifying bank and branch associated with this bank account.
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
    }
}
