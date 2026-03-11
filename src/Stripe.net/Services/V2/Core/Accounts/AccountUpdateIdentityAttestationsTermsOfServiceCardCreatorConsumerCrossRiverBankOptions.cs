// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankOptions : INestedOptions
    {
        /// <summary>
        /// Terms of service acceptances for consumer issuing prepaid cards with Cross River Bank as
        /// BIN sponsor.
        /// </summary>
        [JsonProperty("prepaid_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prepaid_card")]
#endif
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorConsumerCrossRiverBankPrepaidCardOptions PrepaidCard { get; set; }
    }
}
