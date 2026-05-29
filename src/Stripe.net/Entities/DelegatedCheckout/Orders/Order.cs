// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An order represents the post-checkout lifecycle of a delegated checkout purchase.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Order : StripeEntity<Order>, IHasId, IHasObject
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
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The latest order event for this order.
        /// </summary>
        [JsonProperty("latest_order_event")]
        [STJS.JsonPropertyName("latest_order_event")]
        public OrderEvent LatestOrderEvent { get; set; }

        /// <summary>
        /// The line items in this order.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public List<OrderLineItem> LineItems { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The permalink URL for this order.
        /// </summary>
        [JsonProperty("permalink_url")]
        [STJS.JsonPropertyName("permalink_url")]
        public string PermalinkUrl { get; set; }

        /// <summary>
        /// The requested session associated with this order.
        /// </summary>
        [JsonProperty("requested_session")]
        [STJS.JsonPropertyName("requested_session")]
        public string RequestedSession { get; set; }

        /// <summary>
        /// The seller reference for this order.
        /// </summary>
        [JsonProperty("seller_reference")]
        [STJS.JsonPropertyName("seller_reference")]
        public string SellerReference { get; set; }

        /// <summary>
        /// The totals for this order.
        /// </summary>
        [JsonProperty("totals")]
        [STJS.JsonPropertyName("totals")]
        public OrderTotals Totals { get; set; }
    }
}
