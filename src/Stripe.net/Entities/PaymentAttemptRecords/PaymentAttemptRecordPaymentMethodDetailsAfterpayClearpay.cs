// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsAfterpayClearpay : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsAfterpayClearpay>
    {
        /// <summary>
        /// The Afterpay order ID associated with this payment intent.
        /// </summary>
        [JsonProperty("order_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("order_id")]
#endif
        public string OrderId { get; set; }

        /// <summary>
        /// Order identifier shown to the merchant in Afterpay’s online portal.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }
    }
}
