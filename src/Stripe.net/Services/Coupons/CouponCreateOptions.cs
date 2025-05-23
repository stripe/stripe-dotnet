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

    public class CouponCreateOptions : BaseOptions, IHasId, IHasMetadata
    {
        /// <summary>
        /// A positive integer representing the amount to subtract from an invoice total (required
        /// if <c>percent_off</c> is not passed).
        /// </summary>
        [JsonProperty("amount_off")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_off")]
#endif
        public long? AmountOff { get; set; }

        /// <summary>
        /// A hash containing directions for what this Coupon will apply discounts to.
        /// </summary>
        [JsonProperty("applies_to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applies_to")]
#endif
        public CouponAppliesToOptions AppliesTo { get; set; }

        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code for the currency</a>
        /// of the <c>amount_off</c> parameter (required if <c>amount_off</c> is passed).
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Coupons defined in each available currency option (only supported if <c>amount_off</c>
        /// is passed). Each key must be a three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a> and a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency_options")]
#endif
        public Dictionary<string, CouponCurrencyOptionsOptions> CurrencyOptions { get; set; }

        /// <summary>
        /// Specifies how long the discount will be in effect if used on a subscription. Defaults to
        /// <c>once</c>.
        /// One of: <c>forever</c>, <c>once</c>, or <c>repeating</c>.
        /// </summary>
        [JsonProperty("duration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("duration")]
#endif
        public string Duration { get; set; }

        /// <summary>
        /// Required only if <c>duration</c> is <c>repeating</c>, in which case it must be a
        /// positive integer that specifies the number of months the discount will be in effect.
        /// </summary>
        [JsonProperty("duration_in_months")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("duration_in_months")]
#endif
        public long? DurationInMonths { get; set; }

        /// <summary>
        /// Unique string of your choice that will be used to identify this coupon when applying it
        /// to a customer. If you don't want to specify a particular code, you can leave the ID
        /// blank and we'll generate a random code for you.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// A positive integer specifying the number of times the coupon can be redeemed before it's
        /// no longer valid. For example, you might have a 50% off coupon that the first 20 readers
        /// of your blog can use.
        /// </summary>
        [JsonProperty("max_redemptions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("max_redemptions")]
#endif
        public long? MaxRedemptions { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Name of the coupon displayed to customers on, for instance invoices, or receipts. By
        /// default the <c>id</c> is shown if <c>name</c> is not set.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// A positive float larger than 0, and smaller or equal to 100, that represents the
        /// discount the coupon will apply (required if <c>amount_off</c> is not passed).
        /// </summary>
        [JsonProperty("percent_off")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percent_off")]
#endif
        public decimal? PercentOff { get; set; }

        /// <summary>
        /// Unix timestamp specifying the last time at which the coupon can be redeemed. After the
        /// redeem_by date, the coupon can no longer be applied to new customers.
        /// </summary>
        [JsonProperty("redeem_by")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redeem_by")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? RedeemBy { get; set; }
    }
}
