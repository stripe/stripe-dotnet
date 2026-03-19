// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceSubscriptionDetailsItemBillingThresholdsOptions : INestedOptions
    {
        /// <summary>
        /// Number of units that meets the billing threshold to advance the subscription to a new
        /// billing period (e.g., it takes 10 $5 units to meet a $50 <a
        /// href="https://docs.stripe.com/api/subscriptions/update#update_subscription-billing_thresholds-amount_gte">monetary
        /// threshold</a>).
        /// </summary>
        [JsonProperty("usage_gte")]
        [STJS.JsonPropertyName("usage_gte")]
        public long? UsageGte { get; set; }
    }
}
