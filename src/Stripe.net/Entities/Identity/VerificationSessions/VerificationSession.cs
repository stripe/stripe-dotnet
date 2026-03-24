// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A VerificationSession guides you through the process of collecting and verifying the
    /// identities of your users. It contains details about the type of verification, such as
    /// what <a href="https://stripe.com/docs/identity/verification-checks">verification
    /// check</a> to perform. Only create one VerificationSession for each verification in your
    /// system.
    ///
    /// A VerificationSession transitions through <a
    /// href="https://stripe.com/docs/identity/how-sessions-work">multiple statuses</a>
    /// throughout its lifetime as it progresses through the verification flow. The
    /// VerificationSession contains the user's verified data after verification checks are
    /// complete.
    ///
    /// Related guide: <a href="https://docs.stripe.com/identity/verification-sessions">The
    /// Verification Sessions API</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationSession : StripeEntity<VerificationSession>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// A string to reference this user. This can be a customer ID, a session ID, or similar,
        /// and can be used to reconcile this verification with your internal systems.
        /// </summary>
        [JsonProperty("client_reference_id")]
        [STJS.JsonPropertyName("client_reference_id")]
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// The short-lived client secret used by Stripe.js to <a
        /// href="https://docs.stripe.com/js/identity/modal">show a verification modal</a> inside
        /// your app. This client secret expires after 24 hours and can only be used once. Don’t
        /// store it, log it, embed it in a URL, or expose it to anyone other than the user. Make
        /// sure that you have TLS enabled on any page that includes the client secret. Refer to our
        /// docs on <a
        /// href="https://docs.stripe.com/identity/verification-sessions#client-secret">passing the
        /// client secret to the frontend</a> to learn more.
        /// </summary>
        [JsonProperty("client_secret")]
        [STJS.JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If present, this property tells you the last error encountered when processing the
        /// verification.
        /// </summary>
        [JsonProperty("last_error")]
        [STJS.JsonPropertyName("last_error")]
        public VerificationSessionLastError LastError { get; set; }

        #region Expandable LastVerificationReport

        /// <summary>
        /// (ID of the VerificationReport)
        /// ID of the most recent VerificationReport. <a
        /// href="https://docs.stripe.com/identity/verification-sessions#results">Learn more about
        /// accessing detailed verification results.</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string LastVerificationReportId
        {
            get => this.InternalLastVerificationReport?.Id;
            set => this.InternalLastVerificationReport = SetExpandableFieldId(value, this.InternalLastVerificationReport);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the most recent VerificationReport. <a
        /// href="https://docs.stripe.com/identity/verification-sessions#results">Learn more about
        /// accessing detailed verification results.</a>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public VerificationReport LastVerificationReport
        {
            get => this.InternalLastVerificationReport?.ExpandedObject;
            set => this.InternalLastVerificationReport = SetExpandableFieldObject(value, this.InternalLastVerificationReport);
        }

        [JsonProperty("last_verification_report")]
        [JsonConverter(typeof(ExpandableFieldConverter<VerificationReport>))]
        [STJS.JsonPropertyName("last_verification_report")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<VerificationReport>))]
        internal ExpandableField<VerificationReport> InternalLastVerificationReport { get; set; }
        #endregion

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A set of options for the session’s verification checks.
        /// </summary>
        [JsonProperty("options")]
        [STJS.JsonPropertyName("options")]
        public VerificationSessionOptions Options { get; set; }

        /// <summary>
        /// Details provided about the user being verified. These details may be shown to the user.
        /// </summary>
        [JsonProperty("provided_details")]
        [STJS.JsonPropertyName("provided_details")]
        public VerificationSessionProvidedDetails ProvidedDetails { get; set; }

        /// <summary>
        /// Redaction status of this VerificationSession. If the VerificationSession is not
        /// redacted, this field will be null.
        /// </summary>
        [JsonProperty("redaction")]
        [STJS.JsonPropertyName("redaction")]
        public VerificationSessionRedaction Redaction { get; set; }

        /// <summary>
        /// Customer ID.
        /// </summary>
        [JsonProperty("related_customer")]
        [STJS.JsonPropertyName("related_customer")]
        public string RelatedCustomer { get; set; }

        /// <summary>
        /// The ID of the Account representing a customer.
        /// </summary>
        [JsonProperty("related_customer_account")]
        [STJS.JsonPropertyName("related_customer_account")]
        public string RelatedCustomerAccount { get; set; }

        [JsonProperty("related_person")]
        [STJS.JsonPropertyName("related_person")]
        public VerificationSessionRelatedPerson RelatedPerson { get; set; }

        /// <summary>
        /// Status of this VerificationSession. <a
        /// href="https://docs.stripe.com/identity/how-sessions-work">Learn more about the lifecycle
        /// of sessions</a>.
        /// One of: <c>canceled</c>, <c>processing</c>, <c>requires_input</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of <a href="https://docs.stripe.com/identity/verification-checks">verification
        /// check</a> to be performed.
        /// One of: <c>document</c>, <c>id_number</c>, or <c>verification_flow</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The short-lived URL that you use to redirect a user to Stripe to submit their identity
        /// information. This URL expires after 48 hours and can only be used once. Don’t store it,
        /// log it, send it in emails or expose it to anyone other than the user. Refer to our docs
        /// on <a
        /// href="https://docs.stripe.com/identity/verify-identity-documents?platform=web&amp;type=redirect">verifying
        /// identity documents</a> to learn how to redirect users to Stripe.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// The configuration token of a verification flow from the dashboard.
        /// </summary>
        [JsonProperty("verification_flow")]
        [STJS.JsonPropertyName("verification_flow")]
        public string VerificationFlow { get; set; }

        /// <summary>
        /// The user’s verified data.
        /// </summary>
        [JsonProperty("verified_outputs")]
        [STJS.JsonPropertyName("verified_outputs")]
        public VerificationSessionVerifiedOutputs VerifiedOutputs { get; set; }
    }
}
