// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RateCardSubscription : StripeEntity<RateCardSubscription>, IHasId, IHasMetadata, IHasObject
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
        /// The ID of the Billing Cadence.
        /// </summary>
        [JsonProperty("billing_cadence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cadence")]
#endif
        public string BillingCadence { get; set; }

        /// <summary>
        /// The payment status of a Rate Card Subscription.
        /// One of: <c>awaiting_customer_action</c>, <c>current</c>, <c>past_due</c>, <c>paused</c>,
        /// or <c>unpaid</c>.
        /// </summary>
        [JsonProperty("collection_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_status")]
#endif
        public string CollectionStatus { get; set; }

        /// <summary>
        /// The collection status transitions of the Rate Card Subscription.
        /// </summary>
        [JsonProperty("collection_status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_status_transitions")]
#endif
        public RateCardSubscriptionCollectionStatusTransitions CollectionStatusTransitions { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
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
        /// The ID of the Rate Card.
        /// </summary>
        [JsonProperty("rate_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card")]
#endif
        public string RateCard { get; set; }

        /// <summary>
        /// The ID of the Rate Card Version.
        /// </summary>
        [JsonProperty("rate_card_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_version")]
#endif
        public string RateCardVersion { get; set; }

        /// <summary>
        /// The servicing status of a Rate Card Subscription.
        /// One of: <c>active</c>, <c>canceled</c>, <c>paused</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("servicing_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("servicing_status")]
#endif
        public string ServicingStatus { get; set; }

        /// <summary>
        /// The servicing status transitions of the Rate Card Subscription.
        /// </summary>
        [JsonProperty("servicing_status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("servicing_status_transitions")]
#endif
        public RateCardSubscriptionServicingStatusTransitions ServicingStatusTransitions { get; set; }

        /// <summary>
        /// The ID of the Test Clock, if any.
        /// </summary>
        [JsonProperty("test_clock")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("test_clock")]
#endif
        public string TestClock { get; set; }
    }
}
