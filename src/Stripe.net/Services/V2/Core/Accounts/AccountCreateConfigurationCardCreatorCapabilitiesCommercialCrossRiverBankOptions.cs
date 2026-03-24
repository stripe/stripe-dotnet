// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankOptions : INestedOptions
    {
        /// <summary>
        /// Can create commercial issuing charge cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
        [STJS.JsonPropertyName("charge_card")]
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankChargeCardOptions ChargeCard { get; set; }

        /// <summary>
        /// Can create commercial issuing prepaid cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankPrepaidCardOptions PrepaidCard { get; set; }

        /// <summary>
        /// Can create commercial issuing spend cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("spend_card")]
        [STJS.JsonPropertyName("spend_card")]
        public AccountCreateConfigurationCardCreatorCapabilitiesCommercialCrossRiverBankSpendCardOptions SpendCard { get; set; }
    }
}
