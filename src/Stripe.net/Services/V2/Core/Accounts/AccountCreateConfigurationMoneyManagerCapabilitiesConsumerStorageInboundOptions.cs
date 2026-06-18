// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesConsumerStorageInboundOptions : INestedOptions
    {
        /// <summary>
        /// Can receive consumer storage-type funds on Stripe in USD.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesConsumerStorageInboundUsdOptions Usd { get; set; }

        /// <summary>
        /// Can receive consumer storage-type funds on Stripe in USDC.
        /// </summary>
        [JsonProperty("usdc")]
        [STJS.JsonPropertyName("usdc")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesConsumerStorageInboundUsdcOptions Usdc { get; set; }
    }
}
