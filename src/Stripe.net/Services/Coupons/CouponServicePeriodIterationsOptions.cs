// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CouponServicePeriodIterationsOptions : INestedOptions
    {
        /// <summary>
        /// The number of iterations the service period will repeat for. Only used when type is
        /// <c>count</c>, defaults to 1.
        /// </summary>
        [JsonProperty("count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("count")]
#endif
        public long? Count { get; set; }

        /// <summary>
        /// The type of iterations, defaults to <c>count</c> if omitted.
        /// One of: <c>count</c>, or <c>forever</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
