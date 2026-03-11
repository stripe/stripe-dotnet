// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationCardCreatorCapabilitiesConsumer : StripeEntity<AccountConfigurationCardCreatorCapabilitiesConsumer>
    {
        /// <summary>
        /// Can create consumer issuing cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("celtic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("celtic")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesConsumerCeltic Celtic { get; set; }

        /// <summary>
        /// Can create consumer issuing cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("cross_river_bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cross_river_bank")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesConsumerCrossRiverBank CrossRiverBank { get; set; }

        /// <summary>
        /// Can create consumer issuing cards with Lead as BIN sponsor.
        /// </summary>
        [JsonProperty("lead")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lead")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesConsumerLead Lead { get; set; }
    }
}
