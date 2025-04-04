// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionShippingCostTaxBreakdownJurisdiction : StripeEntity<TransactionShippingCostTaxBreakdownJurisdiction>
    {
        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// A human-readable name for the jurisdiction imposing the tax.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// Indicates the level of the jurisdiction imposing the tax.
        /// One of: <c>city</c>, <c>country</c>, <c>county</c>, <c>district</c>, or <c>state</c>.
        /// </summary>
        [JsonProperty("level")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("level")]
#endif
        public string Level { get; set; }

        /// <summary>
        /// <a href="https://en.wikipedia.org/wiki/ISO_3166-2">ISO 3166-2 subdivision code</a>,
        /// without country prefix. For example, "NY" for New York, United States.
        /// </summary>
        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }
    }
}
