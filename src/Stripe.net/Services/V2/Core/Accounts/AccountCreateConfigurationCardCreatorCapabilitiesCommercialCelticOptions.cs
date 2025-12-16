// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationCardCreatorCapabilitiesCommercialCelticOptions : INestedOptions
    {
        /// <summary>
        /// Can create commercial issuing charge cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge_card")]
#endif
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialCelticChargeCardOptions ChargeCard { get; set; }

        /// <summary>
        /// Can create commercial issuing spend cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("spend_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spend_card")]
#endif
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialCelticSpendCardOptions SpendCard { get; set; }
    }
}
