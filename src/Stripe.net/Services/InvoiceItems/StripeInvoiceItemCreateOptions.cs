using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeInvoiceItemCreateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("invoice")]
        public string InvoiceId { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountable")]
        public bool Discountable { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}