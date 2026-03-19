// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonTokenCreateDocumentsPrimaryVerificationOptions : INestedOptions
    {
        /// <summary>
        /// The <a href="https://docs.stripe.com/api/persons/update#create_file">file upload</a>
        /// tokens referring to each side of the document.
        /// </summary>
        [JsonProperty("front_back")]
        [STJS.JsonPropertyName("front_back")]
        public PersonTokenCreateDocumentsPrimaryVerificationFrontBackOptions FrontBack { get; set; }

        /// <summary>
        /// The format of the verification document. Currently supports <c>front_back</c> only.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
