// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionTrialSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Defines how the subscription should behave when the user's free trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
        [STJS.JsonPropertyName("end_behavior")]
        public SubscriptionTrialSettingsEndBehaviorOptions EndBehavior { get; set; }
    }
}
