namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PersonVerificationDocument : StripeEntity<PersonVerificationDocument>
    {
        #region Expandable Back

        /// <summary>
        /// (ID of a <see cref="File"/>) The back of an ID returned by a file upload with a
        /// <c>purpose</c> value of <c>identity_document</c>.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string BackId => this.InternalBack.Id;

        /// <summary>
        /// (Expanded) The back of an ID returned by a file upload with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        /// </summary>
        [JsonIgnore]
        public File Back => this.InternalBack.ExpandedObject;

        [JsonProperty("back")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalBack { get; set; }
        #endregion

        /// <summary>
        /// A user-displayable string describing the verification state of this document. For
        /// example, if a document is uploaded and the picture is too fuzzy, this may say “Identity
        /// document is too unclear to read”.
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; set; }

        /// <summary>
        /// A machine-readable code specifying the verification state for this document.
        /// </summary>
        [JsonProperty("details_code")]
        public string DetailsCode { get; set; }

        #region Expandable Front

        /// <summary>
        /// (ID of a <see cref="File"/>) The front of an ID returned by a file upload with a
        /// <c>purpose</c> value of <c>identity_document</c>.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string FrontId => this.InternalFront.Id;

        /// <summary>
        /// (Expanded) The front of an ID returned by a file upload with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        /// </summary>
        [JsonIgnore]
        public File Front => this.InternalFront.ExpandedObject;

        [JsonProperty("front")]
        [JsonConverter(typeof(ExpandableFieldConverter<File>))]
        internal ExpandableField<File> InternalFront { get; set; }
        #endregion
    }
}
