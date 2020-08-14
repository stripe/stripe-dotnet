namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ValueListUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The name of the value list for use in rules.
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The human-readable name of the value list.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
