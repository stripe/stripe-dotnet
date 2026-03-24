// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A discount represents the actual application of a <a
    /// href="https://api.stripe.com#coupons">coupon</a> or <a
    /// href="https://api.stripe.com#promotion_codes">promotion code</a>. It contains
    /// information about when the discount began, when it will end, and what it is applied to.
    ///
    /// Related guide: <a
    /// href="https://docs.stripe.com/billing/subscriptions/discounts">Applying discounts to
    /// subscriptions</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Discount : StripeEntity<Discount>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the discount object. Discounts cannot be fetched by ID. Use
        /// <c>expand[]=discounts</c> in API calls to expand discount IDs in an array.
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
        /// The Checkout session that this coupon is applied to, if it is applied to a particular
        /// session in payment mode. Will not be present for subscription mode.
        /// </summary>
        [JsonProperty("checkout_session")]
        [STJS.JsonPropertyName("checkout_session")]
        public string CheckoutSession { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the customer associated with this discount.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// The ID of the account representing the customer associated with this discount.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// If the coupon has a duration of <c>repeating</c>, the date that this discount will end.
        /// If the coupon has a duration of <c>once</c> or <c>forever</c>, this attribute will be
        /// null.
        /// </summary>
        [JsonProperty("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? End { get; set; }

        /// <summary>
        /// The invoice that the discount's coupon was applied to, if it was applied directly to a
        /// particular invoice.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public string Invoice { get; set; }

        /// <summary>
        /// The invoice item <c>id</c> (or invoice line item <c>id</c> for invoice line items of
        /// type='subscription') that the discount's coupon was applied to, if it was applied
        /// directly to a particular invoice item or invoice line item.
        /// </summary>
        [JsonProperty("invoice_item")]
        [STJS.JsonPropertyName("invoice_item")]
        public string InvoiceItem { get; set; }

        #region Expandable PromotionCode

        /// <summary>
        /// (ID of the PromotionCode)
        /// The promotion code applied to create this discount.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public PromotionCode PromotionCode
        {
            get => this.InternalPromotionCode?.ExpandedObject;
            set => this.InternalPromotionCode = SetExpandableFieldObject(value, this.InternalPromotionCode);
        }

        [JsonProperty("promotion_code")]
        [JsonConverter(typeof(ExpandableFieldConverter<PromotionCode>))]
        [STJS.JsonPropertyName("promotion_code")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PromotionCode>))]
        internal ExpandableField<PromotionCode> InternalPromotionCode { get; set; }
        #endregion

        /// <summary>
        /// The subscription schedule that this coupon is applied to, if it is applied to a
        /// particular subscription schedule.
        /// </summary>
        [JsonProperty("schedule")]
        [STJS.JsonPropertyName("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("service_period_details")]
        [STJS.JsonPropertyName("service_period_details")]
        public DiscountServicePeriodDetails ServicePeriodDetails { get; set; }

        [JsonProperty("source")]
        [STJS.JsonPropertyName("source")]
        public DiscountSource Source { get; set; }

        /// <summary>
        /// Date that the coupon was applied.
        /// </summary>
        [JsonProperty("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("start")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Start { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The subscription that this coupon is applied to, if it is applied to a particular
        /// subscription.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }

        /// <summary>
        /// The subscription item that this coupon is applied to, if it is applied to a particular
        /// subscription item.
        /// </summary>
        [JsonProperty("subscription_item")]
        [STJS.JsonPropertyName("subscription_item")]
        public string SubscriptionItem { get; set; }
    }
}
