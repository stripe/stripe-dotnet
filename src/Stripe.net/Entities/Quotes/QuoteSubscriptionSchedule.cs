// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteSubscriptionSchedule : StripeEntity<QuoteSubscriptionSchedule>
    {
        [JsonProperty("applies_to")]
        [STJS.JsonPropertyName("applies_to")]
        public QuoteSubscriptionScheduleAppliesTo AppliesTo { get; set; }

        /// <summary>
        /// The subscription schedule that was created or updated from this quote.
        /// </summary>
        [JsonProperty("subscription_schedule")]
        [STJS.JsonPropertyName("subscription_schedule")]
        public string SubscriptionSchedule { get; set; }
    }
}
