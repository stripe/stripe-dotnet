// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationCardCreatorCapabilitiesCommercialCelticOptions : INestedOptions
    {
        /// <summary>
        /// Can create commercial issuing charge cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
        [STJS.JsonPropertyName("charge_card")]
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialCelticChargeCardOptions ChargeCard { get; set; }

        /// <summary>
        /// Can create commercial issuing spend cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("spend_card")]
        [STJS.JsonPropertyName("spend_card")]
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialCelticSpendCardOptions SpendCard { get; set; }
    }
}
