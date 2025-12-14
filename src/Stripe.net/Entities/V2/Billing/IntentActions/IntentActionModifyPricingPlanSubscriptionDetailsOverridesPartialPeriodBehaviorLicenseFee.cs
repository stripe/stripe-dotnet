// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionModifyPricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorLicenseFee : StripeEntity<IntentActionModifyPricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorLicenseFee>
    {
        /// <summary>
        /// The proration behavior for the partial servicing period. Defines how we prorate the
        /// license fee when the user is upgrading.
        /// One of: <c>none</c>, or <c>prorated</c>.
        /// </summary>
        [JsonProperty("credit_proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_proration_behavior")]
#endif
        public string CreditProrationBehavior { get; set; }

        /// <summary>
        /// The proration behavior for the partial servicing period. Defines how we prorate the
        /// license fee when the user is downgrading.
        /// One of: <c>none</c>, or <c>prorated</c>.
        /// </summary>
        [JsonProperty("debit_proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("debit_proration_behavior")]
#endif
        public string DebitProrationBehavior { get; set; }
    }
}
