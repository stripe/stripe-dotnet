// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationCardCreatorCapabilitiesCommercialCeltic : StripeEntity<AccountConfigurationCardCreatorCapabilitiesCommercialCeltic>
    {
        /// <summary>
        /// Can create commercial issuing charge cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge_card")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesCommercialCelticChargeCard ChargeCard { get; set; }

        /// <summary>
        /// Can create commercial issuing spend cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("spend_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spend_card")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesCommercialCelticSpendCard SpendCard { get; set; }
    }
}
