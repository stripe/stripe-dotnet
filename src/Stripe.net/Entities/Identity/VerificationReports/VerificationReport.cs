// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A VerificationReport is the result of an attempt to collect and verify data from a user.
    /// The collection of verification checks performed is determined from the <c>type</c> and
    /// <c>options</c> parameters used. You can find the result of each verification check
    /// performed in the appropriate sub-resource: <c>document</c>, <c>id_number</c>,
    /// <c>selfie</c>.
    ///
    /// Each VerificationReport contains a copy of any data collected by the user as well as
    /// reference IDs which can be used to access collected images through the <a
    /// href="https://stripe.com/docs/api/files">FileUpload</a> API. To configure and create
    /// VerificationReports, use the <a
    /// href="https://stripe.com/docs/api/identity/verification_sessions">VerificationSession</a>
    /// API.
    ///
    /// Related guides: <a
    /// href="https://stripe.com/docs/identity/verification-sessions#results">Accessing
    /// verification results</a>.
    /// </summary>
    public class VerificationReport : StripeEntity<VerificationReport>, IHasId, IHasObject
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
        /// A string to reference this user. This can be a customer ID, a session ID, or similar,
        /// and can be used to reconcile this verification with your internal systems.
        /// </summary>
        [JsonProperty("client_reference_id")]
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Result from a document check.
        /// </summary>
        [JsonProperty("document")]
        public VerificationReportDocument Document { get; set; }

        /// <summary>
        /// Result from an id_number check.
        /// </summary>
        [JsonProperty("id_number")]
        public VerificationReportIdNumber IdNumber { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("options")]
        public VerificationReportOptions Options { get; set; }

        /// <summary>
        /// Result from a selfie check.
        /// </summary>
        [JsonProperty("selfie")]
        public VerificationReportSelfie Selfie { get; set; }

        /// <summary>
        /// Type of report.
        /// One of: <c>document</c>, or <c>id_number</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// ID of the VerificationSession that created this report.
        /// </summary>
        [JsonProperty("verification_session")]
        public string VerificationSession { get; set; }
    }
}
