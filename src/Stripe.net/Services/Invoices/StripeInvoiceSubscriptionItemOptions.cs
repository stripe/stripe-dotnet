using Newtonsoft.Json;

namespace Stripe
{
    public class StripeInvoiceSubscriptionItemOptions : StripeBaseOptions
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        [JsonProperty("plan")]
        public string PlanId { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }
}
