// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationCardCreatorCapabilitiesCommercialLeadOptions : INestedOptions
    {
        /// <summary>
        /// Can create commercial issuing prepaid cards with Lead as BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prepaid_card")]
#endif
        public AccountUpdateConfigurationCardCreatorCapabilitiesCommercialLeadPrepaidCardOptions PrepaidCard { get; set; }
    }
}
