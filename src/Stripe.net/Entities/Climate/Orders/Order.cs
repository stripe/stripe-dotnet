// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Orders represent your intent to purchase a particular Climate product. When you create
    /// an order, the payment is deducted from your merchant balance.
    /// </summary>
    public class Order : StripeEntity<Order>, IHasId, IHasMetadata, IHasObject
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
        /// Total amount of <a href="https://frontierclimate.com/">Frontier</a>'s service fees in
        /// the currency's smallest unit.
        /// </summary>
        [JsonProperty("amount_fees")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_fees")]
#endif
        public long AmountFees { get; set; }

        /// <summary>
        /// Total amount of the carbon removal in the currency's smallest unit.
        /// </summary>
        [JsonProperty("amount_subtotal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_subtotal")]
#endif
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total amount of the order including fees in the currency's smallest unit.
        /// </summary>
        [JsonProperty("amount_total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_total")]
#endif
        public long AmountTotal { get; set; }

        [JsonProperty("beneficiary")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("beneficiary")]
#endif
        public OrderBeneficiary Beneficiary { get; set; }

        /// <summary>
        /// Time at which the order was canceled. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Reason for the cancellation of this order.
        /// One of: <c>expired</c>, <c>product_unavailable</c>, or <c>requested</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancellation_reason")]
#endif
        public string CancellationReason { get; set; }

        /// <summary>
        /// For delivered orders, a URL to a delivery certificate for the order.
        /// </summary>
        [JsonProperty("certificate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("certificate")]
#endif
        public string Certificate { get; set; }

        /// <summary>
        /// Time at which the order was confirmed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("confirmed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirmed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ConfirmedAt { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase, representing the currency for this order.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Time at which the order's expected_delivery_year was delayed. Measured in seconds since
        /// the Unix epoch.
        /// </summary>
        [JsonProperty("delayed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delayed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? DelayedAt { get; set; }

        /// <summary>
        /// Time at which the order was delivered. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("delivered_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivered_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? DeliveredAt { get; set; }

        /// <summary>
        /// Details about the delivery of carbon removal for this order.
        /// </summary>
        [JsonProperty("delivery_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery_details")]
#endif
        public List<OrderDeliveryDetail> DeliveryDetails { get; set; }

        /// <summary>
        /// The year this order is expected to be delivered.
        /// </summary>
        [JsonProperty("expected_delivery_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expected_delivery_year")]
#endif
        public long ExpectedDeliveryYear { get; set; }

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
        /// Quantity of carbon removal that is included in this order.
        /// </summary>
        [JsonProperty("metric_tons")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metric_tons")]
#endif
        public decimal MetricTons { get; set; }

        #region Expandable Product

        /// <summary>
        /// (ID of the Product)
        /// Unique ID for the Climate <c>Product</c> this order is purchasing.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ProductId
        {
            get => this.InternalProduct?.Id;
            set => this.InternalProduct = SetExpandableFieldId(value, this.InternalProduct);
        }

        /// <summary>
        /// (Expanded)
        /// Unique ID for the Climate <c>Product</c> this order is purchasing.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Product Product
        {
            get => this.InternalProduct?.ExpandedObject;
            set => this.InternalProduct = SetExpandableFieldObject(value, this.InternalProduct);
        }

        [JsonProperty("product")]
        [JsonConverter(typeof(ExpandableFieldConverter<Product>))]
#if NET6_0_OR_GREATER
        [STJS.JsonInclude]
        [STJS.JsonPropertyName("product")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Product>))]
#endif
        internal ExpandableField<Product> InternalProduct { get; set; }
        #endregion

        /// <summary>
        /// Time at which the order's product was substituted for a different product. Measured in
        /// seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("product_substituted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product_substituted_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ProductSubstitutedAt { get; set; }

        /// <summary>
        /// The current status of this order.
        /// One of: <c>awaiting_funds</c>, <c>canceled</c>, <c>confirmed</c>, <c>delivered</c>, or
        /// <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
