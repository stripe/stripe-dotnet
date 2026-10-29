// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentRecipientVerificationMatchResultDetails : StripeEntity<PayoutIntentRecipientVerificationMatchResultDetails>
    {
        /// <summary>
        /// The business type returned by the recipient-verification provider.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("matched_business_type")]
        [STJS.JsonPropertyName("matched_business_type")]
        public string MatchedBusinessType { get; set; }

        /// <summary>
        /// The account name returned by the recipient-verification provider.
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
        /// The business type provided for recipient verification.
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
