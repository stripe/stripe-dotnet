// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormAuthorizationDocuments : StripeEntity<FormAuthorizationDocuments>
    {
        /// <summary>
        /// IDs of uploaded files attached as authorization documents.
        /// </summary>
        [JsonProperty("files")]
        [STJS.JsonPropertyName("files")]
        public List<string> Files { get; set; }
    }
}
