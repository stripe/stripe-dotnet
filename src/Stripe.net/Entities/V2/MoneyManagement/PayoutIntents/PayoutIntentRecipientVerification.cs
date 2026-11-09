// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentRecipientVerification : StripeEntity<PayoutIntentRecipientVerification>
    {
        /// <summary>
        /// Closed Enum. The recipient-verification provider's match result.
        /// One of: <c>close_match</c>, <c>match</c>, <c>no_match</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("match_result")]
        [STJS.JsonPropertyName("match_result")]
        public string MatchResult { get; set; }

        /// <summary>
        /// Details associated with the match result.
        /// </summary>
        [JsonProperty("match_result_details")]
        [STJS.JsonPropertyName("match_result_details")]
        public PayoutIntentRecipientVerificationMatchResultDetails MatchResultDetails { get; set; }
    }
}
