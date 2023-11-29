// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

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
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Total amount of <a href="https://frontierclimate.com/">Frontier</a>'s service fees in
        /// the currency's smallest unit.
        /// </summary>
        [JsonProperty("amount_fees")]
        public long AmountFees { get; set; }

        /// <summary>
        /// Total amount of the carbon removal in the currency's smallest unit.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total amount of the order including fees in the currency's smallest unit.
        /// </summary>
        [JsonProperty("amount_total")]
        public long AmountTotal { get; set; }

        [JsonProperty("beneficiary")]
        public OrderBeneficiary Beneficiary { get; set; }

        /// <summary>
        /// Time at which the order was canceled. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Reason for the cancellation of this order.
        /// One of: <c>expired</c>, <c>product_unavailable</c>, or <c>requested</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// For delivered orders, a URL to a delivery certificate for the order.
        /// </summary>
        [JsonProperty("certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// Time at which the order was confirmed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("confirmed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ConfirmedAt { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase, representing the currency for this order.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Time at which the order's expected_delivery_year was delayed. Measured in seconds since
        /// the Unix epoch.
        /// </summary>
        [JsonProperty("delayed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DelayedAt { get; set; }

        /// <summary>
        /// Time at which the order was delivered. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("delivered_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DeliveredAt { get; set; }

        /// <summary>
        /// Details about the delivery of carbon removal for this order.
        /// </summary>
        [JsonProperty("delivery_details")]
        public List<OrderDeliveryDetail> DeliveryDetails { get; set; }

        /// <summary>
        /// The year this order is expected to be delivered.
        /// </summary>
        [JsonProperty("expected_delivery_year")]
        public long ExpectedDeliveryYear { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Quantity of carbon removal that is included in this order.
        /// </summary>
        [JsonProperty("metric_tons")]
        public decimal MetricTons { get; set; }

        #region Expandable Product

        /// <summary>
        /// (ID of the Product)
        /// Unique ID for the Climate <c>Product</c> this order is purchasing.
        /// </summary>
        [JsonIgnore]
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
        public Product Product
        {
            get => this.InternalProduct?.ExpandedObject;
            set => this.InternalProduct = SetExpandableFieldObject(value, this.InternalProduct);
        }

        [JsonProperty("product")]
        [JsonConverter(typeof(ExpandableFieldConverter<Product>))]
        internal ExpandableField<Product> InternalProduct { get; set; }
        #endregion

        /// <summary>
        /// Time at which the order's product was substituted for a different product. Measured in
        /// seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("product_substituted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ProductSubstitutedAt { get; set; }

        /// <summary>
        /// The current status of this order.
        /// One of: <c>awaiting_funds</c>, <c>canceled</c>, <c>confirmed</c>, <c>delivered</c>, or
        /// <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
