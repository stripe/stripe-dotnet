// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationCardCreatorCapabilitiesCommercialOptions : INestedOptions
    {
        /// <summary>
        /// Can create commercial issuing cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("celtic")]
        [STJS.JsonPropertyName("celtic")]
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialCelticOptions Celtic { get; set; }

        /// <summary>
        /// Can create commercial issuing cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("cross_river_bank")]
        [STJS.JsonPropertyName("cross_river_bank")]
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankOptions CrossRiverBank { get; set; }

        /// <summary>
        /// Can create commercial issuing cards with Fifth Third as BIN sponsor.
        /// </summary>
        [JsonProperty("fifth_third")]
        [STJS.JsonPropertyName("fifth_third")]
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialFifthThirdOptions FifthThird { get; set; }

        /// <summary>
        /// Can create commercial issuing cards with Stripe as BIN sponsor.
        /// </summary>
        [JsonProperty("lead")]
        [STJS.JsonPropertyName("lead")]
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialLeadOptions Lead { get; set; }

        /// <summary>
        /// Can create commercial issuing cards with Stripe as BIN sponsor.
        /// </summary>
        [JsonProperty("stripe")]
        [STJS.JsonPropertyName("stripe")]
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialStripeOptions Stripe { get; set; }
    }
}
