// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An order event represents a change to a delegated checkout order.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OrderEvent : StripeEntity<OrderEvent>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The adjustment details for this order event.
        /// </summary>
        [JsonProperty("adjustment")]
        [STJS.JsonPropertyName("adjustment")]
        public OrderEventAdjustment Adjustment { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The fulfillment details for this order event.
        /// </summary>
        [JsonProperty("fulfillment")]
        [STJS.JsonPropertyName("fulfillment")]
        public OrderEventFulfillment Fulfillment { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Time at which this event occurred. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("occurred_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("occurred_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime OccurredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The delegated checkout order associated with this order event.
        /// </summary>
        [JsonProperty("order")]
        [STJS.JsonPropertyName("order")]
        public string Order { get; set; }

        /// <summary>
        /// The requested session associated with this order event.
        /// </summary>
        [JsonProperty("requested_session")]
        [STJS.JsonPropertyName("requested_session")]
        public string RequestedSession { get; set; }

        /// <summary>
        /// The type of order event.
        /// One of: <c>adjustment</c>, or <c>fulfillment</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
