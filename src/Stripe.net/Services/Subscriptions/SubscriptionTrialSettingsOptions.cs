// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionTrialSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Defines how the subscription should behave when the user's free trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
        public SubscriptionTrialSettingsEndBehaviorOptions EndBehavior { get; set; }
    }
}
