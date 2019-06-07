namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderReturn : StripeEntity<OrderReturn>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// A positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for ¥1, Japanese Yen being a 0-decimal currency) representing the total amount for the returned line item.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
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
        public List<OrderItem> OrderItems { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Order

        /// <summary>
        /// <para>The order that this return includes items from.</para>
        /// <para>Expandable</para>
        /// </summary>
        [JsonIgnore]
        public string OrderId => this.InternalOrder.Id;

        [JsonIgnore]
        public Order Order => this.InternalOrder.ExpandedObject;

        [JsonProperty("order")]
        [JsonConverter(typeof(ExpandableFieldConverter<Order>))]
        internal ExpandableField<Order> InternalOrder { get; set; }
        #endregion

        #region Expandable Refund

        /// <summary>
        /// <para>The ID of the refund issued for this return.</para>
        /// <para>Expandable</para>
        /// </summary>
        [JsonIgnore]
        public string RefundId { get; set; }

        [JsonIgnore]
        public Refund Refund => this.InternalRefund.ExpandedObject;

        [JsonProperty("refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
        internal ExpandableField<Refund> InternalRefund { get; set; }
        #endregion
    }
}
