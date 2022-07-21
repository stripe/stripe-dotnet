// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionItemTrialOptions : INestedOptions
    {
        [JsonProperty("free")]
        public SubscriptionItemTrialFreeOptions Free { get; set; }

        [JsonProperty("none")]
        public SubscriptionItemTrialNoneOptions None { get; set; }

        /// <summary>
        /// Details of a different price, quantity, or both, to bill your customer for during a paid
        /// trial.
        /// </summary>
        [JsonProperty("paid")]
        public SubscriptionItemTrialPaidOptions Paid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
