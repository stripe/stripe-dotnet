// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuotePhaseConfigurationGetOptions : BaseOptions
    {
        [JsonProperty("ending_before")]
        public string EndingBefore { get; set; }

        [JsonProperty("limit")]
        public long? Limit { get; set; }

        [JsonProperty("starting_after")]
        public string StartingAfter { get; set; }
    }
}
