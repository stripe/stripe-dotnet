namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderIndividualVerificationDocumentOptions : INestedOptions
    {
        /// <summary>
        /// The back of a document returned by a file upload with a <c>purpose</c> value of
        /// <c>identity_document</c>.
        /// </summary>
        [JsonProperty("back")]
        public string Back { get; set; }

        /// <summary>
        /// The front of a document returned by a file upload with a <c>purpose</c> value of
        /// <c>identity_document</c>.
        /// </summary>
        [JsonProperty("front")]
        public string Front { get; set; }
    }
}
