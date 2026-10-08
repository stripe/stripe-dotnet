// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageOutbound : StripeEntity<AccountConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageOutbound>
    {
        /// <summary>
        /// Can send business custodial storage-type funds on Stripe in OUSD.
        /// </summary>
        [JsonProperty("ousd")]
        [STJS.JsonPropertyName("ousd")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageOutboundOusd Ousd { get; set; }

        /// <summary>
        /// Can send business custodial storage-type funds on Stripe in USDC.
        /// </summary>
        [JsonProperty("usdc")]
        [STJS.JsonPropertyName("usdc")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageOutboundUsdc Usdc { get; set; }
    }
}
