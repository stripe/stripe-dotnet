namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceInvoiceItemDiscountOptions : ListOptions
    {
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }
    }
}
