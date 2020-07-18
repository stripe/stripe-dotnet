namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceItemDiscountOptions : INestedOptions
    {
        /// <summary>
        /// ID of the coupon to create a new discount for.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// ID of an existing discount on the object (or one of its ancestors) to reuse.
        /// </summary>
        [JsonProperty("discount")]
        public string Discount { get; set; }
    }
}
