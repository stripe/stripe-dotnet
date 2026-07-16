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
        /// Determines whether to collect metered usage accrued up to the pause date.
        /// One of: <c>none</c>, or <c>pause_at</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
