// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenPersonDocumentsCompanyAuthorizationOptions : INestedOptions
    {
        /// <summary>
        /// One or more document ids returned by a <a href="https://api.stripe.com#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>account_requirement</c>.
        /// </summary>
        [JsonProperty("files")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("files")]
#endif
        public List<string> Files { get; set; }
    }
}
