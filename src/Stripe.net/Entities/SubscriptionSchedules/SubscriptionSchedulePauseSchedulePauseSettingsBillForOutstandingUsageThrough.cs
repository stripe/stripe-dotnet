// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionSchedulePauseSchedulePauseSettingsBillForOutstandingUsageThrough : StripeEntity<SubscriptionSchedulePauseSchedulePauseSettingsBillForOutstandingUsageThrough>
    {
        /// <summary>
        /// The type of outstanding usage billing behavior.
        /// One of: <c>none</c>, or <c>pause_at</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
