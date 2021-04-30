// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TaxRateUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Flag determining whether the tax rate is active or inactive (archived). Inactive tax
        /// rates cannot be used with new applications or Checkout Sessions, but will still work for
        /// subscriptions and invoices that already have it set.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// An arbitrary string attached to the tax rate for your internal use only. It will not be
        /// visible to your customers.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The display name of the tax rate, which will be shown to users.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The jurisdiction for the tax rate. You can use this label field for tax reporting
        /// purposes. It also appears on your customer’s invoice.
        /// </summary>
        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// <a href="https://en.wikipedia.org/wiki/ISO_3166-2:US">ISO 3166-2 subdivision code</a>,
        /// without country prefix. For example, "NY" for New York, United States.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
    }
}
