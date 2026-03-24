// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThirdOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for commercial issuing Apple Pay cards with Fifth Third as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThirdApplePayOptions ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing charge cards with Fifth Third as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
        [STJS.JsonPropertyName("charge_card")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThirdChargeCardOptions ChargeCard { get; set; }
    }
}
