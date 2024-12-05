// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class MarginUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the margin can be applied to invoices, invoice items, or invoice line items or
        /// not.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Name of the margin, which is displayed to customers, such as on invoices.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
