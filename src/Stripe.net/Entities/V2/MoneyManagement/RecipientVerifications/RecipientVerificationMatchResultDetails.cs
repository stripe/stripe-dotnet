// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RecipientVerificationMatchResultDetails : StripeEntity<RecipientVerificationMatchResultDetails>
    {
        /// <summary>
        /// The account name associated with the bank account as provided by the VoP provider, only
        /// present if there is a match or close match.
        /// </summary>
        [JsonProperty("matched_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("matched_name")]
#endif
        public string MatchedName { get; set; }

        /// <summary>
        /// A message describing the match result.
        /// </summary>
        [JsonProperty("message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("message")]
#endif
        public string Message { get; set; }

        /// <summary>
        /// The name associated with the provided recipient.
        /// </summary>
        [JsonProperty("provided_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("provided_name")]
#endif
        public string ProvidedName { get; set; }
    }
}
