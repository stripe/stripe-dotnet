// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PriceProductDataOptions : INestedOptions, IHasId, IHasMetadata
    {
        /// <summary>
        /// Whether the product is currently available for purchase. Defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool? Active { get; set; }

        /// <summary>
        /// The identifier for the product. Must be unique. If not provided, an identifier will be
        /// randomly generated.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
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
        /// The product's name, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// An arbitrary string to be displayed on your customer's credit card or bank statement.
        /// While most banks display this information consistently, some may display it incorrectly
        /// or not at all.
        ///
        /// This may be up to 22 characters. The statement description may not include <c>&lt;</c>,
        /// <c>&gt;</c>, <c>\</c>, <c>"</c>, <c>'</c> characters, and will appear on your customer's
        /// statement in capital letters. Non-ASCII characters are automatically stripped.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonProperty("tax_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_code")]
#endif
        public string TaxCode { get; set; }

        /// <summary>
        /// A label that represents units of this product. When set, this will be included in
        /// customers' receipts, invoices, Checkout, and the customer portal.
        /// </summary>
        [JsonProperty("unit_label")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_label")]
#endif
        public string UnitLabel { get; set; }
    }
}
