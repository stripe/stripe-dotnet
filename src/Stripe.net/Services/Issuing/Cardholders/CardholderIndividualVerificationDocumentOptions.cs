// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardholderIndividualVerificationDocumentOptions : INestedOptions
    {
        /// <summary>
        /// The back of an ID returned by a <a href="https://stripe.com/docs/api#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>.
        /// </summary>
        [JsonProperty("back")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("back")]
#endif
        public string Back { get; set; }

        /// <summary>
        /// The front of an ID returned by a <a href="https://stripe.com/docs/api#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>.
        /// </summary>
        [JsonProperty("front")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("front")]
#endif
        public string Front { get; set; }
    }
}
