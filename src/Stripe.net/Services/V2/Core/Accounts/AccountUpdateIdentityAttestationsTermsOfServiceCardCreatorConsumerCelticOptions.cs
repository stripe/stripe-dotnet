// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for consumer issuing Apple Pay cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticApplePayOptions ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for consumer issuing revolving credit cards with Celtic as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("revolving_credit_card")]
        [STJS.JsonPropertyName("revolving_credit_card")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticRevolvingCreditCardOptions RevolvingCreditCard { get; set; }
    }
}
