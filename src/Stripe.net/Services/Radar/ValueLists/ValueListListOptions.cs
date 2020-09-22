// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;

    public class ValueListListOptions : ListOptionsWithCreated
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("contains")]
        public string Contains { get; set; }
    }
}
