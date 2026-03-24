// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticSpendCardOptions : INestedOptions
    {
        /// <summary>
        /// Bank terms of service acceptance for commercial issuing spend cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
        [STJS.JsonPropertyName("bank_terms")]
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticSpendCardBankTermsOptions BankTerms { get; set; }

        /// <summary>
        /// Financial disclosures terms of service acceptance for commercial issuing spend cards
        /// with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("financing_disclosures")]
        [STJS.JsonPropertyName("financing_disclosures")]
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticSpendCardFinancingDisclosuresOptions FinancingDisclosures { get; set; }

        /// <summary>
        /// Platform terms of service acceptance for commercial issuing spend cards with Celtic as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("platform")]
        [STJS.JsonPropertyName("platform")]
        public AccountTokenCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticSpendCardPlatformOptions Platform { get; set; }
    }
}
