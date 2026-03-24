// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateIdentityBusinessDetailsDocumentsBankAccountOwnershipVerificationOptions : INestedOptions
    {
        /// <summary>
        /// One or more document IDs returned by a <a
        /// href="https://docs.stripe.com/api/persons/update#create_file">file upload</a> with a
        /// purpose value of <c>account_requirement</c>.
        /// </summary>
        [JsonProperty("files")]
        [STJS.JsonPropertyName("files")]
        public List<string> Files { get; set; }

        /// <summary>
        /// The format of the document. Currently supports <c>files</c> only.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
