// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsWechatPay : StripeEntity<PaymentRecordPaymentMethodDetailsWechatPay>
    {
        /// <summary>
        /// Uniquely identifies this particular WeChat Pay account. You can use this attribute to
        /// check whether two WeChat accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/terminal/locations">location</a> that
        /// this transaction's reader is assigned to.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/terminal/readers">reader</a> this
        /// transaction was made on.
        /// </summary>
        [JsonProperty("reader")]
        [STJS.JsonPropertyName("reader")]
        public string Reader { get; set; }

        /// <summary>
        /// Transaction ID of this particular WeChat Pay transaction.
        /// </summary>
        [JsonProperty("transaction_id")]
        [STJS.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
