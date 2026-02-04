// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PricingPlanSubscription : StripeEntity<PricingPlanSubscription>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The ID of the Billing Cadence this subscription is billed on.
        /// </summary>
        [JsonProperty("billing_cadence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cadence")]
#endif
        public string BillingCadence { get; set; }

        /// <summary>
        /// Details about why the subscription was canceled, if applicable. Includes
        /// system-generated reason.
        /// </summary>
        [JsonProperty("cancellation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancellation_details")]
#endif
        public PricingPlanSubscriptionCancellationDetails CancellationDetails { get; set; }

        /// <summary>
        /// Current collection status of this subscription.
        /// One of: <c>awaiting_customer_action</c>, <c>current</c>, <c>past_due</c>, <c>paused</c>,
        /// or <c>unpaid</c>.
        /// </summary>
        [JsonProperty("collection_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_status")]
#endif
        public string CollectionStatus { get; set; }

        /// <summary>
        /// Timestamps for collection status transitions.
        /// </summary>
        [JsonProperty("collection_status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_status_transitions")]
#endif
        public PricingPlanSubscriptionCollectionStatusTransitions CollectionStatusTransitions { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The ID of the Pricing Plan for this subscription.
        /// </summary>
        [JsonProperty("pricing_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan")]
#endif
        public string PricingPlan { get; set; }

        /// <summary>
        /// The ID of the Pricing Plan Version for this subscription.
        /// </summary>
        [JsonProperty("pricing_plan_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_version")]
#endif
        public string PricingPlanVersion { get; set; }

        /// <summary>
        /// Current servicing status of this subscription.
        /// One of: <c>active</c>, <c>canceled</c>, <c>paused</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("servicing_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("servicing_status")]
#endif
        public string ServicingStatus { get; set; }

        /// <summary>
        /// Timestamps for servicing status transitions.
        /// </summary>
        [JsonProperty("servicing_status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("servicing_status_transitions")]
#endif
        public PricingPlanSubscriptionServicingStatusTransitions ServicingStatusTransitions { get; set; }

        /// <summary>
        /// The ID of the Test Clock of the associated Billing Cadence, if any.
        /// </summary>
        [JsonProperty("test_clock")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("test_clock")]
#endif
        public string TestClock { get; set; }
    }
}
