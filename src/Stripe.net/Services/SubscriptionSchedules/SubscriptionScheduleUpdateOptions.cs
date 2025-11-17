// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionScheduleUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Configures when the subscription schedule generates prorations for phase transitions.
        /// Possible values are <c>prorate_on_next_phase</c> or <c>prorate_up_front</c> with the
        /// default being <c>prorate_on_next_phase</c>. <c>prorate_on_next_phase</c> will apply
        /// phase changes and generate prorations at transition time. <c>prorate_up_front</c> will
        /// bill for all phases within the current billing cycle up front.
        /// One of: <c>prorate_on_next_phase</c>, or <c>prorate_up_front</c>.
        /// </summary>
        [JsonProperty("billing_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_behavior")]
#endif
        public string BillingBehavior { get; set; }

        /// <summary>
        /// Sets the billing schedules for the subscription schedule.
        /// </summary>
        [JsonProperty("billing_schedules")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_schedules")]
#endif
        public List<SubscriptionScheduleBillingScheduleOptions> BillingSchedules { get; set; }

        /// <summary>
        /// Object representing the subscription schedule's default settings.
        /// </summary>
        [JsonProperty("default_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_settings")]
#endif
        public SubscriptionScheduleDefaultSettingsOptions DefaultSettings { get; set; }

        /// <summary>
        /// Behavior of the subscription schedule and underlying subscription when it ends. Possible
        /// values are <c>release</c> or <c>cancel</c> with the default being <c>release</c>.
        /// <c>release</c> will end the subscription schedule and keep the underlying subscription
        /// running. <c>cancel</c> will end the subscription schedule and cancel the underlying
        /// subscription.
        /// One of: <c>cancel</c>, <c>none</c>, <c>release</c>, or <c>renew</c>.
        /// </summary>
        [JsonProperty("end_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_behavior")]
#endif
        public string EndBehavior { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// List representing phases of the subscription schedule. Each phase can be customized to
        /// have different durations, plans, and coupons. If there are multiple phases, the
        /// <c>end_date</c> of one phase will always equal the <c>start_date</c> of the next phase.
        /// Note that past phases can be omitted.
        /// </summary>
        [JsonProperty("phases")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phases")]
#endif
        public List<SubscriptionSchedulePhaseOptions> Phases { get; set; }

        /// <summary>
        /// If specified, the invoicing for the given billing cycle iterations will be processed
        /// now.
        /// </summary>
        [JsonProperty("prebilling")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prebilling")]
#endif
        public SubscriptionSchedulePrebillingOptions Prebilling { get; set; }

        /// <summary>
        /// If the update changes the billing configuration (item price, quantity, etc.) of the
        /// current phase, indicates how prorations from this change should be handled. The default
        /// value is <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_behavior")]
#endif
        public string ProrationBehavior { get; set; }
    }
}
