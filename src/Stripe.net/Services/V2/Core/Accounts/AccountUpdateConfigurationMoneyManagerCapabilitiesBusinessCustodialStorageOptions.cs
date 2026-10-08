// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageOptions : INestedOptions
    {
        /// <summary>
        /// Can receive business custodial storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("inbound")]
        [STJS.JsonPropertyName("inbound")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageInboundOptions Inbound { get; set; }

        /// <summary>
        /// Can send business custodial storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("outbound")]
        [STJS.JsonPropertyName("outbound")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageOutboundOptions Outbound { get; set; }
    }
}
