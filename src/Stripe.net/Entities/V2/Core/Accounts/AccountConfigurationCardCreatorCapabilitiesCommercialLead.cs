// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationCardCreatorCapabilitiesCommercialLead : StripeEntity<AccountConfigurationCardCreatorCapabilitiesCommercialLead>
    {
        /// <summary>
        /// Can create commercial Global(cross border) issuing prepaid cards with Lead as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountConfigurationCardCreatorCapabilitiesCommercialLeadPrepaidCard PrepaidCard { get; set; }
    }
}
