// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationCardCreatorCapabilitiesCommercialStripeOptions : INestedOptions
    {
        /// <summary>
        /// Can create commercial issuing charge cards with Stripe as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
        [STJS.JsonPropertyName("charge_card")]
        public AccountUpdateConfigurationCardCreatorCapabilitiesCommercialStripeChargeCardOptions ChargeCard { get; set; }

        /// <summary>
        /// Can create commercial issuing prepaid cards with Stripe as BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountUpdateConfigurationCardCreatorCapabilitiesCommercialStripePrepaidCardOptions PrepaidCard { get; set; }
    }
}
