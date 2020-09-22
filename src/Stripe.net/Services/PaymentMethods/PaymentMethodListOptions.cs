// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodListOptions : ListOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
