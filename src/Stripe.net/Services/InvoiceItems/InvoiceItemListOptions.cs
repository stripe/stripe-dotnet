namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceItemListOptions : ListOptionsWithCreated
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("invoice")]
        public string InvoiceId { get; set; }

        [JsonProperty("pending")]
        public bool? Pending { get; set; }
    }
}
