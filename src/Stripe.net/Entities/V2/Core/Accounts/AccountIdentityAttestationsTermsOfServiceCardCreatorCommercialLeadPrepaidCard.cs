// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLeadPrepaidCard : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLeadPrepaidCard>
    {
        /// <summary>
        /// Bank terms of service acceptance for commercial Global issuing prepaid cards with Lead
        /// as BIN sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_terms")]
#endif
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLeadPrepaidCardBankTerms BankTerms { get; set; }

        /// <summary>
        /// Platform terms of service acceptance for commercial Global issuing prepaid cards with
        /// Lead as BIN sponsor.
        /// </summary>
        [JsonProperty("platform")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("platform")]
#endif
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialLeadPrepaidCardPlatform Platform { get; set; }
    }
}
