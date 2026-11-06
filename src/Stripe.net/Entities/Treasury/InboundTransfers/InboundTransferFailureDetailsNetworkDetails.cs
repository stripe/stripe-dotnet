// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferFailureDetailsNetworkDetails : StripeEntity<InboundTransferFailureDetailsNetworkDetails>
    {
        /// <summary>
        /// ACH return details.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public InboundTransferFailureDetailsNetworkDetailsAch Ach { get; set; }
    }
}
