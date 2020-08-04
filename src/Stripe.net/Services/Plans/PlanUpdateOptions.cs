namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PlanUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the plan is currently available for new subscriptions.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a subscription object.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A brief description of the plan, hidden from customers.
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// The product the plan belongs to. This cannot be changed once it has been used in a
        /// subscription or subscription schedule.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// Default number of trial days when subscribing a customer to this plan using
        /// <c>trial_from_plan=true</c>.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
