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
    /// A coupon contains information about a percent-off or amount-off discount you might want
    /// to apply to a customer. Coupons may be applied to <a
    /// href="https://api.stripe.com#subscriptions">subscriptions</a>, <a
    /// href="https://api.stripe.com#invoices">invoices</a>, <a
    /// href="https://docs.stripe.com/api/checkout/sessions">checkout sessions</a>, <a
    /// href="https://api.stripe.com#quotes">quotes</a>, and more. Coupons do not work with
    /// conventional one-off <a href="https://api.stripe.com#create_charge">charges</a> or <a
    /// href="https://docs.stripe.com/api/payment_intents">payment intents</a>.
    /// </summary>
    public class Coupon : StripeEntity<Coupon>, IHasId, IHasMetadata, IHasObject
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
        /// Amount (in the <c>currency</c> specified) that will be taken off the subtotal of any
        /// invoices for this customer.
        /// </summary>
        [JsonProperty("amount_off")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_off")]
#endif
        public long? AmountOff { get; set; }

        [JsonProperty("applies_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applies_to")]
#endif
        public CouponAppliesTo AppliesTo { get; set; }

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

        /// <summary>
        /// If <c>amount_off</c> has been set, the three-letter <a
        /// href="https://stripe.com/docs/currencies">ISO code for the currency</a> of the amount to
        /// take off.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Coupons defined in each available currency option. Each key must be a three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a> and a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency_options")]
#endif
        public Dictionary<string, CouponCurrencyOptions> CurrencyOptions { get; set; }

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
        /// One of <c>forever</c>, <c>once</c>, or <c>repeating</c>. Describes how long a customer
        /// who applies this coupon will get the discount.
        /// One of: <c>forever</c>, <c>once</c>, or <c>repeating</c>.
        /// </summary>
        [JsonProperty("duration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("duration")]
#endif
        public string Duration { get; set; }

        /// <summary>
        /// If <c>duration</c> is <c>repeating</c>, the number of months the coupon applies. Null if
        /// coupon <c>duration</c> is <c>forever</c> or <c>once</c>.
        /// </summary>
        [JsonProperty("duration_in_months")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("duration_in_months")]
#endif
        public long? DurationInMonths { get; set; }

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
        /// Maximum number of times this coupon can be redeemed, in total, across all customers,
        /// before it is no longer valid.
        /// </summary>
        [JsonProperty("max_redemptions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("max_redemptions")]
#endif
        public long? MaxRedemptions { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Name of the coupon displayed to customers on for instance invoices or receipts.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Percent that will be taken off the subtotal of any invoices for this customer for the
        /// duration of the coupon. For example, a coupon with percent_off of 50 will make a $ (or
        /// local equivalent)100 invoice $ (or local equivalent)50 instead.
        /// </summary>
        [JsonProperty("percent_off")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percent_off")]
#endif
        public decimal? PercentOff { get; set; }

        /// <summary>
        /// Date after which the coupon can no longer be redeemed.
        /// </summary>
        [JsonProperty("redeem_by")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redeem_by")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? RedeemBy { get; set; }

        /// <summary>
        /// Number of times this coupon has been applied to a customer.
        /// </summary>
        [JsonProperty("times_redeemed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("times_redeemed")]
#endif
        public long TimesRedeemed { get; set; }

        /// <summary>
        /// Taking account of the above properties, whether this coupon can still be applied to a
        /// customer.
        /// </summary>
        [JsonProperty("valid")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("valid")]
#endif
        public bool Valid { get; set; }
    }
}
