// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionRefundPaymentRefundPaymentConfig : StripeEntity<ReaderActionRefundPaymentRefundPaymentConfig>
    {
        /// <summary>
        /// Enable customer-initiated cancellation when refunding this payment.
        /// </summary>
        [JsonProperty("enable_customer_cancellation")]
        [STJS.JsonPropertyName("enable_customer_cancellation")]
        public bool EnableCustomerCancellation { get; set; }
    }
}
