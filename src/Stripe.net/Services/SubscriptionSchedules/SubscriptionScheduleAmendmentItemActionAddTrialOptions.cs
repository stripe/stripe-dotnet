// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentItemActionAddTrialOptions : INestedOptions
    {
        [JsonProperty("free")]
        public SubscriptionScheduleAmendmentItemActionAddTrialFreeOptions Free { get; set; }

        [JsonProperty("none")]
        public SubscriptionScheduleAmendmentItemActionAddTrialNoneOptions None { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
