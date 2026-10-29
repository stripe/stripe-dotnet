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
        /// The business type matched by the provider. Only present for Confirmation of Payee (CoP)
        /// verifications.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("matched_business_type")]
        [STJS.JsonPropertyName("matched_business_type")]
        public string MatchedBusinessType { get; set; }

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
        /// The business type provided by the user. Only present for Confirmation of Payee (CoP)
        /// verifications.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("provided_business_type")]
        [STJS.JsonPropertyName("provided_business_type")]
        public string ProvidedBusinessType { get; set; }

        /// <summary>
        /// The name associated with the provided recipient.
        /// </summary>
        [JsonProperty("provided_name")]
        [STJS.JsonPropertyName("provided_name")]
        public string ProvidedName { get; set; }
    }
}
