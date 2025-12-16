// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLead : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLead>
    {
        /// <summary>
        /// Terms of service acceptances for commercial issuing Apple Pay cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apple_pay")]
#endif
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLeadApplePay ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing Global prepaid cards with Lead as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prepaid_card")]
#endif
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLeadPrepaidCard PrepaidCard { get; set; }
    }
}
