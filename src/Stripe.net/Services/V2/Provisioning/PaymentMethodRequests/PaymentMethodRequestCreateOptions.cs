// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentMethodRequestCreateOptions : BaseOptions
    {
        /// <summary>
        /// Whether the billing operation should use Stripe live-mode objects. When omitted, this
        /// resolves from the authenticated request context.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool? Livemode { get; set; }

        /// <summary>
        /// Owner of the requested payment method.
        /// </summary>
        [JsonProperty("payment_method_owner")]
        [STJS.JsonPropertyName("payment_method_owner")]
        public string PaymentMethodOwner { get; set; }

        /// <summary>
        /// Connected account to source the payment method from.
        /// </summary>
        [JsonProperty("source_account")]
        [STJS.JsonPropertyName("source_account")]
        public string SourceAccount { get; set; }

        /// <summary>
        /// Customer to source the payment method from.
        /// </summary>
        [JsonProperty("source_customer")]
        [STJS.JsonPropertyName("source_customer")]
        public string SourceCustomer { get; set; }

        /// <summary>
        /// Existing payment method to reuse instead of collecting a new one.
        /// </summary>
        [JsonProperty("source_payment_method")]
        [STJS.JsonPropertyName("source_payment_method")]
        public string SourcePaymentMethod { get; set; }

        /// <summary>
        /// Usage limit to apply to the requested payment method.
        /// </summary>
        [JsonProperty("usage_limits")]
        [STJS.JsonPropertyName("usage_limits")]
        public PaymentMethodRequestCreateUsageLimitsOptions UsageLimits { get; set; }
    }
}
