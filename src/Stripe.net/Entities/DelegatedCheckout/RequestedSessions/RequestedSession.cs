// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A requested session is a session that has been requested by a customer.
    /// </summary>
    public class RequestedSession : StripeEntity<RequestedSession>, IHasId, IHasMetadata, IHasObject
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
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The subtotal amount of the requested session.
        /// </summary>
        [JsonProperty("amount_subtotal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_subtotal")]
#endif
        public long? AmountSubtotal { get; set; }

        /// <summary>
        /// The total amount of the requested session.
        /// </summary>
        [JsonProperty("amount_total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_total")]
#endif
        public long? AmountTotal { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime CreatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The customer for this requested session.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Time at which the requested session expires. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The details of the fulfillment.
        /// </summary>
        [JsonProperty("fulfillment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fulfillment_details")]
#endif
        public RequestedSessionFulfillmentDetails FulfillmentDetails { get; set; }

        /// <summary>
        /// The line items to be purchased.
        /// </summary>
        [JsonProperty("line_item_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_item_details")]
#endif
        public List<RequestedSessionLineItemDetail> LineItemDetails { get; set; }

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
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The details of the order.
        /// </summary>
        [JsonProperty("order_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("order_details")]
#endif
        public RequestedSessionOrderDetails OrderDetails { get; set; }

        /// <summary>
        /// The payment method used for the requested session.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The preview of the payment method to be created when the requested session is confirmed.
        /// </summary>
        [JsonProperty("payment_method_preview")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_preview")]
#endif
        public RequestedSessionPaymentMethodPreview PaymentMethodPreview { get; set; }

        [JsonProperty("seller_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("seller_details")]
#endif
        public RequestedSessionSellerDetails SellerDetails { get; set; }

        /// <summary>
        /// Whether or not the payment method should be saved for future use.
        /// </summary>
        [JsonProperty("setup_future_usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_future_usage")]
#endif
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// The metadata shared with the seller.
        /// </summary>
        [JsonProperty("shared_metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shared_metadata")]
#endif
        public Dictionary<string, string> SharedMetadata { get; set; }

        /// <summary>
        /// The SPT used for payment.
        /// </summary>
        [JsonProperty("shared_payment_issued_token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shared_payment_issued_token")]
#endif
        public string SharedPaymentIssuedToken { get; set; }

        /// <summary>
        /// The status of the requested session.
        /// One of: <c>completed</c>, <c>expired</c>, or <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        [JsonProperty("total_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_details")]
#endif
        public RequestedSessionTotalDetails TotalDetails { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("updated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime UpdatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
