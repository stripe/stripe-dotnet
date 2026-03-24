// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticChargeCard : StripeEntity<AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticChargeCard>
    {
        /// <summary>
        /// Bank terms of service acceptance for commercial issuing charge cards with Celtic as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("bank_terms")]
        [STJS.JsonPropertyName("bank_terms")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticChargeCardBankTerms BankTerms { get; set; }

        /// <summary>
        /// Platform terms of service acceptance for commercial issuing charge cards with Celtic as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("platform")]
        [STJS.JsonPropertyName("platform")]
        public AccountIdentityAttestationsTermsOfServiceCardCreatorCommercialCelticChargeCardPlatform Platform { get; set; }
    }
}
