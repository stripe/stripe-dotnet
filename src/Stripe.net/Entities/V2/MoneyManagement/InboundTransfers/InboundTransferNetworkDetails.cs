// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferNetworkDetails : StripeEntity<InboundTransferNetworkDetails>
    {
        /// <summary>
        /// ACH-specific network details.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public InboundTransferNetworkDetailsAch Ach { get; set; }
    }
}
