// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityBusinessDetailsDocumentsProofOfAddress : StripeEntity<AccountIdentityBusinessDetailsDocumentsProofOfAddress>
    {
        /// <summary>
        /// One or more document IDs returned by a <a
        /// href="https://docs.stripe.com/api/persons/update#create_file">file upload</a> with a
        /// purpose value of <c>account_requirement</c>.
        /// </summary>
        [JsonProperty("files")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("files")]
#endif
        public List<string> Files { get; set; }

        /// <summary>
        /// The format of the document. Currently supports <c>files</c> only.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
