namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("selected_shipping_method")]
        public string SelectedShippingMethod { get; set; }

        [JsonProperty("shipping")]
        public OrderUpdateShippingOptions Shipping { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
