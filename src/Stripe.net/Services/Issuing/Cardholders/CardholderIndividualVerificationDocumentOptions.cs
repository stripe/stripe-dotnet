// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardholderIndividualVerificationDocumentOptions : INestedOptions
    {
        /// <summary>
        /// The back of an ID returned by a <a href="https://api.stripe.com#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>.
        /// </summary>
        [JsonProperty("back")]
        [STJS.JsonPropertyName("back")]
        public string Back { get; set; }

        /// <summary>
        /// The front of an ID returned by a <a href="https://api.stripe.com#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>identity_document</c>.
        /// </summary>
        [JsonProperty("front")]
        [STJS.JsonPropertyName("front")]
        public string Front { get; set; }
    }
}
