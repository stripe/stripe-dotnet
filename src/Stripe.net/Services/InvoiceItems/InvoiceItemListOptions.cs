namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceItemListOptions : ListOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("created")]
        public DateFilter Created { get; set; }
    }
}