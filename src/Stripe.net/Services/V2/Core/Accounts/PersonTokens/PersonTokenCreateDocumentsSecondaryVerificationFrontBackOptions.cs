// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonTokenCreateDocumentsSecondaryVerificationFrontBackOptions : INestedOptions
    {
        /// <summary>
        /// A <a href="https://docs.stripe.com/api/persons/update#create_file">file upload</a> token
        /// representing the back of the verification document. The purpose of the uploaded file
        /// should be 'identity_document'. The uploaded file needs to be a color image (smaller than
        /// 8,000px by 8,000px), in JPG, PNG, or PDF format, and less than 10 MB in size.
        /// </summary>
        [JsonProperty("back")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("back")]
#endif
        public string Back { get; set; }

        /// <summary>
        /// A <a href="https://docs.stripe.com/api/persons/update#create_file">file upload</a> token
        /// representing the front of the verification document. The purpose of the uploaded file
        /// should be 'identity_document'. The uploaded file needs to be a color image (smaller than
        /// 8,000px by 8,000px), in JPG, PNG, or PDF format, and less than 10 MB in size.
        /// </summary>
        [JsonProperty("front")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("front")]
#endif
        public string Front { get; set; }
    }
}
