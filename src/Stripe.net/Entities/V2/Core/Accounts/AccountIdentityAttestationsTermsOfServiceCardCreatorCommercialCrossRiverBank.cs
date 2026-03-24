// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBank : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBank>
    {
        /// <summary>
        /// Terms of service acceptances for commercial issuing Apple Pay cards with Cross River
        /// Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankApplePay ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing charge cards with Cross River Bank
        /// as BIN sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
        [STJS.JsonPropertyName("charge_card")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankChargeCard ChargeCard { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing prepaid cards with Cross River Bank
        /// as BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankPrepaidCard PrepaidCard { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing spend cards with Cross River Bank as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("spend_card")]
        [STJS.JsonPropertyName("spend_card")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankSpendCard SpendCard { get; set; }
    }
}
