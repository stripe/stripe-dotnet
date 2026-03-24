// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RecipientVerificationMatchResultDetails : StripeEntity<RecipientVerificationMatchResultDetails>
    {
        /// <summary>
        /// The account name associated with the bank account as provided by the VoP provider, only
        /// present if there is a match or close match.
        /// </summary>
        [JsonProperty("matched_name")]
        [STJS.JsonPropertyName("matched_name")]
        public string MatchedName { get; set; }

        /// <summary>
        /// A message describing the match result.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// The name associated with the provided recipient.
        /// </summary>
        [JsonProperty("provided_name")]
        [STJS.JsonPropertyName("provided_name")]
        public string ProvidedName { get; set; }
    }
}
