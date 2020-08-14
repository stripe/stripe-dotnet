namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsAlipay : StripeEntity<ChargePaymentMethodDetailsAlipay>
    {
        /// <summary>
        /// Uniquely identifies this particular Alipay account. You can use this attribute to check
        /// whether two Alipay accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Transaction ID of this particular Alipay transaction.
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}
