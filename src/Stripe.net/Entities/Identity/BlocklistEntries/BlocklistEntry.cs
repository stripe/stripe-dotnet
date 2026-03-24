// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A BlocklistEntry represents an entry in our identity verification blocklist. It helps
    /// prevent fraudulent users from repeatedly attempting verification with similar
    /// information. When you create a BlocklistEntry, we store data from a specified
    /// VerificationReport, such as document details or facial biometrics. This allows us to
    /// compare future verification attempts against these entries. If a match is found, we
    /// categorize the new verification as unverified.
    ///
    /// To learn more, see <a
    /// href="https://docs.stripe.com/identity/review-tools#block-list">Identity Verification
    /// Blocklist</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BlocklistEntry : StripeEntity<BlocklistEntry>, IHasId, IHasObject
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
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which you disabled the BlocklistEntry. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("disabled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("disabled_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? DisabledAt { get; set; }

        /// <summary>
        /// Time at which the BlocklistEntry expires. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The current status of the BlocklistEntry.
        /// One of: <c>active</c>, <c>disabled</c>, or <c>redacted</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of BlocklistEntry.
        /// One of: <c>document</c>, or <c>selfie</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        #region Expandable VerificationReport

        /// <summary>
        /// (ID of the VerificationReport)
        /// The verification report the BlocklistEntry was created from.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public VerificationReport VerificationReport
        {
            get => this.InternalVerificationReport?.ExpandedObject;
            set => this.InternalVerificationReport = SetExpandableFieldObject(value, this.InternalVerificationReport);
        }

        [JsonProperty("verification_report")]
        [JsonConverter(typeof(ExpandableFieldConverter<VerificationReport>))]
        [STJS.JsonPropertyName("verification_report")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<VerificationReport>))]
        internal ExpandableField<VerificationReport> InternalVerificationReport { get; set; }
        #endregion

        #region Expandable VerificationSession

        /// <summary>
        /// (ID of the VerificationSession)
        /// The verification session the BlocklistEntry was created from.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public VerificationSession VerificationSession
        {
            get => this.InternalVerificationSession?.ExpandedObject;
            set => this.InternalVerificationSession = SetExpandableFieldObject(value, this.InternalVerificationSession);
        }

        [JsonProperty("verification_session")]
        [JsonConverter(typeof(ExpandableFieldConverter<VerificationSession>))]
        [STJS.JsonPropertyName("verification_session")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<VerificationSession>))]
        internal ExpandableField<VerificationSession> InternalVerificationSession { get; set; }
        #endregion
    }
}
