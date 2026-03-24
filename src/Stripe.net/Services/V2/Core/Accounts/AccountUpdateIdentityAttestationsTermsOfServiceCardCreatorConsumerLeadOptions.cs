// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerLeadOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for consumer issuing Apple Pay cards with Lead as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerLeadApplePayOptions ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for consumer issuing prepaid cards with Lead as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerLeadPrepaidCardOptions PrepaidCard { get; set; }
    }
}
