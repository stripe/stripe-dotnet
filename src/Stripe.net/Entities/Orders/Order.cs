// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// An Order describes a purchase being made by a customer, including the products &amp;
    /// quantities being purchased, the order status, the payment information, and the
    /// billing/shipping details.
    ///
    /// Related guide: <a href="https://stripe.com/docs/orders">Orders overview</a>.
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

        [JsonProperty("amount_remaining")]
        public long AmountRemaining { get; set; }

        /// <summary>
        /// Order cost before any discounts or taxes are applied. A positive integer representing
        /// the subtotal of the order in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> (e.g.,
        /// 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency).
        /// </summary>
        [JsonProperty("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total order cost after discounts and taxes are applied. A positive integer representing
        /// the cost of the order in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> (e.g.,
        /// 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal currency). To submit an
        /// order, the total must be either 0 or at least $0.50 USD or <a
        /// href="https://stripe.com/docs/currencies#minimum-and-maximum-charge-amounts">equivalent
        /// in charge currency</a>.
        /// </summary>
        [JsonProperty("amount_total")]
        public long AmountTotal { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect application that created the Order, if any.
        /// </summary>
        [JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Connect application that created the Order, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        [JsonProperty("automatic_tax")]
        public OrderAutomaticTax AutomaticTax { get; set; }

        /// <summary>
        /// Customer billing details associated with the order.
        /// </summary>
        [JsonProperty("billing_details")]
        public OrderBillingDetails BillingDetails { get; set; }

        /// <summary>
        /// The client secret of this Order. Used for client-side retrieval using a publishable key.
        ///
        /// The client secret can be used to complete a payment for an Order from your frontend. It
        /// should not be stored, logged, embedded in URLs, or exposed to anyone other than the
        /// customer. Make sure that you have TLS enabled on any page that includes the client
        /// secret.
        ///
        /// Refer to our docs for <a
        /// href="https://stripe.com/docs/orders-beta/create-and-process">creating and processing an
        /// order</a> to learn about how client_secret should be handled.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The credits applied to the Order. At most 10 credits can be applied to an Order.
        /// </summary>
        [JsonProperty("credits")]
        public List<OrderCredit> Credits { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The customer which this orders belongs to.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The customer which this orders belongs to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Discounts

        /// <summary>
        /// (IDs of the Discounts)
        /// The discounts applied to the order. Use <c>expand[]=discounts</c> to expand each
        /// discount.
        /// </summary>
        [JsonIgnore]
        public List<string> DiscountIds
        {
            get => this.InternalDiscounts?.Select((x) => x.Id).ToList();
            set => this.InternalDiscounts = SetExpandableArrayIds<Discount>(value);
        }

        /// <summary>
        /// (Expanded)
        /// The discounts applied to the order. Use <c>expand[]=discounts</c> to expand each
        /// discount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public List<Discount> Discounts
        {
            get => this.InternalDiscounts?.Select((x) => x.ExpandedObject).ToList();
            set => this.InternalDiscounts = SetExpandableArrayObjects(value);
        }

        [JsonProperty("discounts", ItemConverterType = typeof(ExpandableFieldConverter<Discount>))]
        internal List<ExpandableField<Discount>> InternalDiscounts { get; set; }
        #endregion

        /// <summary>
        /// A recent IP address of the purchaser used for tax reporting and tax location inference.
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// A list of line items the customer is ordering. Each line item includes information about
        /// the product, the quantity, and the resulting cost. There is a maximum of 100 line items.
        /// </summary>
        [JsonProperty("line_items")]
        public StripeList<LineItem> LineItems { get; set; }

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

        [JsonProperty("payment")]
        public OrderPayment Payment { get; set; }

        /// <summary>
        /// The details of the customer cost of shipping, including the customer chosen
        /// ShippingRate.
        /// </summary>
        [JsonProperty("shipping_cost")]
        public OrderShippingCost ShippingCost { get; set; }

        /// <summary>
        /// Customer shipping information associated with the order.
        /// </summary>
        [JsonProperty("shipping_details")]
        public OrderShippingDetails ShippingDetails { get; set; }

        /// <summary>
        /// The overall status of the order.
        /// One of: <c>canceled</c>, <c>complete</c>, <c>open</c>, <c>processing</c>, or
        /// <c>submitted</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tax_details")]
        public OrderTaxDetails TaxDetails { get; set; }

        [JsonProperty("total_details")]
        public OrderTotalDetails TotalDetails { get; set; }
    }
}
