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
        public string DocumentId { get; set; }

        [JsonIgnore]
        public File Document { get; set; }

        [JsonProperty("document")]
        internal object InternalDocument
        {
            set
            {
                StringOrObject<File>.Map(value, s => this.DocumentId = s, o => this.Document = o);
            }
        }
        #endregion

        #region Expandable Document Back
        public string DocumentIdBack { get; set; }

        [JsonIgnore]
        public File DocumentBack { get; set; }

        [JsonProperty("document_back")]
        internal object InternalDocumentBack
        {
            set
            {
                StringOrObject<File>.Map(value, s => this.DocumentIdBack = s, o => this.DocumentBack = o);
            }
        }
        #endregion

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
