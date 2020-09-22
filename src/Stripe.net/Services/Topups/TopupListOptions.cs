// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class TopupListOptions : ListOptionsWithCreated
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
