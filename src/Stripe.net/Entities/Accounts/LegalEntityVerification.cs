namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class LegalEntityVerification : StripeEntity
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
        public string DocumentId { get; set; }

        /// <summary>
        /// (Expanded) A photo (jpg or png) of the front of an identifying document, either a
        /// passport or local ID card.
        /// </summary>
        [JsonIgnore]
        public File Document { get; set; }

        [JsonProperty("document")]
        internal object InternalDocument
        {
            get
            {
                return this.Document ?? (object)this.DocumentId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.DocumentId = s, o => this.Document = o);
            }
        }
        #endregion

        #region Expandable Document Back

        /// <summary>
        /// (ID of a <see cref="File"/>) A photo (jpg or png) of the back of an identifying
        /// document, either a passport or local ID card.
        /// <para>Expandable.</para>
        /// </summary>
        [JsonIgnore]
        public string DocumentBackId { get; set; }

        /// <summary>
        /// (Expanded) A photo (jpg or png) of the back of an identifying document, either a
        /// passport or local ID card.
        /// </summary>
        [JsonIgnore]
        public File DocumentBack { get; set; }

        [JsonProperty("document_back")]
        internal object InternalDocumentBack
        {
            get
            {
                return this.DocumentBack ?? (object)this.DocumentBackId;
            }

            set
            {
                StringOrObject<File>.Map(value, s => this.DocumentBackId = s, o => this.DocumentBack = o);
            }
        }
        #endregion

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
