// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationCardCreatorCapabilitiesCommercialStripe : StripeEntity<AccountConfigurationCardCreatorCapabilitiesCommercialStripe>
    {
        /// <summary>
        /// Can create commercial issuing charge cards with Stripe as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge_card")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesCommercialStripeChargeCard ChargeCard { get; set; }

        /// <summary>
        /// Can create commercial issuing prepaid cards with Stripe as BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prepaid_card")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesCommercialStripePrepaidCard PrepaidCard { get; set; }
    }
}
