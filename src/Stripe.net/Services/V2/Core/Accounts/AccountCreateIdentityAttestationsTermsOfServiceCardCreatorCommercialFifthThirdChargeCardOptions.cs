// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThirdChargeCardOptions : INestedOptions
    {
        /// <summary>
        /// Bank terms of service acceptance for commercial issuing charge cards with Fifth Third as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_terms")]
#endif
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThirdChargeCardBankTermsOptions BankTerms { get; set; }

        /// <summary>
        /// Financial disclosures terms of service acceptance for commercial issuing charge cards
        /// with Fifth Third as BIN sponsor.
        /// </summary>
        [JsonProperty("financing_disclosures")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financing_disclosures")]
#endif
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThirdChargeCardFinancingDisclosuresOptions FinancingDisclosures { get; set; }

        /// <summary>
        /// Platform terms of service acceptance for commercial issuing charge cards with Fifth
        /// Third as BIN sponsor.
        /// </summary>
        [JsonProperty("platform")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("platform")]
#endif
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThirdChargeCardPlatformOptions Platform { get; set; }
    }
}
