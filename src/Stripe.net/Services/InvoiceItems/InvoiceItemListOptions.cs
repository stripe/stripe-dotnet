// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceItemListOptions : ListOptionsWithCreated
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        [JsonProperty("pending")]
        public bool? Pending { get; set; }
    }
}
