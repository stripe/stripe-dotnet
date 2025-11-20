// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankSpendCardOptions : INestedOptions
    {
        /// <summary>
        /// Bank terms of service acceptance for commercial issuing spend cards with Cross River
        /// Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_terms")]
#endif
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankSpendCardBankTermsOptions BankTerms { get; set; }

        /// <summary>
        /// Financial disclosures terms of service acceptance for commercial issuing spend cards
        /// with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("financing_disclosures")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financing_disclosures")]
#endif
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankSpendCardFinancingDisclosuresOptions FinancingDisclosures { get; set; }
    }
}
