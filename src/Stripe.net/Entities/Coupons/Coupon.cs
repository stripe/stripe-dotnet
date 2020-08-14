namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Coupon : StripeEntity<Coupon>, IHasId, IHasMetadata, IHasObject
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
        /// Amount (in the <c>currency</c> specified) that will be taken off the subtotal of any
        /// invoices for this customer.
        /// </summary>
        [JsonProperty("amount_off")]
        public long? AmountOff { get; set; }

        [JsonProperty("applies_to")]
        public CouponAppliesTo AppliesTo { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If <c>amount_off</c> has been set, the three-letter <a
        /// href="https://stripe.com/docs/currencies">ISO code for the currency</a> of the amount to
        /// take off.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// One of <c>forever</c>, <c>once</c>, and <c>repeating</c>. Describes how long a customer
        /// who applies this coupon will get the discount.
        /// One of: <c>forever</c>, <c>once</c>, or <c>repeating</c>.
        /// </summary>
        [JsonProperty("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// If <c>duration</c> is <c>repeating</c>, the number of months the coupon applies. Null if
        /// coupon <c>duration</c> is <c>forever</c> or <c>once</c>.
        /// </summary>
        [JsonProperty("duration_in_months")]
        public long? DurationInMonths { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Maximum number of times this coupon can be redeemed, in total, across all customers,
        /// before it is no longer valid.
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

        /// <summary>
        /// Name of the coupon displayed to customers on for instance invoices or receipts.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Percent that will be taken off the subtotal of any invoices for this customer for the
        /// duration of the coupon. For example, a coupon with percent_off of 50 will make a %s100
        /// invoice %s50 instead.
        /// </summary>
        [JsonProperty("percent_off")]
        public decimal? PercentOff { get; set; }

        /// <summary>
        /// Date after which the coupon can no longer be redeemed.
        /// </summary>
        [JsonProperty("redeem_by")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? RedeemBy { get; set; }

        /// <summary>
        /// Number of times this coupon has been applied to a customer.
        /// </summary>
        [JsonProperty("times_redeemed")]
        public long TimesRedeemed { get; set; }

        /// <summary>
        /// Taking account of the above properties, whether this coupon can still be applied to a
        /// customer.
        /// </summary>
        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}
