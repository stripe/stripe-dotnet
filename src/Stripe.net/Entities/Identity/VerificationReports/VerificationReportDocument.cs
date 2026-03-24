// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class VerificationReportDocument : StripeEntity<VerificationReportDocument>
    {
        /// <summary>
        /// Address as it appears in the document.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public Address Address { get; set; }

        #region Expandable BlockedByEntry

        /// <summary>
        /// (ID of the BlocklistEntry)
        /// If document was not verified due to extracted data being on the blocklist, this is the
        /// token of the BlocklistEntry that blocked it.
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
        /// If document was not verified due to extracted data being on the blocklist, this is the
        /// token of the BlocklistEntry that blocked it.
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
        /// Date of birth as it appears in the document.
        /// </summary>
        [JsonProperty("dob")]
        [STJS.JsonPropertyName("dob")]
        public VerificationReportDocumentDob Dob { get; set; }

        /// <summary>
        /// Details on the verification error. Present when status is <c>unverified</c>.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public VerificationReportDocumentError Error { get; set; }

        /// <summary>
        /// Expiration date of the document.
        /// </summary>
        [JsonProperty("expiration_date")]
        [STJS.JsonPropertyName("expiration_date")]
        public VerificationReportDocumentExpirationDate ExpirationDate { get; set; }

        /// <summary>
        /// Array of <a href="https://docs.stripe.com/api/files">File</a> ids containing images for
        /// this document.
        /// </summary>
        [JsonProperty("files")]
        [STJS.JsonPropertyName("files")]
        public List<string> Files { get; set; }

        /// <summary>
        /// First name as it appears in the document.
        /// </summary>
        [JsonProperty("first_name")]
        [STJS.JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Issued date of the document.
        /// </summary>
        [JsonProperty("issued_date")]
        [STJS.JsonPropertyName("issued_date")]
        public VerificationReportDocumentIssuedDate IssuedDate { get; set; }

        /// <summary>
        /// Issuing country of the document.
        /// </summary>
        [JsonProperty("issuing_country")]
        [STJS.JsonPropertyName("issuing_country")]
        public string IssuingCountry { get; set; }

        /// <summary>
        /// Last name as it appears in the document.
        /// </summary>
        [JsonProperty("last_name")]
        [STJS.JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Document ID number.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Sex of the person in the document.
        /// One of: <c>[redacted]</c>, <c>female</c>, <c>male</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("sex")]
        [STJS.JsonPropertyName("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// Status of this <c>document</c> check.
        /// One of: <c>unverified</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of the document.
        /// One of: <c>driving_license</c>, <c>id_card</c>, or <c>passport</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Place of birth as it appears in the document.
        /// </summary>
        [JsonProperty("unparsed_place_of_birth")]
        [STJS.JsonPropertyName("unparsed_place_of_birth")]
        public string UnparsedPlaceOfBirth { get; set; }

        /// <summary>
        /// Sex as it appears in the document.
        /// </summary>
        [JsonProperty("unparsed_sex")]
        [STJS.JsonPropertyName("unparsed_sex")]
        public string UnparsedSex { get; set; }
    }
}
