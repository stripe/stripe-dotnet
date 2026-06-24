// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManagerCapabilitiesBusinessStorageInbound : StripeEntity<AccountConfigurationMoneyManagerCapabilitiesBusinessStorageInbound>
    {
        /// <summary>
        /// Can receive business storage-type funds on Stripe in AUD.
        /// </summary>
        [JsonProperty("aud")]
        [STJS.JsonPropertyName("aud")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorageInboundAud Aud { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in CAD.
        /// </summary>
        [JsonProperty("cad")]
        [STJS.JsonPropertyName("cad")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorageInboundCad Cad { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in EUR.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorageInboundEur Eur { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in GBP.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorageInboundGbp Gbp { get; set; }

        /// <summary>
        /// Can receive business storage-type funds on Stripe in USD.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorageInboundUsd Usd { get; set; }
    }
}
