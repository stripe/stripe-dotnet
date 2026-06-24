// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionItemOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for the subscription item.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public SessionItemSubscriptionOptions Subscription { get; set; }

        /// <summary>
        /// The type of item.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
