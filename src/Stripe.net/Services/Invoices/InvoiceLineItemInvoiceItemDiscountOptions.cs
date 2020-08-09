namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceLineItemInvoiceItemDiscountOptions : ListOptions
    {
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }
    }
}
