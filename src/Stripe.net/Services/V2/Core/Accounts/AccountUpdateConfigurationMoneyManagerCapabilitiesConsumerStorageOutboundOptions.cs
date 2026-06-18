// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesConsumerStorageOutboundOptions : INestedOptions
    {
        /// <summary>
        /// Can send consumer storage-type funds on Stripe in USD.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesConsumerStorageOutboundUsdOptions Usd { get; set; }

        /// <summary>
        /// Can send consumer storage-type funds on Stripe in USDC.
        /// </summary>
        [JsonProperty("usdc")]
        [STJS.JsonPropertyName("usdc")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesConsumerStorageOutboundUsdcOptions Usdc { get; set; }
    }
}
