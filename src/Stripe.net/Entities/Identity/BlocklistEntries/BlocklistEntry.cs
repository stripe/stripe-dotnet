// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A BlocklistEntry represents an entry in our identity verification blocklist. It helps
    /// prevent fraudulent users from repeatedly attempting verification with similar
    /// information. When you create a BlocklistEntry, we store data from a previous
    /// verification attempt, such as document details or facial biometrics. This allows us to
    /// compare future verification attempts against these entries. If a match is found, we
    /// categorize the new verification as unverified.
    ///
    /// To learn more, see <a
    /// href="https://stripe.com/docs/identity/review-tools#block-list">Identity Verification
    /// Blocklist</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class BlocklistEntry : StripeEntity<BlocklistEntry>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which you disabled the BlocklistEntry. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("disabled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disabled_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? DisabledAt { get; set; }

        /// <summary>
        /// Time at which the BlocklistEntry expires. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Redaction status of the BlocklistEntry. If the BlocklistEntry isn't redacted, this field
        /// is null.
        /// </summary>
        [JsonProperty("redaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redaction")]
#endif
        public BlocklistEntryRedaction Redaction { get; set; }

        /// <summary>
        /// The current status of the BlocklistEntry.
        /// One of: <c>active</c>, <c>disabled</c>, or <c>redacted</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// The type of BlocklistEntry.
        /// One of: <c>document</c>, or <c>selfie</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        #region Expandable VerificationReport

        /// <summary>
        /// (ID of the VerificationReport)
        /// The verification report the BlocklistEntry was created from.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string VerificationReportId
        {
            get => this.InternalVerificationReport?.Id;
            set => this.InternalVerificationReport = SetExpandableFieldId(value, this.InternalVerificationReport);
        }

        /// <summary>
        /// (Expanded)
        /// The verification report the BlocklistEntry was created from.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public VerificationReport VerificationReport
        {
            get => this.InternalVerificationReport?.ExpandedObject;
            set => this.InternalVerificationReport = SetExpandableFieldObject(value, this.InternalVerificationReport);
        }

        [JsonProperty("verification_report")]
        [JsonConverter(typeof(ExpandableFieldConverter<VerificationReport>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification_report")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<VerificationReport>))]
#endif
        internal ExpandableField<VerificationReport> InternalVerificationReport { get; set; }
        #endregion

        #region Expandable VerificationSession

        /// <summary>
        /// (ID of the VerificationSession)
        /// The verification session the BlocklistEntry was created from.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string VerificationSessionId
        {
            get => this.InternalVerificationSession?.Id;
            set => this.InternalVerificationSession = SetExpandableFieldId(value, this.InternalVerificationSession);
        }

        /// <summary>
        /// (Expanded)
        /// The verification session the BlocklistEntry was created from.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public VerificationSession VerificationSession
        {
            get => this.InternalVerificationSession?.ExpandedObject;
            set => this.InternalVerificationSession = SetExpandableFieldObject(value, this.InternalVerificationSession);
        }

        [JsonProperty("verification_session")]
        [JsonConverter(typeof(ExpandableFieldConverter<VerificationSession>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification_session")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<VerificationSession>))]
#endif
        internal ExpandableField<VerificationSession> InternalVerificationSession { get; set; }
        #endregion
    }
}
