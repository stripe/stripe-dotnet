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
        /// The short-lived client secret used by Stripe.js to <a
        /// href="https://stripe.com/docs/js/identity/modal">show a verification modal</a> inside
        /// your app. This client secret expires after 24 hours and can only be used once. Don’t
        /// store it, log it, embed it in a URL, or expose it to anyone other than the user. Make
        /// sure that you have TLS enabled on any page that includes the client secret. Refer to our
        /// docs on <a
        /// href="https://stripe.com/docs/identity/verification-sessions#client-secret">passing the
        /// client secret to the frontend</a> to learn more.
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
        /// If present, this property tells you the last error encountered when processing the
        /// verification.
        /// </summary>
        [JsonProperty("last_error")]
        public VerificationSessionLastError LastError { get; set; }

        #region Expandable LastVerificationReport

        /// <summary>
        /// (ID of the VerificationReport)
        /// ID of the most recent VerificationReport. <a
        /// href="https://stripe.com/docs/identity/verification-checks">Learn more about accessing
        /// detailed verification results.</a>.
        /// </summary>
        [JsonIgnore]
        public string LastVerificationReportId
        {
            get => this.InternalLastVerificationReport?.Id;
            set => this.InternalLastVerificationReport = SetExpandableFieldId(value, this.InternalLastVerificationReport);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the most recent VerificationReport. <a
        /// href="https://stripe.com/docs/identity/verification-checks">Learn more about accessing
        /// detailed verification results.</a>.
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
        /// Status of this VerificationSession. <a
        /// href="https://stripe.com/docs/identity/how-sessions-work">Learn more about the lifecycle
        /// of sessions</a>.
        /// One of: <c>canceled</c>, <c>processing</c>, <c>requires_input</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of <a href="https://stripe.com/docs/identity/verification-checks">verification
        /// check</a> to be performed.
        /// One of: <c>document</c>, or <c>id_number</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The short-lived URL that you use to redirect a user to Stripe to submit their identity
        /// information. This URL expires after 24 hours and can only be used once. Don’t store it,
        /// log it, send it in emails or expose it to anyone other than the user. Refer to our docs
        /// on <a
        /// href="https://stripe.com/docs/identity/verify-identity-documents?platform=web&amp;type=redirect">verifying
        /// identity documents</a> to learn how to redirect users to Stripe.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The user’s verified data.
        /// </summary>
        [JsonProperty("verified_outputs")]
        public VerificationSessionVerifiedOutputs VerifiedOutputs { get; set; }
    }
}
