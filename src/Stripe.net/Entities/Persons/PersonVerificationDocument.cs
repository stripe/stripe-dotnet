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
        public string BackId { get; set; }

        /// <summary>
        /// (Expanded) The back of an ID returned by a file upload with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        /// </summary>
        [JsonIgnore]
        public File Back { get; set; }

        [JsonProperty("back")]
        internal object InternalBack
        {
            get
            {
                return this.Back ?? (object)this.BackId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.BackId = s, o => this.Back = o);
            }
        }
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
        public string FrontId { get; set; }

        /// <summary>
        /// (Expanded) The front of an ID returned by a file upload with a <c>purpose</c>
        /// value of <c>identity_document</c>.
        /// </summary>
        [JsonIgnore]
        public File Front { get; set; }

        [JsonProperty("front")]
        internal object InternalFront
        {
            get
            {
                return this.Front ?? (object)this.FrontId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.FrontId = s, o => this.Front = o);
            }
        }
        #endregion
    }
}
