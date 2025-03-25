// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityIndividualDocumentsPrimaryVerification : StripeEntity<AccountIdentityIndividualDocumentsPrimaryVerification>
    {
        /// <summary>
        /// The <a href="https://docs.stripe.com/api/persons/update#create_file">file upload</a>
        /// tokens for the front and back of the verification document.
        /// </summary>
        [JsonProperty("front_back")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("front_back")]
#endif
        public AccountIdentityIndividualDocumentsPrimaryVerificationFrontBack FrontBack { get; set; }

        /// <summary>
        /// The format of the verification document. Currently supports <c>front_back</c> only.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
