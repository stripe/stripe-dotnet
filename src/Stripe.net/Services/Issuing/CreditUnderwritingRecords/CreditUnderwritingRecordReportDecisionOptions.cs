// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditUnderwritingRecordReportDecisionOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Date when a decision was made.
        /// </summary>
        [JsonProperty("decided_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DecidedAt { get; set; }

        /// <summary>
        /// Details about the decision.
        /// </summary>
        [JsonProperty("decision")]
        public CreditUnderwritingRecordDecisionOptions Decision { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
