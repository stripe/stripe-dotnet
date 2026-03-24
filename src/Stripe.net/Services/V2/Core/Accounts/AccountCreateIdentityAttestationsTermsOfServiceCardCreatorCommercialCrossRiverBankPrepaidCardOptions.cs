// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankPrepaidCardOptions : INestedOptions
    {
        /// <summary>
        /// Bank terms of service acceptance for commercial issuing prepaid cards with Cross River
        /// Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
        [STJS.JsonPropertyName("bank_terms")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankPrepaidCardBankTermsOptions BankTerms { get; set; }

        /// <summary>
        /// Platform terms of service acceptance for commercial issuing prepaid cards with Cross
        /// River Bank as BIN sponsor.
        /// </summary>
        [JsonProperty("platform")]
        [STJS.JsonPropertyName("platform")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorCommercialCrossRiverBankPrepaidCardPlatformOptions Platform { get; set; }
    }
}
