// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PriceTransformQuantity : StripeEntity<PriceTransformQuantity>
    {
        /// <summary>
        /// Divide usage by this number.
        /// </summary>
        [JsonProperty("divide_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("divide_by")]
#endif
        public long DivideBy { get; set; }

        /// <summary>
        /// After division, either round the result <c>up</c> or <c>down</c>.
        /// One of: <c>down</c>, or <c>up</c>.
        /// </summary>
        [JsonProperty("round")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("round")]
#endif
        public string Round { get; set; }
    }
}
