// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionScheduleCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Controls how prorations and invoices for subscriptions are calculated and orchestrated.
        /// </summary>
        [JsonProperty("billing_mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_mode")]
#endif
        public SubscriptionScheduleBillingModeOptions BillingMode { get; set; }

        /// <summary>
        /// The identifier of the customer to create the subscription schedule for.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

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
        /// Migrate an existing subscription to be managed by a subscription schedule. If this
        /// parameter is set, a subscription schedule will be created using the subscription's
        /// item(s), set to auto-renew using the subscription's interval. When using this parameter,
        /// other parameters (such as phase values) cannot be set. To create a subscription schedule
        /// with other modifications, we recommend making two separate API calls.
        /// </summary>
        [JsonProperty("from_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from_subscription")]
#endif
        public string FromSubscription { get; set; }

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
        /// </summary>
        [JsonProperty("phases")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phases")]
#endif
        public List<SubscriptionSchedulePhaseOptions> Phases { get; set; }

        /// <summary>
        /// When the subscription schedule starts. We recommend using <c>now</c> so that it starts
        /// the subscription immediately. You can also use a Unix timestamp to backdate the
        /// subscription so that it starts on a past date, or set a future date for the subscription
        /// to start on.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start_date")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, SubscriptionScheduleStartDate> StartDate { get; set; }
    }
}
