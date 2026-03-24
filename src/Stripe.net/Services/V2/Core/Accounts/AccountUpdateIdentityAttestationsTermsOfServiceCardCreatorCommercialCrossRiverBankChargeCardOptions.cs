// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankChargeCardOptions : INestedOptions
    {
        /// <summary>
        /// Bank terms of service acceptance for commercial issuing charge cards with Cross River
        /// Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
        [STJS.JsonPropertyName("bank_terms")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankChargeCardBankTermsOptions BankTerms { get; set; }

        /// <summary>
        /// Financial disclosures terms of service acceptance for commercial issuing charge cards
        /// with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("financing_disclosures")]
        [STJS.JsonPropertyName("financing_disclosures")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankChargeCardFinancingDisclosuresOptions FinancingDisclosures { get; set; }

        /// <summary>
        /// Platform terms of service acceptance for commercial issuing charge cards with Cross
        /// River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("platform")]
        [STJS.JsonPropertyName("platform")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankChargeCardPlatformOptions Platform { get; set; }
    }
}
