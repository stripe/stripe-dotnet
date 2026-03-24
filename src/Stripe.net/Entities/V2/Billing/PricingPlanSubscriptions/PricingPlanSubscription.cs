// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Pricing Plan Subscription represents a customer's active subscription to a Pricing
    /// Plan. It tracks both the servicing status (whether the customer is receiving service)
    /// and collection status (whether payments are current). Subscriptions are created through
    /// Billing Intents and bill according to the associated Billing Cadence.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanSubscription : StripeEntity<PricingPlanSubscription>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The ID of the Billing Cadence this subscription is billed on.
        /// </summary>
        [JsonProperty("billing_cadence")]
        [STJS.JsonPropertyName("billing_cadence")]
        public string BillingCadence { get; set; }

        /// <summary>
        /// Details about why the subscription was canceled, if applicable. Includes
        /// system-generated reason.
        /// </summary>
        [JsonProperty("cancellation_details")]
        [STJS.JsonPropertyName("cancellation_details")]
        public PricingPlanSubscriptionCancellationDetails CancellationDetails { get; set; }

        /// <summary>
        /// Current collection status of this subscription.
        /// One of: <c>awaiting_customer_action</c>, <c>current</c>, <c>past_due</c>, <c>paused</c>,
        /// or <c>unpaid</c>.
        /// </summary>
        [JsonProperty("collection_status")]
        [STJS.JsonPropertyName("collection_status")]
        public string CollectionStatus { get; set; }

        /// <summary>
        /// Timestamps for collection status transitions.
        /// </summary>
        [JsonProperty("collection_status_transitions")]
        [STJS.JsonPropertyName("collection_status_transitions")]
        public PricingPlanSubscriptionCollectionStatusTransitions CollectionStatusTransitions { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Details about Discounts applied to this subscription.
        /// </summary>
        [JsonProperty("discount_details")]
        [STJS.JsonPropertyName("discount_details")]
        public List<PricingPlanSubscriptionDiscountDetail> DiscountDetails { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The ID of the Pricing Plan for this subscription.
        /// </summary>
        [JsonProperty("pricing_plan")]
        [STJS.JsonPropertyName("pricing_plan")]
        public string PricingPlan { get; set; }

        /// <summary>
        /// Pricing plan component details for the subscription, populated when
        /// pricing_plan_component_details is included.
        /// </summary>
        [JsonProperty("pricing_plan_component_details")]
        [STJS.JsonPropertyName("pricing_plan_component_details")]
        public List<PricingPlanSubscriptionPricingPlanComponentDetail> PricingPlanComponentDetails { get; set; }

        /// <summary>
        /// The ID of the Pricing Plan Version for this subscription.
        /// </summary>
        [JsonProperty("pricing_plan_version")]
        [STJS.JsonPropertyName("pricing_plan_version")]
        public string PricingPlanVersion { get; set; }

        /// <summary>
        /// Current servicing status of this subscription.
        /// One of: <c>active</c>, <c>canceled</c>, <c>paused</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("servicing_status")]
        [STJS.JsonPropertyName("servicing_status")]
        public string ServicingStatus { get; set; }

        /// <summary>
        /// Timestamps for servicing status transitions.
        /// </summary>
        [JsonProperty("servicing_status_transitions")]
        [STJS.JsonPropertyName("servicing_status_transitions")]
        public PricingPlanSubscriptionServicingStatusTransitions ServicingStatusTransitions { get; set; }

        /// <summary>
        /// The ID of the Test Clock of the associated Billing Cadence, if any.
        /// </summary>
        [JsonProperty("test_clock")]
        [STJS.JsonPropertyName("test_clock")]
        public string TestClock { get; set; }
    }
}
