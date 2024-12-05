// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionSubscriptionDataTrialSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Defines how the subscription should behave when the user's free trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
        public SessionSubscriptionDataTrialSettingsEndBehaviorOptions EndBehavior { get; set; }
    }
}
