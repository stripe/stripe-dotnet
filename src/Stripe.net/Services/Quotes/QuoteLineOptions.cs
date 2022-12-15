// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class QuoteLineOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// An array of operations the quote line performs.
        /// </summary>
        [JsonProperty("actions")]
        public List<QuoteLineActionOptions> Actions { get; set; }

        /// <summary>
        /// Details to identify the subscription schedule the quote line applies to.
        /// </summary>
        [JsonProperty("applies_to")]
        public QuoteLineAppliesToOptions AppliesTo { get; set; }

        /// <summary>
        /// For a point-in-time operation, this attribute lets you set or update whether the
        /// subscription's billing cycle anchor is reset at the <c>starts_at</c> timestamp.
        /// One of: <c>automatic</c>, or <c>line_starts_at</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// Details to identify the end of the time range modified by the proposed change. If not
        /// supplied, the quote line is considered a point-in-time operation that only affects the
        /// exact timestamp at <c>starts_at</c>, and a restricted set of attributes is supported on
        /// the quote line.
        /// </summary>
        [JsonProperty("ends_at")]
        public QuoteLineEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// The ID of an existing line on the quote.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Changes to how Stripe handles prorations during the quote line's time span. Affects if
        /// and how prorations are created when a future phase starts.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// Details to identify the earliest timestamp where the proposed change should take effect.
        /// </summary>
        [JsonProperty("starts_at")]
        public QuoteLineStartsAtOptions StartsAt { get; set; }

        /// <summary>
        /// Settings related to subscription trials.
        /// </summary>
        [JsonProperty("trial_settings")]
        public QuoteLineTrialSettingsOptions TrialSettings { get; set; }
    }
}
