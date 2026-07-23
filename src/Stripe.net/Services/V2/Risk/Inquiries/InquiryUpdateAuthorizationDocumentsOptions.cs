// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InquiryUpdateAuthorizationDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// IDs of uploaded files to attach as authorization documents.
        /// </summary>
        [JsonProperty("files")]
        [STJS.JsonPropertyName("files")]
        public List<string> Files { get; set; }
    }
}
