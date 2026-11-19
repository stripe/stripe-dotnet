// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferFailureDetailsNetworkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// ACH network failure details.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public InboundTransferFailureDetailsNetworkDetailsAchOptions Ach { get; set; }

        /// <summary>
        /// The network used to transfer funds.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
