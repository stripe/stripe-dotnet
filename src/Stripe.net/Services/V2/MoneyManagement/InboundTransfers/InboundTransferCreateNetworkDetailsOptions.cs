// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferCreateNetworkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// ACH-specific network details. Only applied when the transfer routes over ACH.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public InboundTransferCreateNetworkDetailsAchOptions Ach { get; set; }
    }
}
