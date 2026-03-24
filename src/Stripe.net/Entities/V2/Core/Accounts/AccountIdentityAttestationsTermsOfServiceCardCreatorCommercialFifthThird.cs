// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThird : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThird>
    {
        /// <summary>
        /// Bank terms of service acceptance for commercial issuing charge cards with Fifth Third as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
        [STJS.JsonPropertyName("bank_terms")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThirdBankTerms BankTerms { get; set; }

        /// <summary>
        /// Platform terms of service acceptance for commercial issuing charge cards with Fifth
        /// Third as BIN sponsor.
        /// </summary>
        [JsonProperty("platform")]
        [STJS.JsonPropertyName("platform")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialFifthThirdPlatform Platform { get; set; }
    }
}
