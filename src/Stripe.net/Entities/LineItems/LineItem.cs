namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class LineItem : StripeEntity<LineItem>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount_subtotal")]
        public long? AmountSubtotal { get; set; }

        [JsonProperty("amount_total")]
        public long? AmountTotal { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discounts")]
        public List<LineItemDiscount> Discounts { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("taxes")]
        public List<LineItemTax> Taxes { get; set; }
    }
}
