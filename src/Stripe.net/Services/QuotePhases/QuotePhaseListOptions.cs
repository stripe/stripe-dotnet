// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuotePhaseListOptions : ListOptions
    {
        [JsonProperty("quote")]
        public string Quote { get; set; }
    }
}
