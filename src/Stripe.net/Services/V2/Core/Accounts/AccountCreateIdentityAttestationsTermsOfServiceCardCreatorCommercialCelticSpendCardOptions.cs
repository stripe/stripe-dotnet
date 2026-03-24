// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticSpendCardOptions : INestedOptions
    {
        /// <summary>
        /// Bank terms of service acceptance for commercial issuing spend cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
        [STJS.JsonPropertyName("bank_terms")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticSpendCardBankTermsOptions BankTerms { get; set; }

        /// <summary>
        /// Financial disclosures terms of service acceptance for commercial issuing spend cards
        /// with Celtic as BIN sponsor.
        /// </summary>
        [JsonProperty("financing_disclosures")]
        [STJS.JsonPropertyName("financing_disclosures")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticSpendCardFinancingDisclosuresOptions FinancingDisclosures { get; set; }

        /// <summary>
        /// Platform terms of service acceptance for commercial issuing spend cards with Celtic as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("platform")]
        [STJS.JsonPropertyName("platform")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticSpendCardPlatformOptions Platform { get; set; }
    }
}
