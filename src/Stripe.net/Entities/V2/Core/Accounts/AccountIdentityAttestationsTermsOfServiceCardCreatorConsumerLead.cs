// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerLead : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerLead>
    {
        /// <summary>
        /// Terms of service acceptances for commercial issuing Apple Pay cards with Lead as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerLeadApplePay ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing revolving credit cards with Lead as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerLeadPrepaidCard PrepaidCard { get; set; }
    }
}
