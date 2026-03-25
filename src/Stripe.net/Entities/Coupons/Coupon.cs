// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A coupon contains information about a percent-off or amount-off discount you might want
    /// to apply to a customer. Coupons may be applied to <a
    /// href="https://api.stripe.com#subscriptions">subscriptions</a>, <a
    /// href="https://api.stripe.com#invoices">invoices</a>, <a
    /// href="https://docs.stripe.com/api/checkout/sessions">checkout sessions</a>, <a
    /// href="https://api.stripe.com#quotes">quotes</a>, and more. Coupons do not work with
    /// conventional one-off <a href="https://stripe.com/api/charges/create">charges</a> or <a
    /// href="https://docs.stripe.com/api/payment_intents">payment intents</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Coupon : StripeEntity<Coupon>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
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
        /// Amount (in the <c>currency</c> specified) that will be taken off the subtotal of any
        /// invoices for this customer.
        /// </summary>
        [JsonProperty("amount_off")]
        [STJS.JsonPropertyName("amount_off")]
        public long? AmountOff { get; set; }

        [JsonProperty("applies_to")]
        [STJS.JsonPropertyName("applies_to")]
        public CouponAppliesTo AppliesTo { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If <c>amount_off</c> has been set, the three-letter <a
        /// href="https://stripe.com/docs/currencies">ISO code for the currency</a> of the amount to
        /// take off.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Coupons defined in each available currency option. Each key must be a three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a> and a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency_options")]
        [STJS.JsonPropertyName("currency_options")]
        public Dictionary<string, CouponCurrencyOptions> CurrencyOptions { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// One of <c>forever</c>, <c>once</c>, or <c>repeating</c>. Describes how long a customer
        /// who applies this coupon will get the discount.
        /// One of: <c>forever</c>, <c>once</c>, <c>repeating</c>, or <c>service_period</c>.
        /// </summary>
        [JsonProperty("duration")]
        [STJS.JsonPropertyName("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// If <c>duration</c> is <c>repeating</c>, the number of months the coupon applies. Null if
        /// coupon <c>duration</c> is <c>forever</c> or <c>once</c>.
        /// </summary>
        [JsonProperty("duration_in_months")]
        [STJS.JsonPropertyName("duration_in_months")]
        public long? DurationInMonths { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Maximum number of times this coupon can be redeemed, in total, across all customers,
        /// before it is no longer valid.
        /// </summary>
        [JsonProperty("max_redemptions")]
        [STJS.JsonPropertyName("max_redemptions")]
        public long? MaxRedemptions { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Name of the coupon displayed to customers on for instance invoices or receipts.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Percent that will be taken off the subtotal of any invoices for this customer for the
        /// duration of the coupon. For example, a coupon with percent_off of 50 will make a $ (or
        /// local equivalent)100 invoice $ (or local equivalent)50 instead.
        /// </summary>
        [JsonProperty("percent_off")]
        [STJS.JsonPropertyName("percent_off")]
        public decimal? PercentOff { get; set; }

        /// <summary>
        /// Date after which the coupon can no longer be redeemed.
        /// </summary>
        [JsonProperty("redeem_by")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("redeem_by")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? RedeemBy { get; set; }

        /// <summary>
        /// Configuration of the <a
        /// href="https://docs.stripe.com/billing/subscriptions/script-coupons">script</a> used to
        /// calculate the discount.
        /// </summary>
        [JsonProperty("script")]
        [STJS.JsonPropertyName("script")]
        public CouponScript Script { get; set; }

        [JsonProperty("service_period")]
        [STJS.JsonPropertyName("service_period")]
        public CouponServicePeriod ServicePeriod { get; set; }

        /// <summary>
        /// Number of times this coupon has been applied to a customer.
        /// </summary>
        [JsonProperty("times_redeemed")]
        [STJS.JsonPropertyName("times_redeemed")]
        public long TimesRedeemed { get; set; }

        /// <summary>
        /// One of <c>amount_off</c>, <c>percent_off</c>, or <c>script</c>. Describes the type of
        /// coupon logic used to calculate the discount.
        /// One of: <c>amount_off</c>, <c>percent_off</c>, or <c>script</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Taking account of the above properties, whether this coupon can still be applied to a
        /// customer.
        /// </summary>
        [JsonProperty("valid")]
        [STJS.JsonPropertyName("valid")]
        public bool Valid { get; set; }
    }
}
