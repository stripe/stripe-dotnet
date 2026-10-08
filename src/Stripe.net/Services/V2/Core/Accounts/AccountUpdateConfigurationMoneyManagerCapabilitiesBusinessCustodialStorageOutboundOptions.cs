// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageOutboundOptions : INestedOptions
    {
        /// <summary>
        /// Can send business custodial storage-type funds on Stripe in OUSD.
        /// </summary>
        [JsonProperty("ousd")]
        [STJS.JsonPropertyName("ousd")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageOutboundOusdOptions Ousd { get; set; }

        /// <summary>
        /// Can send business custodial storage-type funds on Stripe in USDC.
        /// </summary>
        [JsonProperty("usdc")]
        [STJS.JsonPropertyName("usdc")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageOutboundUsdcOptions Usdc { get; set; }
    }
}
