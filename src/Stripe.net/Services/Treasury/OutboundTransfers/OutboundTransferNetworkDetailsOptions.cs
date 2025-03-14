// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferNetworkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Optional fields for <c>ach</c>.
        /// </summary>
        [JsonProperty("ach")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach")]
#endif
        public OutboundTransferNetworkDetailsAchOptions Ach { get; set; }

        /// <summary>
        /// The type of flow that originated the OutboundTransfer.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
