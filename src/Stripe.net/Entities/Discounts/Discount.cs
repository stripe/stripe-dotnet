// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A discount represents the actual application of a <a
    /// href="https://stripe.com/docs/api#coupons">coupon</a> or <a
    /// href="https://stripe.com/docs/api#promotion_codes">promotion code</a>. It contains
    /// information about when the discount began, when it will end, and what it is applied to.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/billing/subscriptions/discounts">Applying discounts to
    /// subscriptions</a>.
    /// </summary>
    public class Discount : StripeEntity<Discount>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the discount object. Discounts cannot be fetched by ID. Use
        /// <c>expand[]=discounts</c> in API calls to expand discount IDs in an array.
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
        /// A coupon contains information about a percent-off or amount-off discount you might want
        /// to apply to a customer. Coupons may be applied to <a
        /// href="https://stripe.com/docs/api#subscriptions">subscriptions</a>, <a
        /// href="https://stripe.com/docs/api#invoices">invoices</a>, <a
        /// href="https://stripe.com/docs/api/checkout/sessions">checkout sessions</a>, <a
        /// href="https://stripe.com/docs/api#quotes">quotes</a>, and more. Coupons do not work with
        /// conventional one-off <a href="https://stripe.com/docs/api#create_charge">charges</a> or
        /// <a href="https://stripe.com/docs/api/payment_intents">payment intents</a>.
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
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// If the coupon has a duration of <c>repeating</c>, the date that this discount will end.
        /// If the coupon has a duration of <c>once</c> or <c>forever</c>, this attribute will be
        /// null.
        /// </summary>
        [JsonProperty("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? End { get; set; }

        /// <summary>
        /// The invoice that the discount's coupon was applied to, if it was applied directly to a
        /// particular invoice.
        /// </summary>
        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// The invoice item <c>id</c> (or invoice line item <c>id</c> for invoice line items of
        /// type='subscription') that the discount's coupon was applied to, if it was applied
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
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
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
        public DateTime Start { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The subscription that this coupon is applied to, if it is applied to a particular
        /// subscription.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
