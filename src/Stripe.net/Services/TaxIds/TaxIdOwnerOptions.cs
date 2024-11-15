// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TaxIdOwnerOptions : INestedOptions
    {
        /// <summary>
        /// Account the tax ID belongs to. Required when <c>type=account</c>.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif

        public string Account { get; set; }

        /// <summary>
        /// Customer the tax ID belongs to. Required when <c>type=customer</c>.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif

        public string Customer { get; set; }

        /// <summary>
        /// Type of owner referenced.
        /// One of: <c>account</c>, <c>application</c>, <c>customer</c>, or <c>self</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
