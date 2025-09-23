// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionNameCollectionBusinessOptions : INestedOptions
    {
        /// <summary>
        /// Enable business name collection on the Checkout Session. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether the customer is required to provide a business name before completing the
        /// Checkout Session. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("optional")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("optional")]
#endif
        public bool? Optional { get; set; }
    }
}
