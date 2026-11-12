// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertHistoryEntryCustomPaymentMethodAdapterDegraded : StripeEntity<AlertHistoryEntryCustomPaymentMethodAdapterDegraded>
    {
        /// <summary>
        /// Whether the custom payment method was disabled in Checkout as a result of the
        /// degradation. True while the alert is open and false when it is resolved.
        /// </summary>
        [JsonProperty("custom_payment_method_disabled_from_checkout")]
        [STJS.JsonPropertyName("custom_payment_method_disabled_from_checkout")]
        public bool CustomPaymentMethodDisabledFromCheckout { get; set; }

        /// <summary>
        /// The custom payment method type whose adapter is unhealthy.
        /// </summary>
        [JsonProperty("custom_payment_method_type_details")]
        [STJS.JsonPropertyName("custom_payment_method_type_details")]
        public AlertHistoryEntryCustomPaymentMethodAdapterDegradedCustomPaymentMethodTypeDetails CustomPaymentMethodTypeDetails { get; set; }

        /// <summary>
        /// The reason the adapter's health is degraded.
        /// </summary>
        [JsonProperty("degraded_health_reason")]
        [STJS.JsonPropertyName("degraded_health_reason")]
        public string DegradedHealthReason { get; set; }
    }
}
