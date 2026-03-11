// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankOptions : INestedOptions
    {
        /// <summary>
        /// Can create commercial issuing charge cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge_card")]
#endif
        public AccountUpdateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankChargeCardOptions ChargeCard { get; set; }

        /// <summary>
        /// Can create commercial issuing prepaid cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prepaid_card")]
#endif
        public AccountUpdateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankPrepaidCardOptions PrepaidCard { get; set; }

        /// <summary>
        /// Can create commercial issuing spend cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("spend_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spend_card")]
#endif
        public AccountUpdateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankSpendCardOptions SpendCard { get; set; }
    }
}
