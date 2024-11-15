// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceScheduleDetailsPhaseItemBillingThresholdsOptions : INestedOptions
    {
        /// <summary>
        /// Number of units that meets the billing threshold to advance the subscription to a new
        /// billing period (e.g., it takes 10 $5 units to meet a $50 <a
        /// href="https://stripe.com/docs/api/subscriptions/update#update_subscription-billing_thresholds-amount_gte">monetary
        /// threshold</a>).
        /// </summary>
        [JsonProperty("usage_gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_gte")]
#endif

        public long? UsageGte { get; set; }
    }
}
