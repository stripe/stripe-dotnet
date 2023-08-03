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
        /// The user supplied mark stale reason.
        /// </summary>
        [JsonProperty("marked_stale")]
        public string MarkedStale { get; set; }

        /// <summary>
        /// The ID of the subscription that was canceled.
        /// </summary>
        [JsonProperty("subscription_canceled")]
        public string SubscriptionCanceled { get; set; }

        [JsonProperty("subscription_changed")]
        public QuoteStatusDetailsStaleLastReasonSubscriptionChanged SubscriptionChanged { get; set; }

        /// <summary>
        /// The ID of the subscription that was expired.
        /// </summary>
        [JsonProperty("subscription_expired")]
        public string SubscriptionExpired { get; set; }

        /// <summary>
        /// The ID of the subscription schedule that was canceled.
        /// </summary>
        [JsonProperty("subscription_schedule_canceled")]
        public string SubscriptionScheduleCanceled { get; set; }

        [JsonProperty("subscription_schedule_changed")]
        public QuoteStatusDetailsStaleLastReasonSubscriptionScheduleChanged SubscriptionScheduleChanged { get; set; }

        /// <summary>
        /// The ID of the subscription schedule that was released.
        /// </summary>
        [JsonProperty("subscription_schedule_released")]
        public string SubscriptionScheduleReleased { get; set; }

        /// <summary>
        /// The reason the quote was marked as stale.
        /// One of: <c>bill_on_acceptance_invalid</c>, <c>line_invalid</c>, <c>marked_stale</c>,
        /// <c>subscription_canceled</c>, <c>subscription_changed</c>, <c>subscription_expired</c>,
        /// <c>subscription_schedule_canceled</c>, <c>subscription_schedule_changed</c>, or
        /// <c>subscription_schedule_released</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
