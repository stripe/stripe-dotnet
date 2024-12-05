// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferNetworkDetails : StripeEntity<OutboundTransferNetworkDetails>
    {
        /// <summary>
        /// Details about an ACH transaction.
        /// </summary>
        [JsonProperty("ach")]
        public OutboundTransferNetworkDetailsAch Ach { get; set; }

        /// <summary>
        /// The type of flow that originated the OutboundTransfer.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
