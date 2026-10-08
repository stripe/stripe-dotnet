// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManagerCapabilitiesBusinessCustodialStorage : StripeEntity<AccountConfigurationMoneyManagerCapabilitiesBusinessCustodialStorage>
    {
        /// <summary>
        /// Can receive business custodial storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("inbound")]
        [STJS.JsonPropertyName("inbound")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageInbound Inbound { get; set; }

        /// <summary>
        /// Can send business custodial storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("outbound")]
        [STJS.JsonPropertyName("outbound")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageOutbound Outbound { get; set; }
    }
}
