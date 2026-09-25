// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionSchedulePauseSchedulePauseSettingsBillForUnusedTimeFromOptions : INestedOptions
    {
        /// <summary>
        /// Determines which point in the billing period unused time is credited from.
        /// One of: <c>item_current_period_start</c>, <c>none</c>, or <c>pause_at</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
