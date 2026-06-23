// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundOptions : INestedOptions
    {
        /// <summary>
        /// Can receive business storage-type funds on Stripe in AUD.
        /// </summary>
        [JsonProperty("aud")]
        [STJS.JsonPropertyName("aud")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundAudOptions Aud { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in CAD.
        /// </summary>
        [JsonProperty("cad")]
        [STJS.JsonPropertyName("cad")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundCadOptions Cad { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in EUR.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundEurOptions Eur { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in GBP.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundGbpOptions Gbp { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in USD.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundUsdOptions Usd { get; set; }
    }
}
