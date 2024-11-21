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

    public class PromotionCodeCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the promotion code is currently active.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif

        public bool? Active { get; set; }

        /// <summary>
        /// The customer-facing code. Regardless of case, this code must be unique across all active
        /// promotion codes for a specific customer. Valid characters are lower case letters (a-z),
        /// upper case letters (A-Z), and digits (0-9).
        ///
        /// If left blank, we will generate one automatically.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif

        public string Code { get; set; }

        /// <summary>
        /// The coupon for this promotion code.
        /// </summary>
        [JsonProperty("coupon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
#endif

        public string Coupon { get; set; }

        /// <summary>
        /// The customer that this promotion code can be used by. If not set, the promotion code can
        /// be used by all customers.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif

        public string Customer { get; set; }

        /// <summary>
        /// The timestamp at which this promotion code will expire. If the coupon has specified a
        /// <c>redeems_by</c>, then this value cannot be after the coupon's <c>redeems_by</c>.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// A positive integer specifying the number of times the promotion code can be redeemed. If
        /// the coupon has specified a <c>max_redemptions</c>, then this value cannot be greater
        /// than the coupon's <c>max_redemptions</c>.
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
        /// Settings that restrict the redemption of the promotion code.
        /// </summary>
        [JsonProperty("restrictions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("restrictions")]
#endif

        public PromotionCodeRestrictionsOptions Restrictions { get; set; }
    }
}
