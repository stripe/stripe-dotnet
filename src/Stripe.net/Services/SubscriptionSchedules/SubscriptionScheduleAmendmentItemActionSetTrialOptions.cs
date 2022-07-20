// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentItemActionSetTrialOptions : INestedOptions
    {
        [JsonProperty("free")]
        public SubscriptionScheduleAmendmentItemActionSetTrialFreeOptions Free { get; set; }

        [JsonProperty("none")]
        public SubscriptionScheduleAmendmentItemActionSetTrialNoneOptions None { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
