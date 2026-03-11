// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationCardCreatorCapabilitiesConsumerLeadOptions : INestedOptions
    {
        /// <summary>
        /// Can create consumer issuing prepaid cards with Lead as BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prepaid_card")]
#endif
        public AccountCreateConfigurationCardCreatorCapabilitiesConsumerLeadPrepaidCardOptions PrepaidCard { get; set; }
    }
}
