// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionSchedulePauseSchedulePauseSettingsBillForUnusedTimeFrom : StripeEntity<SubscriptionSchedulePauseSchedulePauseSettingsBillForUnusedTimeFrom>
    {
        /// <summary>
        /// The type of unused time credit behavior.
        /// One of: <c>item_current_period_start</c>, <c>none</c>, or <c>pause_at</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
