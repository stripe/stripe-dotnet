namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividualVerificationDocumentOptions : INestedOptions
    {
        /// <summary>
        /// The back of an ID returned by a <a href="https://stripe.com/docs/api#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>.
        /// </summary>
        [JsonProperty("back")]
        public string Back { get; set; }

        /// <summary>
        /// The front of an ID returned by a <a href="https://stripe.com/docs/api#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>.
        /// </summary>
        [JsonProperty("front")]
        public string Front { get; set; }
    }
}
