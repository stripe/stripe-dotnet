// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteStatusDetailsStaleLastReason : StripeEntity<QuoteStatusDetailsStaleLastReason>
    {
        /// <summary>
        /// The ID of the line that is invalid if the stale reason type is <c>line_invalid</c>.
        /// </summary>
        [JsonProperty("line_invalid")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_invalid")]
#endif
        public string LineInvalid { get; set; }

        /// <summary>
        /// The IDs of the lines that are invalid if the stale reason type is <c>lines_invalid</c>.
        /// </summary>
        [JsonProperty("lines_invalid")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lines_invalid")]
#endif
        public List<QuoteStatusDetailsStaleLastReasonLinesInvalid> LinesInvalid { get; set; }

        /// <summary>
        /// The user supplied mark stale reason.
        /// </summary>
        [JsonProperty("marked_stale")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("marked_stale")]
#endif
        public string MarkedStale { get; set; }

        /// <summary>
        /// The ID of the subscription that was canceled.
        /// </summary>
        [JsonProperty("subscription_canceled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_canceled")]
#endif
        public string SubscriptionCanceled { get; set; }

        [JsonProperty("subscription_changed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_changed")]
#endif
        public QuoteStatusDetailsStaleLastReasonSubscriptionChanged SubscriptionChanged { get; set; }

        /// <summary>
        /// The ID of the subscription that was expired.
        /// </summary>
        [JsonProperty("subscription_expired")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_expired")]
#endif
        public string SubscriptionExpired { get; set; }

        /// <summary>
        /// The ID of the subscription schedule that was canceled.
        /// </summary>
        [JsonProperty("subscription_schedule_canceled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_schedule_canceled")]
#endif
        public string SubscriptionScheduleCanceled { get; set; }

        [JsonProperty("subscription_schedule_changed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_schedule_changed")]
#endif
        public QuoteStatusDetailsStaleLastReasonSubscriptionScheduleChanged SubscriptionScheduleChanged { get; set; }

        /// <summary>
        /// The ID of the subscription schedule that was released.
        /// </summary>
        [JsonProperty("subscription_schedule_released")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_schedule_released")]
#endif
        public string SubscriptionScheduleReleased { get; set; }

        /// <summary>
        /// The reason the quote was marked as stale.
        /// One of: <c>accept_failed_validations</c>, <c>bill_on_acceptance_invalid</c>,
        /// <c>line_invalid</c>, <c>lines_invalid</c>, <c>marked_stale</c>,
        /// <c>subscription_canceled</c>, <c>subscription_changed</c>, <c>subscription_expired</c>,
        /// <c>subscription_schedule_canceled</c>, <c>subscription_schedule_changed</c>, or
        /// <c>subscription_schedule_released</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
