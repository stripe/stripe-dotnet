// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThirdOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for commercial issuing Apple Pay cards with Fifth Third as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apple_pay")]
#endif
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThirdApplePayOptions ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing charge cards with Fifth Third as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge_card")]
#endif
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThirdChargeCardOptions ChargeCard { get; set; }
    }
}
