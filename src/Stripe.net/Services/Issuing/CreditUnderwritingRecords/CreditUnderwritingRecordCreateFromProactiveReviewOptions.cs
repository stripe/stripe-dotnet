// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditUnderwritingRecordCreateFromProactiveReviewOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Information about the company or person applying or holding the account.
        /// </summary>
        [JsonProperty("credit_user")]
        public CreditUnderwritingRecordCreditUserOptions CreditUser { get; set; }

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

        /// <summary>
        /// File containing regulatory reporting data for the decision. Required if you are subject
        /// to this <a
        /// href="https://stripe.com/docs/issuing/credit/report-required-regulatory-data-for-credit-decisions">reporting
        /// requirement</a>.
        /// </summary>
        [JsonProperty("regulatory_reporting_file")]
        public string RegulatoryReportingFile { get; set; }

        /// <summary>
        /// If an exception to the usual underwriting criteria was made for this decision, details
        /// about the exception must be provided. Exceptions should only be granted in rare
        /// circumstances, in consultation with Stripe Compliance.
        /// </summary>
        [JsonProperty("underwriting_exception")]
        public CreditUnderwritingRecordUnderwritingExceptionOptions UnderwritingException { get; set; }
    }
}
