// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for consumer issuing prepaid cards with Cross River Bank as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
        [STJS.JsonPropertyName("prepaid_card")]
        public AccountCreateIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankPrepaidCardOptions PrepaidCard { get; set; }
    }
}
