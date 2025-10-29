// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class VerificationReportDocument : StripeEntity<VerificationReportDocument>
    {
        /// <summary>
        /// Address as it appears in the document.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public Address Address { get; set; }

        #region Expandable BlockedByEntry

        /// <summary>
        /// (ID of the BlocklistEntry)
        /// If document was not verified due to extracted data being on the blocklist, this is the
        /// token of the BlocklistEntry that blocked it.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string BlockedByEntryId
        {
            get => this.InternalBlockedByEntry?.Id;
            set => this.InternalBlockedByEntry = SetExpandableFieldId(value, this.InternalBlockedByEntry);
        }

        /// <summary>
        /// (Expanded)
        /// If document was not verified due to extracted data being on the blocklist, this is the
        /// token of the BlocklistEntry that blocked it.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public BlocklistEntry BlockedByEntry
        {
            get => this.InternalBlockedByEntry?.ExpandedObject;
            set => this.InternalBlockedByEntry = SetExpandableFieldObject(value, this.InternalBlockedByEntry);
        }

        [JsonProperty("blocked_by_entry")]
        [JsonConverter(typeof(ExpandableFieldConverter<BlocklistEntry>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blocked_by_entry")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<BlocklistEntry>))]
#endif
        internal ExpandableField<BlocklistEntry> InternalBlockedByEntry { get; set; }
        #endregion

        /// <summary>
        /// Date of birth as it appears in the document.
        /// </summary>
        [JsonProperty("dob")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dob")]
#endif
        public VerificationReportDocumentDob Dob { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonProperty("error")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error")]
#endif
        public VerificationReportDocumentError Error { get; set; }

        /// <summary>
        /// Expiration date of the document.
        /// </summary>
        [JsonProperty("expiration_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expiration_date")]
#endif
        public VerificationReportDocumentExpirationDate ExpirationDate { get; set; }

        /// <summary>
        /// Array of <a href="https://stripe.com/docs/api/files">File</a> ids containing images for
        /// this document.
        /// </summary>
        [JsonProperty("files")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("files")]
#endif
        public List<string> Files { get; set; }

        /// <summary>
        /// First name as it appears in the document.
        /// </summary>
        [JsonProperty("first_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("first_name")]
#endif
        public string FirstName { get; set; }

        /// <summary>
        /// Issued date of the document.
        /// </summary>
        [JsonProperty("issued_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issued_date")]
#endif
        public VerificationReportDocumentIssuedDate IssuedDate { get; set; }

        /// <summary>
        /// Issuing country of the document.
        /// </summary>
        [JsonProperty("issuing_country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_country")]
#endif
        public string IssuingCountry { get; set; }

        /// <summary>
        /// Last name as it appears in the document.
        /// </summary>
        [JsonProperty("last_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_name")]
#endif
        public string LastName { get; set; }

        /// <summary>
        /// Document ID number.
        /// </summary>
        [JsonProperty("number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number")]
#endif
        public string Number { get; set; }

        /// <summary>
        /// Sex of the person in the document.
        /// One of: <c>[redacted]</c>, <c>female</c>, <c>male</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("sex")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sex")]
#endif
        public string Sex { get; set; }

        /// <summary>
        /// Status of this <c>document</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Type of the document.
        /// One of: <c>driving_license</c>, <c>id_card</c>, or <c>passport</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Place of birth as it appears in the document.
        /// </summary>
        [JsonProperty("unparsed_place_of_birth")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unparsed_place_of_birth")]
#endif
        public string UnparsedPlaceOfBirth { get; set; }

        /// <summary>
        /// Sex as it appears in the document.
        /// </summary>
        [JsonProperty("unparsed_sex")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unparsed_sex")]
#endif
        public string UnparsedSex { get; set; }
    }
}
