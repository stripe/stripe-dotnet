// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundOptions : INestedOptions
    {
        /// <summary>
        /// Can send business storage-type funds on Stripe in AUD.
        /// </summary>
        [JsonProperty("aud")]
        [STJS.JsonPropertyName("aud")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundAudOptions Aud { get; set; }

        /// <summary>
        /// Can send business storage-type funds on Stripe in CAD.
        /// </summary>
        [JsonProperty("cad")]
        [STJS.JsonPropertyName("cad")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundCadOptions Cad { get; set; }

        /// <summary>
        /// Can send business storage-type funds on Stripe in EUR.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundEurOptions Eur { get; set; }

        /// <summary>
        /// Can send business storage-type funds on Stripe in GBP.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundGbpOptions Gbp { get; set; }

        /// <summary>
        /// Can send business storage-type funds on Stripe in USD.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountCreateConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundUsdOptions Usd { get; set; }
    }
}
