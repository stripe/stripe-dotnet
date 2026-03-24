// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionBillForUnusedTimeFromOptions : INestedOptions
    {
        /// <summary>
        /// When to credit for unused time.
        /// One of: <c>item_current_period_start</c>, <c>none</c>, or <c>now</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
