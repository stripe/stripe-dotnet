namespace Stripe
{
    using Newtonsoft.Json;

    public class LineItemDiscount : StripeEntity<LineItemDiscount>
    {
        /// <summary>
        /// Discount amount for this line item.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// A discount represents the actual application of a coupon to a particular customer. It
        /// contains information about when the discount began and when it will end.
        /// </summary>
        [JsonProperty("discount")]
        public Discount Discount { get; set; }
    }
}
