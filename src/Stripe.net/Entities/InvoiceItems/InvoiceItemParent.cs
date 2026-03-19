// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItemParent : StripeEntity<InvoiceItemParent>
    {
        /// <summary>
        /// Details about the rate card subscription that generated this invoice item.
        /// </summary>
        [JsonProperty("rate_card_subscription_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_subscription_details")]
#endif
        public InvoiceItemParentRateCardSubscriptionDetails RateCardSubscriptionDetails { get; set; }

        /// <summary>
        /// Details about the subscription schedule that generated this invoice item.
        /// </summary>
        [JsonProperty("schedule_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule_details")]
#endif
        public InvoiceItemParentScheduleDetails ScheduleDetails { get; set; }

        /// <summary>
        /// Details about the subscription that generated this invoice item.
        /// </summary>
        [JsonProperty("subscription_details")]
        [STJS.JsonPropertyName("subscription_details")]
        public InvoiceItemParentSubscriptionDetails SubscriptionDetails { get; set; }

        /// <summary>
        /// The type of parent that generated this invoice item.
        /// One of: <c>pricing_plan_subscription_details</c>, <c>rate_card_subscription_details</c>,
        /// <c>schedule_details</c>, or <c>subscription_details</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Details about the pricing plan subscription that generated this invoice item.
        /// </summary>
        [JsonProperty("pricing_plan_subscription_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_subscription_details")]
#endif
        public InvoiceItemParentPricingPlanSubscriptionDetails PricingPlanSubscriptionDetails { get; set; }
    }
}
