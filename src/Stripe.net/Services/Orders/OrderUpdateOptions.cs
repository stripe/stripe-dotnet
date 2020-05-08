namespace Stripe
{
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
        public ShippingOptions Shipping { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
