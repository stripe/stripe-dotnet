// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundTransferNetworkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Optional fields for <c>ach</c>.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public OutboundTransferNetworkDetailsAchOptions Ach { get; set; }

        /// <summary>
        /// The type of flow that originated the OutboundTransfer.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
