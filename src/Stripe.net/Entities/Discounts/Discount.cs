// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Discount : StripeEntity<Discount>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the discount object. Discounts cannot be fetched by ID. Use
        /// <c>expand[]=discounts</c> in API calls to expand discount IDs in an array.
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
        /// The Checkout session that this coupon is applied to, if it is applied to a particular
        /// session in payment mode. Will not be present for subscription mode.
        /// </summary>
        [JsonProperty("checkout_session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("checkout_session")]
#endif
        public string CheckoutSession { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the customer associated with this discount.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
#endif
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// The ID of the account associated with this discount.
        /// </summary>
        [JsonProperty("customer_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_account")]
#endif
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
#endif
        public bool? Deleted { get; set; }

        /// <summary>
        /// If the coupon has a duration of <c>repeating</c>, the date that this discount will end.
        /// If the coupon has a duration of <c>once</c> or <c>forever</c>, this attribute will be
        /// null.
        /// </summary>
        [JsonProperty("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? End { get; set; }

        /// <summary>
        /// The invoice that the discount's coupon was applied to, if it was applied directly to a
        /// particular invoice.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public string Invoice { get; set; }

        /// <summary>
        /// The invoice item <c>id</c> (or invoice line item <c>id</c> for invoice line items of
        /// type='subscription') that the discount's coupon was applied to, if it was applied
        /// directly to a particular invoice item or invoice line item.
        /// </summary>
        [JsonProperty("invoice_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_item")]
#endif
        public string InvoiceItem { get; set; }

        #region Expandable PromotionCode

        /// <summary>
        /// (ID of the PromotionCode)
        /// The promotion code applied to create this discount.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PromotionCode PromotionCode
        {
            get => this.InternalPromotionCode?.ExpandedObject;
            set => this.InternalPromotionCode = SetExpandableFieldObject(value, this.InternalPromotionCode);
        }

        [JsonProperty("promotion_code")]
        [JsonConverter(typeof(ExpandableFieldConverter<PromotionCode>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promotion_code")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PromotionCode>))]
#endif
        internal ExpandableField<PromotionCode> InternalPromotionCode { get; set; }
        #endregion

        [JsonProperty("source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
#endif
        public DiscountSource Source { get; set; }

        /// <summary>
        /// Date that the coupon was applied.
        /// </summary>
        [JsonProperty("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Start { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The subscription that this coupon is applied to, if it is applied to a particular
        /// subscription.
        /// </summary>
        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif
        public string Subscription { get; set; }

        /// <summary>
        /// The subscription item that this coupon is applied to, if it is applied to a particular
        /// subscription item.
        /// </summary>
        [JsonProperty("subscription_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_item")]
#endif
        public string SubscriptionItem { get; set; }
    }
}
