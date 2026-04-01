// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CouponServicePeriod : StripeEntity<CouponServicePeriod>
    {
        /// <summary>
        /// Specifies coupon frequency. Either <c>day</c>, <c>week</c>, <c>month</c> or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals for which the coupon will be applied.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long IntervalCount { get; set; }

        [JsonProperty("iterations")]
        [STJS.JsonPropertyName("iterations")]
        public CouponServicePeriodIterations Iterations { get; set; }
    }
}
