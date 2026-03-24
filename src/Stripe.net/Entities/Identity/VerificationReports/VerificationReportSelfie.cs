// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportSelfie : StripeEntity<VerificationReportSelfie>
    {
        #region Expandable BlockedByEntry

        /// <summary>
        /// (ID of the BlocklistEntry)
        /// If selfie was not verified due to being on the blocklist, this is the token of the
        /// BlocklistEntry that blocked it.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string BlockedByEntryId
        {
            get => this.InternalBlockedByEntry?.Id;
            set => this.InternalBlockedByEntry = SetExpandableFieldId(value, this.InternalBlockedByEntry);
        }

        /// <summary>
        /// (Expanded)
        /// If selfie was not verified due to being on the blocklist, this is the token of the
        /// BlocklistEntry that blocked it.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public BlocklistEntry BlockedByEntry
        {
            get => this.InternalBlockedByEntry?.ExpandedObject;
            set => this.InternalBlockedByEntry = SetExpandableFieldObject(value, this.InternalBlockedByEntry);
        }

        [JsonProperty("blocked_by_entry")]
        [JsonConverter(typeof(ExpandableFieldConverter<BlocklistEntry>))]
        [STJS.JsonPropertyName("blocked_by_entry")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<BlocklistEntry>))]
        internal ExpandableField<BlocklistEntry> InternalBlockedByEntry { get; set; }
        #endregion

        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/files">File</a> holding the image of the
        /// identity document used in this check.
        /// </summary>
        [JsonProperty("document")]
        [STJS.JsonPropertyName("document")]
        public string Document { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public VerificationReportSelfieError Error { get; set; }

        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/files">File</a> holding the image of the
        /// selfie used in this check.
        /// </summary>
        [JsonProperty("selfie")]
        [STJS.JsonPropertyName("selfie")]
        public string Selfie { get; set; }

        /// <summary>
        /// Status of this <c>selfie</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
