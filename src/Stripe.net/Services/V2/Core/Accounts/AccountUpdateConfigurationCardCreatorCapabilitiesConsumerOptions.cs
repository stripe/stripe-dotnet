// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationCardCreatorCapabilitiesConsumerOptions : INestedOptions
    {
        /// <summary>
        /// Can create consumer issuing cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("celtic")]
        [STJS.JsonPropertyName("celtic")]
        public AccountUpdateConfigurationCardCreatorCapabilitiesConsumerCelticOptions Celtic { get; set; }

        /// <summary>
        /// Can create consumer issuing cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("cross_river_bank")]
        [STJS.JsonPropertyName("cross_river_bank")]
        public AccountUpdateConfigurationCardCreatorCapabilitiesConsumerCrossRiverBankOptions CrossRiverBank { get; set; }

        /// <summary>
        /// Can create consumer issuing cards with Lead as BIN sponsor.
        /// </summary>
        [JsonProperty("lead")]
        [STJS.JsonPropertyName("lead")]
        public AccountUpdateConfigurationCardCreatorCapabilitiesConsumerLeadOptions Lead { get; set; }
    }
}
