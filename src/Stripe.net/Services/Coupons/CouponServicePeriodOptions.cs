// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CouponServicePeriodOptions : INestedOptions
    {
        /// <summary>
        /// Specifies coupon frequency. Either <c>day</c>, <c>week</c>, <c>month</c> or <c>year</c>.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals for which the coupon will be applied.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long? IntervalCount { get; set; }

        /// <summary>
        /// Specifies the number of times the coupon is contiguously applied.
        /// </summary>
        [JsonProperty("iterations")]
        [STJS.JsonPropertyName("iterations")]
        public CouponServicePeriodIterationsOptions Iterations { get; set; }
    }
}
