// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsAfterpayClearpay : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsAfterpayClearpay>
    {
        /// <summary>
        /// The Afterpay order ID associated with this payment intent.
        /// </summary>
        [JsonProperty("order_id")]
        [STJS.JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// Order identifier shown to the merchant in Afterpay's online portal.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
