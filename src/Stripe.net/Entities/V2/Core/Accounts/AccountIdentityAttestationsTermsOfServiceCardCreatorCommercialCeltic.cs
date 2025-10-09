// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCeltic : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCeltic>
    {
        /// <summary>
        /// Terms of service acceptances for commercial issuing Apple Pay cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apple_pay")]
#endif
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticApplePay ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing charge cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge_card")]
#endif
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticChargeCard ChargeCard { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing spend cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("spend_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spend_card")]
#endif
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticSpendCard SpendCard { get; set; }
    }
}
