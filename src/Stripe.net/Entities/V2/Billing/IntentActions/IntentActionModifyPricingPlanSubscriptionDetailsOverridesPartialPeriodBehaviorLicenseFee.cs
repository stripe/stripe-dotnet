// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentActionModifyPricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorLicenseFee : StripeEntity<IntentActionModifyPricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorLicenseFee>
    {
        /// <summary>
        /// The proration behavior for the partial servicing period. Defines how we prorate the
        /// license fee when the user modifies the subscription. If not specified, defaults to
        /// prorated.
        /// One of: <c>none</c>, or <c>prorated</c>.
        /// </summary>
        [JsonProperty("credit_proration_behavior")]
        [STJS.JsonPropertyName("credit_proration_behavior")]
        public string CreditProrationBehavior { get; set; }

        /// <summary>
        /// The proration behavior for the partial servicing period. Defines how we prorate the
        /// license fee when the user modifies the subscription. If not specified, defaults to
        /// prorated.
        /// One of: <c>none</c>, or <c>prorated</c>.
        /// </summary>
        [JsonProperty("debit_proration_behavior")]
        [STJS.JsonPropertyName("debit_proration_behavior")]
        public string DebitProrationBehavior { get; set; }
    }
}
