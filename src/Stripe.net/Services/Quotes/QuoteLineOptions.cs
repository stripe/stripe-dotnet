// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteLineOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// An array of operations the quote line performs.
        /// </summary>
        [JsonProperty("actions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("actions")]
#endif
        public List<QuoteLineActionOptions> Actions { get; set; }

        /// <summary>
        /// Details to identify the subscription schedule the quote line applies to.
        /// </summary>
        [JsonProperty("applies_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applies_to")]
#endif
        public QuoteLineAppliesToOptions AppliesTo { get; set; }

        /// <summary>
        /// For point-in-time quote lines (having no <c>ends_at</c> timestamp), this attribute lets
        /// you set or remove whether the subscription's billing cycle anchor is reset at the Quote
        /// Line <c>starts_at</c> timestamp.For time-span based quote lines (having both
        /// <c>starts_at</c> and <c>ends_at</c>), the only valid value is <c>automatic</c>, which
        /// removes any previously configured billing cycle anchor resets during the window of time
        /// spanning the quote line.
        /// One of: <c>automatic</c>, or <c>line_starts_at</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cycle_anchor")]
#endif
        public string BillingCycleAnchor { get; set; }

        /// <summary>
        /// A point-in-time operation that cancels an existing subscription schedule at the line's
        /// starts_at timestamp. Currently only compatible with <c>quote_acceptance_date</c> for
        /// <c>starts_at</c>. When using cancel_subscription_schedule, the subscription schedule on
        /// the quote remains unalterable, except for modifications to the metadata,
        /// collection_method or invoice_settings.
        /// </summary>
        [JsonProperty("cancel_subscription_schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancel_subscription_schedule")]
#endif
        public QuoteLineCancelSubscriptionScheduleOptions CancelSubscriptionSchedule { get; set; }

        /// <summary>
        /// Details to identify the end of the time range modified by the proposed change. If not
        /// supplied, the quote line is considered a point-in-time operation that only affects the
        /// exact timestamp at <c>starts_at</c>, and a restricted set of attributes is supported on
        /// the quote line.
        /// </summary>
        [JsonProperty("ends_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ends_at")]
#endif
        public QuoteLineEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// The ID of an existing line on the quote.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// Changes to how Stripe handles prorations during the quote line's time span. Affects if
        /// and how prorations are created when a future phase starts.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_behavior")]
#endif
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// Defines how to pause collection for the underlying subscription throughout the duration
        /// of the amendment.
        /// </summary>
        [JsonProperty("set_pause_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("set_pause_collection")]
#endif
        public QuoteLineSetPauseCollectionOptions SetPauseCollection { get; set; }

        /// <summary>
        /// Timestamp helper to end the underlying schedule early, based on the acompanying line's
        /// start or end date.
        /// One of: <c>line_ends_at</c>, or <c>line_starts_at</c>.
        /// </summary>
        [JsonProperty("set_schedule_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("set_schedule_end")]
#endif
        public string SetScheduleEnd { get; set; }

        /// <summary>
        /// Details to identify the earliest timestamp where the proposed change should take effect.
        /// </summary>
        [JsonProperty("starts_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("starts_at")]
#endif
        public QuoteLineStartsAtOptions StartsAt { get; set; }

        /// <summary>
        /// Settings related to subscription trials.
        /// </summary>
        [JsonProperty("trial_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_settings")]
#endif
        public QuoteLineTrialSettingsOptions TrialSettings { get; set; }
    }
}
