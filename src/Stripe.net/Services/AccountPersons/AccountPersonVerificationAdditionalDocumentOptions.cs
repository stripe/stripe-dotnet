// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountPersonVerificationAdditionalDocumentOptions : INestedOptions
    {
        /// <summary>
        /// The back of an ID returned by a <a href="https://api.stripe.com#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>. The uploaded file
        /// needs to be a color image (smaller than 8,000px by 8,000px), in JPG, PNG, or PDF format,
        /// and less than 10 MB in size.
        /// </summary>
        [JsonProperty("back")]
        [STJS.JsonPropertyName("back")]
        public string Back { get; set; }

        /// <summary>
        /// The front of an ID returned by a <a href="https://api.stripe.com#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>. The uploaded file
        /// needs to be a color image (smaller than 8,000px by 8,000px), in JPG, PNG, or PDF format,
        /// and less than 10 MB in size.
        /// </summary>
        [JsonProperty("front")]
        [STJS.JsonPropertyName("front")]
        public string Front { get; set; }
    }
}
