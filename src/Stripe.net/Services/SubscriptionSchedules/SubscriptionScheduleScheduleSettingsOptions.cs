// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleScheduleSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Behavior of the subscription schedule and underlying subscription when it ends.
        /// One of: <c>cancel</c>, or <c>release</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
        public string EndBehavior { get; set; }
    }
}
