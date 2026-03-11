// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationCardCreatorCapabilitiesConsumerCelticOptions : INestedOptions
    {
        /// <summary>
        /// Can create consumer issuing charge cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("revolving_credit_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolving_credit_card")]
#endif
        public AccountCreateConfigurationCardCreatorCapabilitiesConsumerCelticRevolvingCreditCardOptions RevolvingCreditCard { get; set; }
    }
}
