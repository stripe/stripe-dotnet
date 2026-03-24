// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteStatusDetailsStaleLastReasonSubscriptionScheduleChanged : StripeEntity<QuoteStatusDetailsStaleLastReasonSubscriptionScheduleChanged>
    {
        /// <summary>
        /// The subscription schedule's state before the quote was marked as stale.
        /// </summary>
        [JsonProperty("previous_subscription_schedule")]
        [STJS.JsonPropertyName("previous_subscription_schedule")]
        public SubscriptionSchedule PreviousSubscriptionSchedule { get; set; }
    }
}
