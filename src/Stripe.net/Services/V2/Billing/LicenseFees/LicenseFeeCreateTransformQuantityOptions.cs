// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class LicenseFeeCreateTransformQuantityOptions : INestedOptions
    {
        /// <summary>
        /// Divide usage by this number.
        /// </summary>
        [JsonProperty("divide_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("divide_by")]
#endif
        public long? DivideBy { get; set; }

        /// <summary>
        /// After division, round the result up or down.
        /// One of: <c>down</c>, or <c>up</c>.
        /// </summary>
        [JsonProperty("round")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("round")]
#endif
        public string Round { get; set; }
    }
}
