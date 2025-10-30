// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationCardCreatorCapabilitiesCommercialLead : StripeEntity<AccountConfigurationCardCreatorCapabilitiesCommercialLead>
    {
        /// <summary>
        /// Can create commercial Global(cross border) issuing prepaid cards with Lead as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prepaid_card")]
#endif
        public AccountConfigurationCardCreatorCapabilitiesCommercialLeadPrepaidCard PrepaidCard { get; set; }
    }
}
