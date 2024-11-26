// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCompanyVerificationOptions : INestedOptions
    {
        /// <summary>
        /// A document verifying the business.
        /// </summary>
        [JsonProperty("document")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("document")]
#endif
        public AccountCompanyVerificationDocumentOptions Document { get; set; }
    }
}
