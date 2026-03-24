// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionDeactivatePricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorLicenseFeeOptions : INestedOptions
    {
        /// <summary>
        /// The proration behavior for the partial servicing period. Defines how we prorate the
        /// license fee when the user is deactivating. If not specified, defaults to none.
        /// One of: <c>none</c>, or <c>prorated</c>.
        /// </summary>
        [JsonProperty("credit_proration_behavior")]
        [STJS.JsonPropertyName("credit_proration_behavior")]
        public string CreditProrationBehavior { get; set; }
    }
}
