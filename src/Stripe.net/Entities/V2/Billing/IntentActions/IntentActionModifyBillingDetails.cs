// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentActionModifyBillingDetails : StripeEntity<IntentActionModifyBillingDetails>
    {
        /// <summary>
        /// This controls the proration adjustment for the partial servicing period.
        /// One of: <c>no_adjustment</c>, or <c>prorated_adjustment</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_behavior")]
#endif
        public string ProrationBehavior { get; set; }
    }
}
