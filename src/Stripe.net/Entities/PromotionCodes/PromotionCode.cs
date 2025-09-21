// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A Promotion Code represents a customer-redeemable code for an underlying promotion. You
    /// can create multiple codes for a single promotion.
    ///
    /// If you enable promotion codes in your <a
    /// href="https://stripe.com/docs/customer-management/configure-portal">customer portal
    /// configuration</a>, then customers can redeem a code themselves when updating a
    /// subscription in the portal. Customers can also view the currently active promotion codes
    /// and coupons on each of their subscriptions in the portal.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class PromotionCode : StripeEntity<PromotionCode>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
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
        /// Whether the promotion code is currently active. A promotion code is only active if the
        /// coupon is also valid.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool Active { get; set; }

        /// <summary>
        /// The customer-facing code. Regardless of case, this code must be unique across all active
        /// promotion codes for each customer. Valid characters are lower case letters (a-z), upper
        /// case letters (A-Z), and digits (0-9).
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The customer that this promotion code can be used by.
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
        /// The customer that this promotion code can be used by.
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
        /// The account that this promotion code can be used by.
        /// </summary>
        [JsonProperty("customer_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_account")]
#endif
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Date at which the promotion code can no longer be redeemed.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Maximum number of times this promotion code can be redeemed.
        /// </summary>
        [JsonProperty("max_redemptions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("max_redemptions")]
#endif
        public long? MaxRedemptions { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("promotion")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promotion")]
#endif
        public PromotionCodePromotion Promotion { get; set; }

        [JsonProperty("restrictions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("restrictions")]
#endif
        public PromotionCodeRestrictions Restrictions { get; set; }

        /// <summary>
        /// Number of times this promotion code has been used.
        /// </summary>
        [JsonProperty("times_redeemed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("times_redeemed")]
#endif
        public long TimesRedeemed { get; set; }
    }
}
