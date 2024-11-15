// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenAccountCompanyVerificationDocumentOptions : INestedOptions
    {
        /// <summary>
        /// The back of a document returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>additional_verification</c>. The uploaded file needs to be a color image
        /// (smaller than 8,000px by 8,000px), in JPG, PNG, or PDF format, and less than 10 MB in
        /// size.
        /// </summary>
        [JsonProperty("back")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("back")]
#endif

        public string Back { get; set; }

        /// <summary>
        /// The front of a document returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>additional_verification</c>. The uploaded file needs to be a color image
        /// (smaller than 8,000px by 8,000px), in JPG, PNG, or PDF format, and less than 10 MB in
        /// size.
        /// </summary>
        [JsonProperty("front")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("front")]
#endif

        public string Front { get; set; }
    }
}
