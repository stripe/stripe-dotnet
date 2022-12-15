// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteStatusDetailsStaleLastReason : StripeEntity<QuoteStatusDetailsStaleLastReason>
    {
        /// <summary>
        /// The ID of the line that is invalid if the stale reason type is <c>line_invalid</c>.
        /// </summary>
        [JsonProperty("line_invalid")]
        public string LineInvalid { get; set; }

        /// <summary>
        /// The state of the subscription before the quote was marked as stale.
        /// </summary>
        [JsonProperty("subscription_changed")]
        public QuoteStatusDetailsStaleLastReasonSubscriptionChanged SubscriptionChanged { get; set; }

        /// <summary>
        /// The state of the subscription schedule before the quote was marked as stale.
        /// </summary>
        [JsonProperty("subscription_schedule_changed")]
        public QuoteStatusDetailsStaleLastReasonSubscriptionScheduleChanged SubscriptionScheduleChanged { get; set; }

        /// <summary>
        /// The reason the quote was marked as stale.
        /// One of: <c>bill_on_acceptance_invalid</c>, <c>line_invalid</c>,
        /// <c>subscription_changed</c>, or <c>subscription_schedule_changed</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
