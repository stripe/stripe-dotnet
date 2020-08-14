namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("items")]
        public List<OrderItemOptions> Items { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("shipping")]
        public ShippingOptions Shipping { get; set; }
    }
}
