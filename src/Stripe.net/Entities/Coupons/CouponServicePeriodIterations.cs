// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CouponServicePeriodIterations : StripeEntity<CouponServicePeriodIterations>
    {
        /// <summary>
        /// The number of iterations the service period will repeat for. Only used when type is
        /// <c>count</c>.
        /// </summary>
        [JsonProperty("count")]
        [STJS.JsonPropertyName("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The type of iterations.
        /// One of: <c>count</c>, or <c>forever</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
