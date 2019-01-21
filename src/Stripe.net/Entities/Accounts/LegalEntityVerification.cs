namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class LegalEntityVerification : StripeEntity<LegalEntityVerification>
    {
        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("details_code")]
        public string DetailsCode { get; set; }

        #region Expandable Document

        /// <summary>
        /// (ID of a <see cref="File"/>) A photo (jpg or png) of the front of an identifying
        /// document, either a passport or local ID card.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string DocumentId => this.InternalDocument.Id;

        /// <summary>
        /// (Expanded) A photo (jpg or png) of the front of an identifying document, either a
        /// passport or local ID card.
        /// </summary>
        [JsonIgnore]
        public File Document => this.InternalDocument.ExpandedObject;

        [JsonProperty("document")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalDocument { get; set; }
        #endregion

        #region Expandable Document Back

        /// <summary>
        /// (ID of a <see cref="File"/>) A photo (jpg or png) of the back of an identifying
        /// document, either a passport or local ID card.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string DocumentBackId => this.InternalDocumentBack.Id;

        /// <summary>
        /// (Expanded) A photo (jpg or png) of the back of an identifying document, either a
        /// passport or local ID card.
        /// </summary>
        [JsonIgnore]
        public File DocumentBack => this.InternalDocumentBack.ExpandedObject;

        [JsonProperty("document_back")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalDocumentBack { get; set; }
        #endregion

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
