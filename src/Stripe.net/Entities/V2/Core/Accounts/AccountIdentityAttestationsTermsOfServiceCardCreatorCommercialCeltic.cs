// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCeltic : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCeltic>
    {
        /// <summary>
        /// Terms of service acceptances for commercial issuing Apple Pay cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticApplePay ApplePay { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing charge cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("charge_card")]
        [STJS.JsonPropertyName("charge_card")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticChargeCard ChargeCard { get; set; }

        /// <summary>
        /// Terms of service acceptances for commercial issuing spend cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("spend_card")]
        [STJS.JsonPropertyName("spend_card")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticSpendCard SpendCard { get; set; }
    }
}
