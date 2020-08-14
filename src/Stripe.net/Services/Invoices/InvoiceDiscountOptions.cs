namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceDiscountOptions : INestedOptions
    {
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }
    }
}
