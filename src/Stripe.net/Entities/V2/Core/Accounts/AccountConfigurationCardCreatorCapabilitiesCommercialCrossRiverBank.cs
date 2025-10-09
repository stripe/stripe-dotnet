// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationCardCreatorCapabilitiesCommercialCrossRiverBank : StripeEntity<AccountConfigurationCardCreatorCapabilitiesCommercialCrossRiverBank>
    {
        /// <summary>
        /// Can create commercial issuing charge cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge_card")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankChargeCard ChargeCard { get; set; }

        /// <summary>
        /// Can create commercial issuing spend cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("spend_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spend_card")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankSpendCard SpendCard { get; set; }
    }
}
