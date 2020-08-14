namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompanyVerificationDocumentOptions : INestedOptions
    {
        /// <summary>
        /// The back of a document returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>additional_verification</c>. The uploaded file needs to be a color image
        /// (smaller than 8,000px by 8,000px), in JPG, PNG, or PDF format, and less than 10 MB in
        /// size.
        /// </summary>
        [JsonProperty("back")]
        public string Back { get; set; }

        /// <summary>
        /// The front of a document returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>additional_verification</c>. The uploaded file needs to be a color image
        /// (smaller than 8,000px by 8,000px), in JPG, PNG, or PDF format, and less than 10 MB in
        /// size.
        /// </summary>
        [JsonProperty("front")]
        public string Front { get; set; }
    }
}
