// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteStatusDetailsStaleLastReasonSubscriptionScheduleChanged : StripeEntity<QuoteStatusDetailsStaleLastReasonSubscriptionScheduleChanged>
    {
        /// <summary>
        /// The subscription schedule's state before the quote was marked as stale.
        /// </summary>
        [JsonProperty("previous_subscription_schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("previous_subscription_schedule")]
#endif
        public SubscriptionSchedule PreviousSubscriptionSchedule { get; set; }
    }
}
