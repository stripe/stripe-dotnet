// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsWechatPay : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsWechatPay>
    {
        /// <summary>
        /// Uniquely identifies this particular WeChat Pay account. You can use this attribute to
        /// check whether two WeChat accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        /// <summary>
        /// ID of the <a href="https://stripe.com/docs/api/terminal/locations">location</a> that
        /// this transaction's reader is assigned to.
        /// </summary>
        [JsonProperty("location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
#endif
        public string Location { get; set; }

        /// <summary>
        /// ID of the <a href="https://stripe.com/docs/api/terminal/readers">reader</a> this
        /// transaction was made on.
        /// </summary>
        [JsonProperty("reader")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reader")]
#endif
        public string Reader { get; set; }

        /// <summary>
        /// Transaction ID of this particular WeChat Pay transaction.
        /// </summary>
        [JsonProperty("transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_id")]
#endif
        public string TransactionId { get; set; }
    }
}
