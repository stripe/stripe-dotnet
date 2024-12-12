// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteSubscriptionSchedule : StripeEntity<QuoteSubscriptionSchedule>
    {
        [JsonProperty("applies_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applies_to")]
#endif
        public QuoteSubscriptionScheduleAppliesTo AppliesTo { get; set; }

        /// <summary>
        /// The subscription schedule that was created or updated from this quote.
        /// </summary>
        [JsonProperty("subscription_schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_schedule")]
#endif
        public string SubscriptionSchedule { get; set; }
    }
}
