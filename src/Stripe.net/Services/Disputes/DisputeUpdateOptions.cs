namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DisputeUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Evidence to upload, to respond to a dispute. Updating any field in the hash will submit
        /// all fields in the hash for review. The combined character count of all fields is limited
        /// to 150,000.
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
        /// Whether to immediately submit evidence to the bank. If <c>false</c>, evidence is staged
        /// on the dispute. Staged evidence is visible in the API and Dashboard, and can be
        /// submitted to the bank by making another request with this attribute set to <c>true</c>
        /// (the default).
        /// </summary>
        [JsonProperty("submit")]
        public bool? Submit { get; set; }
    }
}
