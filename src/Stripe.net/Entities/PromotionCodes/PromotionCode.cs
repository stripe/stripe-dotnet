// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PromotionCode : StripeEntity<PromotionCode>, IHasId, IHasMetadata, IHasObject
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
        /// Whether the promotion code is currently active. A promotion code is only active if the
        /// coupon is also valid.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// The customer-facing code. Regardless of case, this code must be unique across all active
        /// promotion codes for each customer.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// A coupon contains information about a percent-off or amount-off discount you might want
        /// to apply to a customer. Coupons may be applied to <a
        /// href="https://stripe.com/docs/api#invoices">invoices</a> or <a
        /// href="https://stripe.com/docs/api#create_order-coupon">orders</a>. Coupons do not work
        /// with conventional one-off <a
        /// href="https://stripe.com/docs/api#create_charge">charges</a>.
        /// </summary>
        [JsonProperty("coupon")]
        public Coupon Coupon { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The customer that this promotion code can be used by.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The customer that this promotion code can be used by.
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
        /// Date at which the promotion code can no longer be redeemed.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Maximum number of times this promotion code can be redeemed.
        /// </summary>
        [JsonProperty("max_redemptions")]
        public long? MaxRedemptions { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("restrictions")]
        public PromotionCodeRestrictions Restrictions { get; set; }

        /// <summary>
        /// Number of times this promotion code has been used.
        /// </summary>
        [JsonProperty("times_redeemed")]
        public long TimesRedeemed { get; set; }
    }
}
