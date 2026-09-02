// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionSubscribePricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorRecurringCreditGrantOptions : INestedOptions
    {
        /// <summary>
        /// Controls credit grant creation behavior during partial periods. If not specified,
        /// defaults to full_credits.
        /// One of: <c>full_credits</c>, or <c>none</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("create_behavior")]
        [STJS.JsonPropertyName("create_behavior")]
        public string CreateBehavior { get; set; }
    }
}
