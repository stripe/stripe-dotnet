// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManagerCapabilitiesBusinessStorage : StripeEntity<AccountConfigurationMoneyManagerCapabilitiesBusinessStorage>
    {
        /// <summary>
        /// Can receive business storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("inbound")]
        [STJS.JsonPropertyName("inbound")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorageInbound Inbound { get; set; }

        /// <summary>
        /// Can send business storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("outbound")]
        [STJS.JsonPropertyName("outbound")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorageOutbound Outbound { get; set; }
    }
}
