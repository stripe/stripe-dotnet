// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditUnderwritingRecordReportDecisionOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Date when a decision was made.
        /// </summary>
        [JsonProperty("decided_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("decided_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? DecidedAt { get; set; }

        /// <summary>
        /// Details about the decision.
        /// </summary>
        [JsonProperty("decision")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("decision")]
#endif
        public CreditUnderwritingRecordDecisionOptions Decision { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
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
        /// File containing regulatory reporting data for the decision. Required if you are subject
        /// to this <a
        /// href="https://stripe.com/docs/issuing/credit/report-required-regulatory-data-for-credit-decisions">reporting
        /// requirement</a>.
        /// </summary>
        [JsonProperty("regulatory_reporting_file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("regulatory_reporting_file")]
#endif
        public string RegulatoryReportingFile { get; set; }

        /// <summary>
        /// If an exception to the usual underwriting criteria was made for this decision, details
        /// about the exception must be provided. Exceptions should only be granted in rare
        /// circumstances, in consultation with Stripe Compliance.
        /// </summary>
        [JsonProperty("underwriting_exception")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("underwriting_exception")]
#endif
        public CreditUnderwritingRecordUnderwritingExceptionOptions UnderwritingException { get; set; }
    }
}
