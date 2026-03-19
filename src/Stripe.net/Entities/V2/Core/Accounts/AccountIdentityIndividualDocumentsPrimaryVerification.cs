// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityIndividualDocumentsPrimaryVerification : StripeEntity<AccountIdentityIndividualDocumentsPrimaryVerification>
    {
        /// <summary>
        /// The <a href="https://docs.stripe.com/api/persons/update#create_file">file upload</a>
        /// tokens for the front and back of the verification document.
        /// </summary>
        [JsonProperty("front_back")]
        [STJS.JsonPropertyName("front_back")]
        public AccountIdentityIndividualDocumentsPrimaryVerificationFrontBack FrontBack { get; set; }

        /// <summary>
        /// The format of the verification document. Currently supports <c>front_back</c> only.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
