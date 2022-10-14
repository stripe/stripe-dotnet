// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleScheduleSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Configures how the subscription schedule behaves when it ends.
        /// One of: <c>cancel</c>, or <c>release</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
        public string EndBehavior { get; set; }
    }
}
