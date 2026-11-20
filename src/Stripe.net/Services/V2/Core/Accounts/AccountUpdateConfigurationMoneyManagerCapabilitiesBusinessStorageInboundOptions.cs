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
        /// Can receive business storage-type funds on Stripe in CHF.
        /// </summary>
        [JsonProperty("chf")]
        [STJS.JsonPropertyName("chf")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundChfOptions Chf { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in CZK.
        /// </summary>
        [JsonProperty("czk")]
        [STJS.JsonPropertyName("czk")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundCzkOptions Czk { get; set; }

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
        /// Can receive business storage-type funds on Stripe in HKD.
        /// </summary>
        [JsonProperty("hkd")]
        [STJS.JsonPropertyName("hkd")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundHkdOptions Hkd { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in HUF.
        /// </summary>
        [JsonProperty("huf")]
        [STJS.JsonPropertyName("huf")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundHufOptions Huf { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in JPY.
        /// </summary>
        [JsonProperty("jpy")]
        [STJS.JsonPropertyName("jpy")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundJpyOptions Jpy { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in NOK.
        /// </summary>
        [JsonProperty("nok")]
        [STJS.JsonPropertyName("nok")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundNokOptions Nok { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in OUSD.
        /// </summary>
        [JsonProperty("ousd")]
        [STJS.JsonPropertyName("ousd")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundOusdOptions Ousd { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in PLN.
        /// </summary>
        [JsonProperty("pln")]
        [STJS.JsonPropertyName("pln")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundPlnOptions Pln { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in RON.
        /// </summary>
        [JsonProperty("ron")]
        [STJS.JsonPropertyName("ron")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundRonOptions Ron { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in SEK.
        /// </summary>
        [JsonProperty("sek")]
        [STJS.JsonPropertyName("sek")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundSekOptions Sek { get; set; }

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

        /// <summary>
        /// Can receive business storage-type funds on Stripe in ZAR.
        /// </summary>
        [JsonProperty("zar")]
        [STJS.JsonPropertyName("zar")]
        public AccountUpdateConfigurationMoneyManagerCapabilitiesBusinessStorageInboundZarOptions Zar { get; set; }
    }
}
