// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceP24 : StripeEntity<SourceP24>
    {
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
