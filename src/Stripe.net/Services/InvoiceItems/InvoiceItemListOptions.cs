namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceItemListOptions : ListOptionsWithCreated
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }
    }
}
