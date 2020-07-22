namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Order : StripeEntity<Order>, IHasId, IHasMetadata, IHasObject
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
        /// currency) representing the total amount for the order.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The total amount that was returned to the customer.
        /// </summary>
        [JsonProperty("amount_returned")]
        public long? AmountReturned { get; set; }

        /// <summary>
        /// ID of the Connect Application that created the order.
        /// </summary>
        [JsonProperty("application")]
        public string Application { get; set; }

        /// <summary>
        /// A fee in cents that will be applied to the order and transferred to
        /// the application owner's Stripe account.
        /// </summary>
        [JsonProperty("application_fee")]
        public long? ApplicationFee { get; set; }

        #region Expandable Charge

        /// <summary>
        /// The ID of the payment used to pay for the order. Present if the
        /// order status is paid, fulfilled, or refunded.
        /// </summary>
        [JsonIgnore]
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        [JsonIgnore]
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// 3-letter ISO code representing the currency in which the order was made.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// The customer used for the order.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// The email address of the customer placing the order.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// External coupon code to load for this order.
        /// </summary>
        [JsonProperty("external_coupon_code")]
        public string ExternalCouponCode { get; set; }

        /// <summary>
        /// List of items constituting the order.
        /// </summary>
        [JsonProperty("items")]
        public List<OrderItem> Items { get; set; }

        /// <summary>
        /// Has the value true if the object exists in live mode or the value
        /// false if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to an order object. It
        /// can be useful for storing additional information about the order in
        /// a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A list of returns that have taken place for this order.
        /// </summary>
        [JsonProperty("returns")]
        public StripeList<OrderReturn> Returns { get; set; }

        /// <summary>
        /// The shipping method that is currently selected for this order, if
        /// any. If present, it is equal to one of the ids of shipping methods
        /// in the shipping_methods array. At order creation time, if there are
        /// multiple shipping methods, Stripe will automatically selected the
        /// first method.
        /// </summary>
        [JsonProperty("selected_shipping_method")]
        public string SelectedShippingMethod { get; set; }

        /// <summary>
        /// The shipping address for the order. Present if the order is for
        /// goods to be shipped.
        /// </summary>
        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// A list of supported shipping methods for this order. The desired
        /// shipping method can be specified either by updating the order, or
        /// when paying it.
        /// </summary>
        [JsonProperty("shipping_methods")]
        public List<OrderShippingMethod> ShippingMethods { get; set; }

        /// <summary>
        /// Current order status. One of created, paid, canceled, fulfilled, or
        /// returned.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The timestamps at which the order status was updated.
        /// </summary>
        [JsonProperty("status_transitions")]
        public OrderStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Measured in seconds
        /// since the Unix epoch.
        /// </summary>
        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The merchant's order ID if it is different from the Stripe order ID.
        /// </summary>
        [JsonProperty("upstream_id")]
        public string UpstreamId { get; set; }
    }
}
