// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for consumer issuing Apple Pay cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticApplePayOptions ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for consumer issuing charge cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("revolving_credit_card")]
        [STJS.JsonPropertyName("revolving_credit_card")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticRevolvingCreditCardOptions RevolvingCreditCard { get; set; }
    }
}
