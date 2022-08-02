// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderListOptions : ListOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
