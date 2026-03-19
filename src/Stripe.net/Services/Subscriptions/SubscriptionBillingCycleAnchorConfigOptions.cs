// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionBillingCycleAnchorConfigOptions : INestedOptions
    {
        /// <summary>
        /// The day of the month the anchor should be. Ranges from 1 to 31.
        /// </summary>
        [JsonProperty("day_of_month")]
        [STJS.JsonPropertyName("day_of_month")]
        public long? DayOfMonth { get; set; }

        /// <summary>
        /// The hour of the day the anchor should be. Ranges from 0 to 23.
        /// </summary>
        [JsonProperty("hour")]
        [STJS.JsonPropertyName("hour")]
        public long? Hour { get; set; }

        /// <summary>
        /// The minute of the hour the anchor should be. Ranges from 0 to 59.
        /// </summary>
        [JsonProperty("minute")]
        [STJS.JsonPropertyName("minute")]
        public long? Minute { get; set; }

        /// <summary>
        /// The month to start full cycle periods. Ranges from 1 to 12.
        /// </summary>
        [JsonProperty("month")]
        [STJS.JsonPropertyName("month")]
        public long? Month { get; set; }

        /// <summary>
        /// The second of the minute the anchor should be. Ranges from 0 to 59.
        /// </summary>
        [JsonProperty("second")]
        [STJS.JsonPropertyName("second")]
        public long? Second { get; set; }
    }
}
