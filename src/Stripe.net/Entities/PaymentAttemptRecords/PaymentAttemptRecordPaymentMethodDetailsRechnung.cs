// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsRechnung : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsRechnung>
    {
        /// <summary>
        /// Payment portal URL.
        /// </summary>
        [JsonProperty("payment_portal_url")]
        [STJS.JsonPropertyName("payment_portal_url")]
        public string PaymentPortalUrl { get; set; }
    }
}
