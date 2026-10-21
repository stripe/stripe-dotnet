// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormPaymentProcessingMultiProcessorOptions : INestedOptions
    {
        /// <summary>
        /// Files evidencing payments accepted outside Stripe. Each entry carries a tag naming the
        /// document type so a reviewer can distinguish statement types without opening the file.
        /// </summary>
        [JsonProperty("files")]
        [STJS.JsonPropertyName("files")]
        public List<FormPaymentProcessingMultiProcessorFileOptions> Files { get; set; }

        /// <summary>
        /// Whether the connected account accepts payments outside Stripe.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
