// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankPrepaidCard : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankPrepaidCard>
    {
        /// <summary>
        /// Bank terms of service acceptance for consumer issuing prepaid cards with Cross River
        /// Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
        [STJS.JsonPropertyName("bank_terms")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankPrepaidCardBankTerms BankTerms { get; set; }

        /// <summary>
        /// Financial disclosures terms of service acceptance for consumer issuing prepaid cards
        /// with Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("financing_disclosures")]
        [STJS.JsonPropertyName("financing_disclosures")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankPrepaidCardFinancingDisclosures FinancingDisclosures { get; set; }

        /// <summary>
        /// Platform terms of service acceptance for consumer issuing prepaid cards with Cross River
        /// Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("platform")]
        [STJS.JsonPropertyName("platform")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankPrepaidCardPlatform Platform { get; set; }
    }
}
