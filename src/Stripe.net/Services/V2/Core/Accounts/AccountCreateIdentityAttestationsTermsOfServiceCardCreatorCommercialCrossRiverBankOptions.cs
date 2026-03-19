// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for commercial issuing Apple Pay cards with Cross River
        /// Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankApplePayOptions ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing charge cards with Cross River Bank
        /// as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
        [STJS.JsonPropertyName("charge_card")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankChargeCardOptions ChargeCard { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing prepaid cards with Cross River Bank
        /// as BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankPrepaidCardOptions PrepaidCard { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing spend cards with Cross River Bank as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("spend_card")]
        [STJS.JsonPropertyName("spend_card")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankSpendCardOptions SpendCard { get; set; }
    }
}
