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
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
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
        /// Default number of trial days when subscribing a customer to this plan using <a
        /// href="https://stripe.com/docs/api#create_subscription-trial_from_plan"><c>trial_from_plan=true</c></a>.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
