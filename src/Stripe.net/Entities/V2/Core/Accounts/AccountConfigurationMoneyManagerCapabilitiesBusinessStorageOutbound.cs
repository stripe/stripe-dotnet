// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManagerCapabilitiesBusinessStorageOutbound : StripeEntity<AccountConfigurationMoneyManagerCapabilitiesBusinessStorageOutbound>
    {
        /// <summary>
        /// Can send business storage-type funds on Stripe in AUD.
        /// </summary>
        [JsonProperty("aud")]
        [STJS.JsonPropertyName("aud")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundAud Aud { get; set; }

        /// <summary>
        /// Can send business storage-type funds on Stripe in CAD.
        /// </summary>
        [JsonProperty("cad")]
        [STJS.JsonPropertyName("cad")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundCad Cad { get; set; }

        /// <summary>
        /// Can send business storage-type funds on Stripe in EUR.
        /// </summary>
        [JsonProperty("eur")]
        [STJS.JsonPropertyName("eur")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundEur Eur { get; set; }

        /// <summary>
        /// Can send business storage-type funds on Stripe in GBP.
        /// </summary>
        [JsonProperty("gbp")]
        [STJS.JsonPropertyName("gbp")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundGbp Gbp { get; set; }

        /// <summary>
        /// Can send business storage-type funds on Stripe in USD.
        /// </summary>
        [JsonProperty("usd")]
        [STJS.JsonPropertyName("usd")]
        public AccountConfigurationMoneyManagerCapabilitiesBusinessStorageOutboundUsd Usd { get; set; }
    }
}
