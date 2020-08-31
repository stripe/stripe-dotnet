namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodBacsDebit : StripeEntity<PaymentMethodBacsDebit>
    {
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
        /// Sort code of the bank account. (e.g., <c>10-20-30</c>).
        /// </summary>
        [JsonProperty("sort_code")]
        public string SortCode { get; set; }
    }
}
