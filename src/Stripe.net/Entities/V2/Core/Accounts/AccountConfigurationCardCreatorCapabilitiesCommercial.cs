// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationCardCreatorCapabilitiesCommercial : StripeEntity<AccountConfigurationCardCreatorCapabilitiesCommercial>
    {
        /// <summary>
        /// Can create commercial issuing cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("celtic")]
        [STJS.JsonPropertyName("celtic")]
        public AccountConfigurationCardCreatorCapabilitiesCommercialCeltic Celtic { get; set; }

        /// <summary>
        /// Can create commercial issuing cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("cross_river_bank")]
        [STJS.JsonPropertyName("cross_river_bank")]
        public AccountConfigurationCardCreatorCapabilitiesCommercialCrossRiverBank CrossRiverBank { get; set; }

        /// <summary>
        /// Can create commercial issuing cards with Fifth Third as a BIN sponsor.
        /// </summary>
        [JsonProperty("fifth_third")]
        [STJS.JsonPropertyName("fifth_third")]
        public AccountConfigurationCardCreatorCapabilitiesCommercialFifthThird FifthThird { get; set; }

        /// <summary>
        /// Can create commercial issuing cards with Lead as a BIN sponsor.
        /// </summary>
        [JsonProperty("lead")]
        [STJS.JsonPropertyName("lead")]
        public AccountConfigurationCardCreatorCapabilitiesCommercialLead Lead { get; set; }

        /// <summary>
        /// Can create commercial issuing cards with Stripe as a BIN sponsor.
        /// </summary>
        [JsonProperty("stripe")]
        [STJS.JsonPropertyName("stripe")]
        public AccountConfigurationCardCreatorCapabilitiesCommercialStripe Stripe { get; set; }
    }
}
