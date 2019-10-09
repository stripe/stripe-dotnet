namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCompanyVerificationDocumentOptions : INestedOptions
    {
        /// <summary>
        /// The back of a document returned by a file upload with a <c>purpose</c> value of
        /// <c>additional_verification</c>.
        /// </summary>
        [JsonProperty("back")]
        public string Back { get; set; }

        /// <summary>
        /// The front of a document returned by a file upload with a <c>purpose</c> value of
        /// <c>additional_verification</c>.
        /// </summary>
        [JsonProperty("front")]
        public string Front { get; set; }
    }
}
