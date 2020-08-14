namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TaxRateCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Flag determining whether the tax rate is active or inactive (archived). Inactive tax
        /// rates cannot be used with new applications or Checkout Sessions, but will still work for
        /// subscriptions and invoices that already have it set.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

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
        /// This specifies if the tax rate is inclusive or exclusive.
        /// </summary>
        [JsonProperty("inclusive")]
        public bool? Inclusive { get; set; }

        /// <summary>
        /// The jurisdiction for the tax rate.
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
        /// This represents the tax rate percent out of 100.
        /// </summary>
        [JsonProperty("percentage")]
        public decimal? Percentage { get; set; }
    }
}
