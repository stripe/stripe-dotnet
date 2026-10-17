// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormPaymentProcessingMultiProcessor : StripeEntity<FormPaymentProcessingMultiProcessor>
    {
        /// <summary>
        /// Files evidencing payments accepted outside Stripe. Each entry includes a file ID and,
        /// when supplied, a document type tag.
        /// </summary>
        [JsonProperty("files")]
        [STJS.JsonPropertyName("files")]
        public List<FormPaymentProcessingMultiProcessorFile> Files { get; set; }

        /// <summary>
        /// Whether the connected account accepts payments outside Stripe.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
