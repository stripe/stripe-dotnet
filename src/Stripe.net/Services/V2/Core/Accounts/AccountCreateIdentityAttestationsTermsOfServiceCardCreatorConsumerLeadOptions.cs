// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateIdentityAttestationsTermsOfServiceCardCreatorConsumerLeadOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for consumer issuing debit cards with Lead as BIN sponsor.
        /// </summary>
        [JsonProperty("debit_card")]
        [STJS.JsonPropertyName("debit_card")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorConsumerLeadDebitCardOptions DebitCard { get; set; }

        /// <summary>
        /// Terms of service acceptances for consumer issuing prepaid cards with Lead as BIN
        /// sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorConsumerLeadPrepaidCardOptions PrepaidCard { get; set; }
    }
}
