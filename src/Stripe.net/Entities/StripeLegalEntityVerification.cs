using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeLegalEntityVerification : StripeEntity
    {
        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("details_code")]
        public string DetailsCode { get; set; }

        #region Expandable Document
        public string DocumentId { get; set; }

        [JsonIgnore]
        public StripeFileUpload Document { get; set; }

        [JsonProperty("document")]
        internal object InternalDocument
        {
            set
            {
                StringOrObject<StripeFileUpload>.Map(value, s => DocumentId = s, o => Document = o);
            }
        }
        #endregion

        #region Expandable Document Back
        public string DocumentIdBack { get; set; }

        [JsonIgnore]
        public StripeFileUpload DocumentBack { get; set; }

        [JsonProperty("document_back")]
        internal object InternalDocumentBack
        {
            set
            {
                StringOrObject<StripeFileUpload>.Map(value, s => DocumentIdBack = s, o => DocumentBack = o);
            }
        }
        #endregion

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}