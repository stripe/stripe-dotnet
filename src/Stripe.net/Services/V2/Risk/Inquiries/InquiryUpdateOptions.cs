// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InquiryUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Provide this for appeal inquiries.
        /// </summary>
        [JsonProperty("appeal")]
        [STJS.JsonPropertyName("appeal")]
        public InquiryUpdateAppealOptions Appeal { get; set; }

        /// <summary>
        /// Provide this for authorization_documents inquiries.
        /// </summary>
        [JsonProperty("authorization_documents")]
        [STJS.JsonPropertyName("authorization_documents")]
        public InquiryUpdateAuthorizationDocumentsOptions AuthorizationDocuments { get; set; }

        /// <summary>
        /// Provide this for product_removal inquiries.
        /// </summary>
        [JsonProperty("product_removal")]
        [STJS.JsonPropertyName("product_removal")]
        public InquiryUpdateProductRemovalOptions ProductRemoval { get; set; }
    }
}
