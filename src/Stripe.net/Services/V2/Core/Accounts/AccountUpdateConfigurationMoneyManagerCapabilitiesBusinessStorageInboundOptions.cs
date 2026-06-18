// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundOptions : INestedOptions
    {
        /// <summary>
        /// Can receive business storage-type funds on Stripe in AUD.
        /// </summary>
        [JsonProperty("aud")]
        [STJS.JsonPropertyName("aud")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundAudOptions Aud { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in CAD.
        /// </summary>
        [JsonProperty("cad")]
        [STJS.JsonPropertyName("cad")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundCadOptions Cad { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in EUR.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundEurOptions Eur { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in GBP.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundGbpOptions Gbp { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in USD.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundUsdOptions Usd { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in USDC.
        /// </summary>
        [JsonProperty("usdc")]
        [STJS.JsonPropertyName("usdc")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundUsdcOptions Usdc { get; set; }
    }
}
