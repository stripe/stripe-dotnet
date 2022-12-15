// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteStatusDetailsStaleLastReasonSubscriptionScheduleChanged : StripeEntity<QuoteStatusDetailsStaleLastReasonSubscriptionScheduleChanged>
    {
        /// <summary>
        /// The subscription schedule's state before the quote was marked as stale.
        /// </summary>
        [JsonProperty("previous_subscription_schedule")]
        public SubscriptionSchedule PreviousSubscriptionSchedule { get; set; }
    }
}
