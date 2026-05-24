// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionStatusDetails : StripeEntity<SubscriptionStatusDetails>
    {
        /// <summary>
        /// Indicates when and why the subscription transitioned to the paused status.
        /// </summary>
        [JsonProperty("paused")]
        [STJS.JsonPropertyName("paused")]
        public SubscriptionStatusDetailsPaused Paused { get; set; }
    }
}
