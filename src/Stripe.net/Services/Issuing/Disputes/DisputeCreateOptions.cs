// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DisputeCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Evidence provided for the dispute.
        /// </summary>
        [JsonProperty("evidence")]
        public DisputeEvidenceOptions Evidence { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The ID of the issuing transaction to create a dispute for.
        /// </summary>
        [JsonProperty("transaction")]
        public string Transaction { get; set; }
    }
}
