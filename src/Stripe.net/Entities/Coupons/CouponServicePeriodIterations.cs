// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CouponServicePeriodIterations : StripeEntity<CouponServicePeriodIterations>
    {
        [JsonProperty("count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("count")]
#endif
        public long? Count { get; set; }

        /// <summary>
        /// One of: <c>count</c>, or <c>forever</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
