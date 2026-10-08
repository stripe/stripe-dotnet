// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageInboundOptions : INestedOptions
    {
        /// <summary>
        /// Can receive business custodial storage-type funds on Stripe in OUSD.
        /// </summary>
        [JsonProperty("ousd")]
        [STJS.JsonPropertyName("ousd")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageInboundOusdOptions Ousd { get; set; }

        /// <summary>
        /// Can receive business custodial storage-type funds on Stripe in USDC.
        /// </summary>
        [JsonProperty("usdc")]
        [STJS.JsonPropertyName("usdc")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessCustodialStorageInboundUsdcOptions Usdc { get; set; }
    }
}
