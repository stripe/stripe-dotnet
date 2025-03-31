// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestCreatedOptions : INestedOptions
    {
        /// <summary>
        /// Return results where the <c>created</c> field is greater than this value.
        /// </summary>
        [JsonProperty("gt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gt")]
#endif
        public long? Gt { get; set; }

        /// <summary>
        /// Return results where the <c>created</c> field is greater than or equal to this value.
        /// </summary>
        [JsonProperty("gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gte")]
#endif
        public long? Gte { get; set; }

        /// <summary>
        /// Return results where the <c>created</c> field is less than this value.
        /// </summary>
        [JsonProperty("lt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lt")]
#endif
        public long? Lt { get; set; }

        /// <summary>
        /// Return results where the <c>created</c> field is less than or equal to this value.
        /// </summary>
        [JsonProperty("lte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lte")]
#endif
        public long? Lte { get; set; }
    }
}
