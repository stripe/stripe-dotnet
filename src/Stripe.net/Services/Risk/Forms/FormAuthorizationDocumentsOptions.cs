// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormAuthorizationDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// IDs of uploaded files to attach as authorization documents.
        /// </summary>
        [JsonProperty("files")]
        [STJS.JsonPropertyName("files")]
        public List<string> Files { get; set; }
    }
}
