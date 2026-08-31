// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GrantedTokenUsageLimitsRecurringOptions : INestedOptions
    {
        /// <summary>
        /// The interval at which the shared payment token's amount usage restrictions reset.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals between each reset. Defaults to 1.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long? IntervalCount { get; set; }
    }
}
