// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class LicenseFeeUpdateTransformQuantityOptions : INestedOptions
    {
        /// <summary>
        /// Divide usage by this number.
        /// </summary>
        [JsonProperty("divide_by")]
        [JsonConverter(typeof(StringInt64Converter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("divide_by")]
        [STJS.JsonConverter(typeof(STJStringInt64Converter))]
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
