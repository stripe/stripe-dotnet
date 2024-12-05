// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionTrialSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Defines how the subscription should behave when the user's free trial ends.
        /// </summary>
        [JsonProperty("end_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_behavior")]
#endif
        public SubscriptionTrialSettingsEndBehaviorOptions EndBehavior { get; set; }
    }
}
