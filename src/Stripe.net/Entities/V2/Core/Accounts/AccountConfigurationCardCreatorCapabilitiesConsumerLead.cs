// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationCardCreatorCapabilitiesConsumerLead : StripeEntity<AccountConfigurationCardCreatorCapabilitiesConsumerLead>
    {
        /// <summary>
        /// Can create consumer issuing prepaid cards with Lead as BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountConfigurationCardCreatorCapabilitiesConsumerLeadPrepaidCard PrepaidCard { get; set; }
    }
}
