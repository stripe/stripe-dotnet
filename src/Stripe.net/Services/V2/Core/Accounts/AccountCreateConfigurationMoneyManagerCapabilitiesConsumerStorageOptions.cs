// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesConsumerStorageOptions : INestedOptions
    {
        /// <summary>
        /// Can receive consumer storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("inbound")]
        [STJS.JsonPropertyName("inbound")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesConsumerStorageInboundOptions Inbound { get; set; }

        /// <summary>
        /// Can send consumer storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("outbound")]
        [STJS.JsonPropertyName("outbound")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesConsumerStorageOutboundOptions Outbound { get; set; }
    }
}
