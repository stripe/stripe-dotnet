// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CouponServicePeriod : StripeEntity<CouponServicePeriod>
    {
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long IntervalCount { get; set; }

        [JsonProperty("iterations")]
        [STJS.JsonPropertyName("iterations")]
        public CouponServicePeriodIterations Iterations { get; set; }
    }
}
