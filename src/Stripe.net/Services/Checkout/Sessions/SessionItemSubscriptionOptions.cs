// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionItemSubscriptionOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// Configures when the subscription schedule's billing cycle anchors to a specific day of
        /// the week or month.
        /// </summary>
        [JsonProperty("billing_cycle_anchor_config")]
        [STJS.JsonPropertyName("billing_cycle_anchor_config")]
        public SessionItemSubscriptionBillingCycleAnchorConfigOptions BillingCycleAnchorConfig { get; set; }

        /// <summary>
        /// Controls how prorations and invoices for subscriptions are calculated and orchestrated.
        /// </summary>
        [JsonProperty("billing_mode")]
        [STJS.JsonPropertyName("billing_mode")]
        public SessionItemSubscriptionBillingModeOptions BillingMode { get; set; }

        /// <summary>
        /// The subscription's description, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The list of items for the subscription.
        /// </summary>
        [JsonProperty("items")]
        [STJS.JsonPropertyName("items")]
        public List<SessionItemSubscriptionItemOptions> Items { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Specifies an interval for how often to bill for any pending invoice items.
        /// </summary>
        [JsonProperty("pending_invoice_item_interval")]
        [STJS.JsonPropertyName("pending_invoice_item_interval")]
        public SessionItemSubscriptionPendingInvoiceItemIntervalOptions PendingInvoiceItemInterval { get; set; }

        /// <summary>
        /// Determines how to handle prorations resulting from the <c>billing_cycle_anchor</c>. If
        /// no value is passed, the default is <c>create_prorations</c>.
        /// One of: <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        [STJS.JsonPropertyName("proration_behavior")]
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// Unix timestamp representing the end of the trial period the customer will get before
        /// being charged for the first time. Has to be at least 48 hours in the future.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("trial_end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time. Has to be at least 1.
        /// </summary>
        [JsonProperty("trial_period_days")]
        [STJS.JsonPropertyName("trial_period_days")]
        public long? TrialPeriodDays { get; set; }

        /// <summary>
        /// Settings related to subscription trials.
        /// </summary>
        [JsonProperty("trial_settings")]
        [STJS.JsonPropertyName("trial_settings")]
        public SessionItemSubscriptionTrialSettingsOptions TrialSettings { get; set; }
    }
}
