// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteSubscriptionSchedule : StripeEntity<QuoteSubscriptionSchedule>
    {
        [JsonProperty("applies_to")]
        public QuoteSubscriptionScheduleAppliesTo AppliesTo { get; set; }

        /// <summary>
        /// The subscription schedule that was created or updated from this quote.
        /// </summary>
        [JsonProperty("subscription_schedule")]
        public string SubscriptionSchedule { get; set; }
    }
}
