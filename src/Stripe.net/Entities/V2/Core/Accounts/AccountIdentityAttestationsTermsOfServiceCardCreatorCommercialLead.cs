// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLead : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLead>
    {
        /// <summary>
        /// Terms of service acceptances for commercial issuing Apple Pay cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLeadApplePay ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing Global prepaid cards with Lead as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLeadPrepaidCard PrepaidCard { get; set; }
    }
}
