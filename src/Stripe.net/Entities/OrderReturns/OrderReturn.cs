namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderReturn : StripeEntity<OrderReturn>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type
        /// share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// A positive integer in the smallest currency unit (that is, 100
        /// cents for $1.00, or 1 for ¥1, Japanese Yen being a 0-decimal
        /// currency) representing the total amount for the returned line item.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// 3-letter ISO code representing the currency of the return.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The items included in this order return.
        /// </summary>
        [JsonProperty("items")]
        public List<OrderItem> Items { get; set; }

        /// <summary>
        /// Has the value true if the object exists in live mode or the value
        /// false if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Order

        /// <summary>
        /// <para>The order that this return includes items from.</para>
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string OrderId
        {
            get => this.InternalOrder?.Id;
            set => this.InternalOrder = SetExpandableFieldId(value, this.InternalOrder);
        }

        [JsonIgnore]
        public Order Order
        {
            get => this.InternalOrder?.ExpandedObject;
            set => this.InternalOrder = SetExpandableFieldObject(value, this.InternalOrder);
        }

        [JsonProperty("order")]
        [JsonConverter(typeof(ExpandableFieldConverter<Order>))]
        internal ExpandableField<Order> InternalOrder { get; set; }
        #endregion

        #region Expandable Refund

        /// <summary>
        /// <para>The ID of the refund issued for this return.</para>
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string RefundId
        {
            get => this.InternalRefund?.Id;
            set => this.InternalRefund = SetExpandableFieldId(value, this.InternalRefund);
        }

        [JsonIgnore]
        public Refund Refund
        {
            get => this.InternalRefund?.ExpandedObject;
            set => this.InternalRefund = SetExpandableFieldObject(value, this.InternalRefund);
        }

        [JsonProperty("refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
        internal ExpandableField<Refund> InternalRefund { get; set; }
        #endregion
    }
}
