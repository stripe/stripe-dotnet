// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class VerificationSession : StripeEntity<VerificationSession>, IHasId, IHasMetadata, IHasObject
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
        /// This string value can be passed to stripe.js to embed a verification flow directly into
        /// your app.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Hash of details on the last error encountered in the verification process.
        /// </summary>
        [JsonProperty("last_error")]
        public VerificationSessionLastError LastError { get; set; }

        #region Expandable LastVerificationReport

        /// <summary>
        /// (ID of the VerificationReport)
        /// Link to the most recent completed VerificationReport for this Session.
        /// </summary>
        [JsonIgnore]
        public string LastVerificationReportId
        {
            get => this.InternalLastVerificationReport?.Id;
            set => this.InternalLastVerificationReport = SetExpandableFieldId(value, this.InternalLastVerificationReport);
        }

        /// <summary>
        /// (Expanded)
        /// Link to the most recent completed VerificationReport for this Session.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public VerificationReport LastVerificationReport
        {
            get => this.InternalLastVerificationReport?.ExpandedObject;
            set => this.InternalLastVerificationReport = SetExpandableFieldObject(value, this.InternalLastVerificationReport);
        }

        [JsonProperty("last_verification_report")]
        [JsonConverter(typeof(ExpandableFieldConverter<VerificationReport>))]
        internal ExpandableField<VerificationReport> InternalLastVerificationReport { get; set; }
        #endregion

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

        [JsonProperty("options")]
        public VerificationSessionOptions Options { get; set; }

        /// <summary>
        /// Redaction status of this VerificationSession. If the VerificationSession is not
        /// redacted, this field will be null.
        /// </summary>
        [JsonProperty("redaction")]
        public VerificationSessionRedaction Redaction { get; set; }

        /// <summary>
        /// Status of this VerificationSession. Read more about each <a
        /// href="https://stripe.com/docs/identity/how-sessions-work">VerificationSession
        /// status</a>.
        /// One of: <c>canceled</c>, <c>processing</c>, <c>requires_input</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of report requested.
        /// One of: <c>document</c>, or <c>id_number</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Link to the Stripe-hosted identity verification portal that you can send a user to for
        /// verification.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Hash of verified data about this person that results from a successful verification
        /// report.
        /// </summary>
        [JsonProperty("verified_outputs")]
        public VerificationSessionVerifiedOutputs VerifiedOutputs { get; set; }
    }
}
