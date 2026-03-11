// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankPrepaidCardOptions : INestedOptions
    {
        /// <summary>
        /// Bank terms of service acceptance for consumer issuing prepaid cards with Cross River
        /// Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_terms")]
#endif
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankPrepaidCardBankTermsOptions BankTerms { get; set; }

        /// <summary>
        /// Financial disclosures terms of service acceptance for consumer issuing prepaid cards
        /// with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("financing_disclosures")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financing_disclosures")]
#endif
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankPrepaidCardFinancingDisclosuresOptions FinancingDisclosures { get; set; }

        /// <summary>
        /// Platform terms of service acceptance for consumer issuing prepaid cards with Cross River
        /// Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("platform")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("platform")]
#endif
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankPrepaidCardPlatformOptions Platform { get; set; }
    }
}
