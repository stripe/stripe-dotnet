namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Discount : StripeEntity<Discount>, IHasId, IHasObject
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
        /// The Checkout session that this coupon is applied to, if it is applied to a particular
        /// session in payment mode. Will not be present for subscription mode.
        /// </summary>
        [JsonProperty("checkout_session")]
        public string CheckoutSession { get; set; }

        /// <summary>
        /// Hash describing the coupon applied to create this discount.
        /// </summary>
        [JsonProperty("coupon")]
        public Coupon Coupon { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the customer associated with this discount.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the customer associated with this discount.
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
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// If the coupon has a <c>duration</c> of <c>repeating</c>, the date that this discount
        /// will end. If the coupon has a <c>duration</c> of <c>once</c> or forever, this attribute
        /// will be null.
        /// </summary>
        [JsonProperty("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? End { get; set; }

        /// <summary>
        /// The invoice that the discount’s coupon was applied to, if it was applied directly to a
        /// particular invoice.
        /// </summary>
        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// The invoice item id (or invoice line item id for invoice line items of
        /// type=‘subscription’) that the discount’s coupon was applied to, if it was applied
        /// directly to a particular invoice item or invoice line item.
        /// </summary>
        [JsonProperty("invoice_item")]
        public string InvoiceItem { get; set; }

        #region Expandable PromotionCode

        /// <summary>
        /// (ID of the PromotionCode)
        /// The promotion code applied to create this discount.
        /// </summary>
        [JsonIgnore]
        public string PromotionCodeId
        {
            get => this.InternalPromotionCode?.Id;
            set => this.InternalPromotionCode = SetExpandableFieldId(value, this.InternalPromotionCode);
        }

        /// <summary>
        /// (Expanded)
        /// The promotion code applied to create this discount.
        /// </summary>
        [JsonIgnore]
        public PromotionCode PromotionCode
        {
            get => this.InternalPromotionCode?.ExpandedObject;
            set => this.InternalPromotionCode = SetExpandableFieldObject(value, this.InternalPromotionCode);
        }

        [JsonProperty("promotion_code")]
        [JsonConverter(typeof(ExpandableFieldConverter<PromotionCode>))]
        internal ExpandableField<PromotionCode> InternalPromotionCode { get; set; }
        #endregion

        /// <summary>
        /// Date that the coupon was applied.
        /// </summary>
        [JsonProperty("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Start { get; set; }

        #region Expandable Subscription

        /// <summary>
        /// (ID of the Subscription)
        /// The subscription that this coupon is applied to, if it is applied to a particular
        /// subscription.
        /// </summary>
        [JsonIgnore]
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        /// <summary>
        /// (Expanded)
        /// The subscription that this coupon is applied to, if it is applied to a particular
        /// subscription.
        /// </summary>
        [JsonIgnore]
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion
    }
}
