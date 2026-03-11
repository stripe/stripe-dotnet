// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankPrepaidCard : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankPrepaidCard>
    {
        /// <summary>
        /// Bank terms of service acceptance for commercial Global issuing prepaid cards with Cross
        /// River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_terms")]
#endif
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankPrepaidCardBankTerms BankTerms { get; set; }

        /// <summary>
        /// Platform terms of service acceptance for commercial Global issuing prepaid cards with
        /// Cross River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("platform")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("platform")]
#endif
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankPrepaidCardPlatform Platform { get; set; }
    }
}
