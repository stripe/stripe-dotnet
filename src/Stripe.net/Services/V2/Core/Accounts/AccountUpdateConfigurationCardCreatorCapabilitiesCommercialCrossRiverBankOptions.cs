// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankOptions : INestedOptions
    {
        /// <summary>
        /// Can create commercial issuing charge cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
        [STJS.JsonPropertyName("charge_card")]
        public AccountUpdateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankChargeCardOptions ChargeCard { get; set; }

        /// <summary>
        /// Can create commercial issuing prepaid cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountUpdateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankPrepaidCardOptions PrepaidCard { get; set; }

        /// <summary>
        /// Can create commercial issuing spend cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("spend_card")]
        [STJS.JsonPropertyName("spend_card")]
        public AccountUpdateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankSpendCardOptions SpendCard { get; set; }
    }
}
