// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceRenderingTemplateGetOptions : BaseOptions
    {
        [JsonProperty("version")]
        [STJS.JsonPropertyName("version")]
        public long? Version { get; set; }
    }
}
