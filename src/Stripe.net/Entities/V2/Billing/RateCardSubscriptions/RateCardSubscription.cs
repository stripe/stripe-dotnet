// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A Rate Card Subscription represents a customer's subscription to a Rate Card's
    /// usage-based pricing. It tracks the servicing status (whether usage is being measured)
    /// and collection status (whether payments are current). Subscriptions bill according to
    /// the service interval defined in the Rate Card and are collected on the associated
    /// Billing Cadence.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RateCardSubscription : StripeEntity<RateCardSubscription>, IHasId, IHasMetadata, IHasObject
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
        /// The ID of the Billing Cadence.
        /// </summary>
        [JsonProperty("billing_cadence")]
        [STJS.JsonPropertyName("billing_cadence")]
        public string BillingCadence { get; set; }

        /// <summary>
        /// The payment status of a Rate Card Subscription.
        /// One of: <c>awaiting_customer_action</c>, <c>current</c>, <c>past_due</c>, <c>paused</c>,
        /// or <c>unpaid</c>.
        /// </summary>
        [JsonProperty("collection_status")]
        [STJS.JsonPropertyName("collection_status")]
        public string CollectionStatus { get; set; }

        /// <summary>
        /// The collection status transitions of the Rate Card Subscription.
        /// </summary>
        [JsonProperty("collection_status_transitions")]
        [STJS.JsonPropertyName("collection_status_transitions")]
        public RateCardSubscriptionCollectionStatusTransitions CollectionStatusTransitions { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        /// The ID of the Rate Card.
        /// </summary>
        [JsonProperty("rate_card")]
        [STJS.JsonPropertyName("rate_card")]
        public string RateCard { get; set; }

        /// <summary>
        /// The ID of the Rate Card Version.
        /// </summary>
        [JsonProperty("rate_card_version")]
        [STJS.JsonPropertyName("rate_card_version")]
        public string RateCardVersion { get; set; }

        /// <summary>
        /// The servicing status of a Rate Card Subscription.
        /// One of: <c>active</c>, <c>canceled</c>, <c>paused</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("servicing_status")]
        [STJS.JsonPropertyName("servicing_status")]
        public string ServicingStatus { get; set; }

        /// <summary>
        /// The servicing status transitions of the Rate Card Subscription.
        /// </summary>
        [JsonProperty("servicing_status_transitions")]
        [STJS.JsonPropertyName("servicing_status_transitions")]
        public RateCardSubscriptionServicingStatusTransitions ServicingStatusTransitions { get; set; }

        /// <summary>
        /// The ID of the Test Clock, if any.
        /// </summary>
        [JsonProperty("test_clock")]
        [STJS.JsonPropertyName("test_clock")]
        public string TestClock { get; set; }
    }
}
