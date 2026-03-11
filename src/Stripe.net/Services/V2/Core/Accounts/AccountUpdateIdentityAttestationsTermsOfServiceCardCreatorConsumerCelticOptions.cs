// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for consumer issuing Apple Pay cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apple_pay")]
#endif
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticApplePayOptions ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for consumer issuing revolving credit cards with Celtic as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("revolving_credit_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolving_credit_card")]
#endif
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticRevolvingCreditCardOptions RevolvingCreditCard { get; set; }
    }
}
