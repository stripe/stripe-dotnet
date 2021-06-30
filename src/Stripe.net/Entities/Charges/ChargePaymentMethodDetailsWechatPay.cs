// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsWechatPay : StripeEntity<ChargePaymentMethodDetailsWechatPay>
    {
        /// <summary>
        /// Uniquely identifies this particular WeChat Pay account. You can use this attribute to
        /// check whether two WeChat accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Transaction ID of this particular WeChat Pay transaction.
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}
