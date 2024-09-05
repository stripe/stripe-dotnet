// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Every time an applicant submits an application for a Charge Card product your platform
    /// offers, or every time your platform takes a proactive credit decision on an existing
    /// account, you must record the decision by creating a new <c>CreditUnderwritingRecord</c>
    /// object on a connected account.
    ///
    /// <a
    /// href="https://stripe.com/docs/issuing/credit/report-credit-decisions-and-manage-aans">Follow
    /// the guide</a> to learn about your requirements as a platform.
    /// </summary>
    public class CreditUnderwritingRecord : StripeEntity<CreditUnderwritingRecord>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// For decisions triggered by an application, details about the submission.
        /// </summary>
        [JsonProperty("application")]
        public CreditUnderwritingRecordApplication Application { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The event that triggered the underwriting.
        /// One of: <c>application</c>, or <c>proactive_review</c>.
        /// </summary>
        [JsonProperty("created_from")]
        public string CreatedFrom { get; set; }

        [JsonProperty("credit_user")]
        public CreditUnderwritingRecordCreditUser CreditUser { get; set; }

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
        public CreditUnderwritingRecordDecision Decision { get; set; }

        /// <summary>
        /// For underwriting initiated by an application, a decision must be taken 30 days after the
        /// submission.
        /// </summary>
        [JsonProperty("decision_deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DecisionDeadline { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
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
        /// If an exception to the usual underwriting criteria was made for this application,
        /// details about the exception must be provided. Exceptions should only be granted in rare
        /// circumstances, in consultation with Stripe Compliance.
        /// </summary>
        [JsonProperty("underwriting_exception")]
        public CreditUnderwritingRecordUnderwritingException UnderwritingException { get; set; }
    }
}
