using Newtonsoft.Json;

namespace Stripe
{
    public class StripeInvoiceItemListOptions : StripeListOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
    }
}