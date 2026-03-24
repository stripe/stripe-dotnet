// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerCeltic : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerCeltic>
    {
        /// <summary>
        /// Terms of service acceptances for commercial issuing Apple Pay cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticApplePay ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing revolving credit cards with Celtic
        /// as BIN sponsor.
        /// </summary>
        [JsonProperty("revolving_credit_card")]
        [STJS.JsonPropertyName("revolving_credit_card")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerCelticRevolvingCreditCard RevolvingCreditCard { get; set; }
    }
}
