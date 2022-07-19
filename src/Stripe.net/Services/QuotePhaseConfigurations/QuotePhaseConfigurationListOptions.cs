// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuotePhaseConfigurationListOptions : ListOptions
    {
        [JsonProperty("quote")]
        public string Quote { get; set; }
    }
}
