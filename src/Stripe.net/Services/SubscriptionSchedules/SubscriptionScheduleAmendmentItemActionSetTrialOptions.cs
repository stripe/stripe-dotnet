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

        /// <summary>
        /// Details of a different price, quantity, or both, to bill your customer for during a paid
        /// trial.
        /// </summary>
        [JsonProperty("paid")]
        public SubscriptionScheduleAmendmentItemActionSetTrialPaidOptions Paid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
