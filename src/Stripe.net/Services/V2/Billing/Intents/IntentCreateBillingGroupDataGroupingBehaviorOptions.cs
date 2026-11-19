// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateBillingGroupDataGroupingBehaviorOptions : INestedOptions
    {
        /// <summary>
        /// The cadence configuration when type is <c>by_cadence</c>.
        /// </summary>
        [JsonProperty("by_cadence")]
        [STJS.JsonPropertyName("by_cadence")]
        public IntentCreateBillingGroupDataGroupingBehaviorByCadenceOptions ByCadence { get; set; }

        /// <summary>
        /// The grouping strategy.
        /// One of: <c>by_cadence</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
