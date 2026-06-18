// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesConsumerStorageOptions : INestedOptions
    {
        /// <summary>
        /// Can receive consumer storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("inbound")]
        [STJS.JsonPropertyName("inbound")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesConsumerStorageInboundOptions Inbound { get; set; }

        /// <summary>
        /// Can send consumer storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("outbound")]
        [STJS.JsonPropertyName("outbound")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesConsumerStorageOutboundOptions Outbound { get; set; }
    }
}
