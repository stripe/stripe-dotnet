// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionDiscountCouponDataOptions : INestedOptions, IHasMetadata
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
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code for the currency</a>
        /// of the <c>amount_off</c> parameter (required if <c>amount_off</c> is passed).
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

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
    }
}
