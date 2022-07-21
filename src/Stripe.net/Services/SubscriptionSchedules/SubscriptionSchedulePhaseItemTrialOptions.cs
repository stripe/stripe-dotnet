// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseItemTrialOptions : INestedOptions
    {
        [JsonProperty("free")]
        public SubscriptionSchedulePhaseItemTrialFreeOptions Free { get; set; }

        [JsonProperty("none")]
        public SubscriptionSchedulePhaseItemTrialNoneOptions None { get; set; }

        /// <summary>
        /// Details of a different price, quantity, or both, to bill your customer for during a paid
        /// trial.
        /// </summary>
        [JsonProperty("paid")]
        public SubscriptionSchedulePhaseItemTrialPaidOptions Paid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
