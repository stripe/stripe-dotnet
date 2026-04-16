// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PlanUpdateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// Whether the plan is currently available for new subscriptions.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A brief description of the plan, hidden from customers.
        /// </summary>
        [JsonProperty("nickname")]
        [STJS.JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// The product the plan belongs to. This cannot be changed once it has been used in a
        /// subscription or subscription schedule.
        /// </summary>
        [JsonProperty("product")]
        [STJS.JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        /// Default number of trial days when subscribing a customer to this plan using <a
        /// href="https://docs.stripe.com/api#create_subscription-trial_from_plan"><c>trial_from_plan=true</c></a>.
        /// </summary>
        [JsonProperty("trial_period_days")]
        [STJS.JsonPropertyName("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
