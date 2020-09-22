// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMultibanco : StripeEntity<SourceMultibanco>
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
