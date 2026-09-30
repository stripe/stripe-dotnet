// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionSchedulePauseSchedulePauseSettingsBillForOutstandingUsageThroughOptions : INestedOptions
    {
        /// <summary>
        /// Determines whether to collect metered usage accrued up to the pause date. When adding a
        /// pause schedule, defaults to <c>pause_at</c>. On updates, the existing value is preserved
        /// if not provided.
        /// One of: <c>none</c>, or <c>pause_at</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
