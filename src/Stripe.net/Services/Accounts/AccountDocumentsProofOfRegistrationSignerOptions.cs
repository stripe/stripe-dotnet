// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountDocumentsProofOfRegistrationSignerOptions : INestedOptions
    {
        /// <summary>
        /// The token of the person signing the document, if applicable.
        /// </summary>
        [JsonProperty("person")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("person")]
#endif
        public string Person { get; set; }
    }
}
