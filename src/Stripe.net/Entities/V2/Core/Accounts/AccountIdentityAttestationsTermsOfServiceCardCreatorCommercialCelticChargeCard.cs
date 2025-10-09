// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticChargeCard : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticChargeCard>
    {
        /// <summary>
        /// Bank terms of service acceptance for commercial issuing charge cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_terms")]
#endif
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticChargeCardBankTerms BankTerms { get; set; }

        /// <summary>
        /// Platform terms of service acceptance for commercial issuing charge cards with Celtic as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("platform")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("platform")]
#endif
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticChargeCardPlatform Platform { get; set; }
    }
}
