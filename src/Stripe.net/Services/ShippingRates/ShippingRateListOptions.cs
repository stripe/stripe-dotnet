// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ShippingRateListOptions : ListOptionsWithCreated
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
