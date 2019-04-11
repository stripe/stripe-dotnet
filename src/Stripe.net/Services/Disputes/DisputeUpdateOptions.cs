namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DisputeUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Evidence to upload, to respond to a dispute. Updating any field in the hash will submit
        /// all fields in the hash for review. The combined character count of all fields is
        /// limited to 150,000.
        /// </summary>
        [JsonProperty("evidence")]
        public DisputeEvidenceOptions Evidence { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a charge object. It can be useful for
        /// storing additional information about the customer in a structured format. It's often a
        /// good idea to store an email address in metadata for tracking later.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Whether to immediately submit evidence to the bank. If <c>false</c>, evidence is
        /// staged on the dispute. Staged evidence is visible in the API and Dashboard, and can be
        /// submitted to the bank by making another request with this attribute set to
        /// <c>true</c> (the default).
        /// </summary>
        [JsonProperty("submit")]
        public bool? Submit { get; set; }
    }
}
