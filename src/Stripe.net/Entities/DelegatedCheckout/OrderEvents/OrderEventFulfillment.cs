// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OrderEventFulfillment : StripeEntity<OrderEventFulfillment>
    {
        /// <summary>
        /// The carrier for the fulfillment.
        /// </summary>
        [JsonProperty("carrier")]
        [STJS.JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Time at which the fulfillment was delivered. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("delivered_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("delivered_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? DeliveredAt { get; set; }

        /// <summary>
        /// The line items associated with the fulfillment.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public List<OrderEventFulfillmentLineItem> LineItems { get; set; }

        /// <summary>
        /// Time at which the fulfillment shipped. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("shipped_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("shipped_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ShippedAt { get; set; }

        /// <summary>
        /// The status of the fulfillment.
        /// One of: <c>confirmed</c>, <c>delivered</c>, <c>fulfilled</c>, <c>pending</c>,
        /// <c>returned</c>, or <c>shipped</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The tracking number for the fulfillment.
        /// </summary>
        [JsonProperty("tracking_number")]
        [STJS.JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// The tracking URL for the fulfillment.
        /// </summary>
        [JsonProperty("tracking_url")]
        [STJS.JsonPropertyName("tracking_url")]
        public string TrackingUrl { get; set; }
    }
}
