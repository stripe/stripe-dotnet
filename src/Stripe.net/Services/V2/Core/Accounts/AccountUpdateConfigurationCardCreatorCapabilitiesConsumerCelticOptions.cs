// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationCardCreatorCapabilitiesConsumerCelticOptions : INestedOptions
    {
        /// <summary>
        /// Can create consumer issuing revolving credit cards with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("revolving_credit_card")]
        [STJS.JsonPropertyName("revolving_credit_card")]
        public AccountUpdateConfigurationCardCreatorCapabilitiesConsumerCelticRevolvingCreditCardOptions RevolvingCreditCard { get; set; }
    }
}
