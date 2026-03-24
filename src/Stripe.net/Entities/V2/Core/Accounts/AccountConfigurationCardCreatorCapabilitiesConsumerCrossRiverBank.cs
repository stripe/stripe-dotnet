// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationCardCreatorCapabilitiesConsumerCrossRiverBank : StripeEntity<AccountConfigurationCardCreatorCapabilitiesConsumerCrossRiverBank>
    {
        /// <summary>
        /// Can create consumer issuing prepaid cards with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountConfigurationCardCreatorCapabilitiesConsumerCrossRiverBankPrepaidCard PrepaidCard { get; set; }
    }
}
