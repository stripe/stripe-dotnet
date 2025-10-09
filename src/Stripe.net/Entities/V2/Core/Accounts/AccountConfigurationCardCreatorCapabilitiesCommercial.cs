// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationCardCreatorCapabilitiesCommercial : StripeEntity<AccountConfigurationCardCreatorCapabilitiesCommercial>
    {
        /// <summary>
        /// Can create commercial issuing cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("celtic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("celtic")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesCommercialCeltic Celtic { get; set; }

        /// <summary>
        /// Can create commercial issuing cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("cross_river_bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cross_river_bank")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesCommercialCrossRiverBank CrossRiverBank { get; set; }

        /// <summary>
        /// Can create commercial issuing cards with Stripe as a BIN sponsor.
        /// </summary>
        [JsonProperty("stripe")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesCommercialStripe Stripe { get; set; }
    }
}
