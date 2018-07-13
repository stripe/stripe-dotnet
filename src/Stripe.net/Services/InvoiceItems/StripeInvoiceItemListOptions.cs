namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeInvoiceItemListOptions : StripeListOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
    }
}