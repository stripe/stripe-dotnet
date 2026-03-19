// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountDocumentsProofOfUltimateBeneficialOwnershipOptions : INestedOptions
    {
        /// <summary>
        /// One or more document ids returned by a <a href="https://api.stripe.com#create_file">file
        /// upload</a> with a <c>purpose</c> value of <c>account_requirement</c>.
        /// </summary>
        [JsonProperty("files")]
        [STJS.JsonPropertyName("files")]
        public List<string> Files { get; set; }

        /// <summary>
        /// Information regarding the person signing the document if applicable.
        /// </summary>
        [JsonProperty("signer")]
        [STJS.JsonPropertyName("signer")]
        public AccountDocumentsProofOfUltimateBeneficialOwnershipSignerOptions Signer { get; set; }
    }
}
