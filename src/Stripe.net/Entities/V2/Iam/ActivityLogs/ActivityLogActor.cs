// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogActor : StripeEntity<ActivityLogActor>
    {
        /// <summary>
        /// Set when the actor is an API key.
        /// </summary>
        [JsonProperty("api_key")]
        [STJS.JsonPropertyName("api_key")]
        public ActivityLogActorApiKey ApiKey { get; set; }

        /// <summary>
        /// Set when a display name is available for an action performed by Stripe.
        /// </summary>
        [JsonProperty("stripe_action")]
        [STJS.JsonPropertyName("stripe_action")]
        public ActivityLogActorStripeAction StripeAction { get; set; }

        /// <summary>
        /// The type of actor.
        /// One of: <c>api_key</c>, <c>stripe_action</c>, or <c>user</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Set when the actor is a user.
        /// </summary>
        [JsonProperty("user")]
        [STJS.JsonPropertyName("user")]
        public ActivityLogActorUser User { get; set; }
    }
}
