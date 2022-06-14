// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferNetworkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Optional fields for <c>ach</c>.
        /// </summary>
        [JsonProperty("ach")]
        public OutboundTransferNetworkDetailsAchOptions Ach { get; set; }

        /// <summary>
        /// The type of flow that originated the OutboundTransfer.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
