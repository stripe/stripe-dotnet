// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteSubscriptionDataBillingScheduleBillFromRelative : StripeEntity<QuoteSubscriptionDataBillingScheduleBillFromRelative>
    {
        /// <summary>
        /// Specifies billing duration. Possible values are <c>day</c>, <c>week</c>, <c>month</c>,
        /// or <c>year</c>.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval")]
#endif
        public string Interval { get; set; }

        /// <summary>
        /// The multiplier applied to the interval.
        /// </summary>
        [JsonProperty("interval_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval_count")]
#endif
        public long? IntervalCount { get; set; }
    }
}
