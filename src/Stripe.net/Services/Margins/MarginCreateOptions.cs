// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MarginCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the margin can be applied to invoices, invoice items, or invoice line items or
        /// not. Defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool? Active { get; set; }

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
        /// Name of the margin, which is displayed to customers, such as on invoices.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Percent that will be taken off the subtotal before tax (after all other discounts and
        /// promotions) of any invoice to which the margin is applied.
        /// </summary>
        [JsonProperty("percent_off")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percent_off")]
#endif
        public decimal? PercentOff { get; set; }
    }
}
