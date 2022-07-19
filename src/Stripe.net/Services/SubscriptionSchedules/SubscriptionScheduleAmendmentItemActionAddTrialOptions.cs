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

        /// <summary>
        /// Details of a different price, quantity, or both, to bill your customer for during a paid
        /// trial.
        /// </summary>
        [JsonProperty("paid")]
        public SubscriptionScheduleAmendmentItemActionAddTrialPaidOptions Paid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
