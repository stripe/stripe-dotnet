// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeUpdateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// Evidence to upload, to respond to a dispute. Updating any field in the hash will submit
        /// all fields in the hash for review. The combined character count of all fields is limited
        /// to 150,000.
        /// </summary>
        [JsonProperty("evidence")]
        [STJS.JsonPropertyName("evidence")]
        public DisputeEvidenceOptions Evidence { get; set; }

        /// <summary>
        /// Intended submission method for the dispute.
        /// One of: <c>manual</c>, <c>prefer_manual</c>, <c>prefer_smart_disputes</c>, or
        /// <c>smart_disputes</c>.
        /// </summary>
        [JsonProperty("intended_submission_method")]
        [STJS.JsonPropertyName("intended_submission_method")]
        public string IntendedSubmissionMethod { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Whether to immediately submit evidence to the bank. If <c>false</c>, evidence is staged
        /// on the dispute. Staged evidence is visible in the API and Dashboard, and can be
        /// submitted to the bank by making another request with this attribute set to <c>true</c>
        /// (the default).
        /// </summary>
        [JsonProperty("submit")]
        [STJS.JsonPropertyName("submit")]
        public bool? Submit { get; set; }
    }
}
