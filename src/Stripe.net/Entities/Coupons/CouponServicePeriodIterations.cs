// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CouponServicePeriodIterations : StripeEntity<CouponServicePeriodIterations>
    {
        [JsonProperty("count")]
        [STJS.JsonPropertyName("count")]
        public long? Count { get; set; }

        /// <summary>
        /// One of: <c>count</c>, or <c>forever</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
