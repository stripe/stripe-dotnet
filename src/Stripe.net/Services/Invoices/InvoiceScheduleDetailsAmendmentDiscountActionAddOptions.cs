// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceScheduleDetailsAmendmentDiscountActionAddOptions : INestedOptions
    {
        /// <summary>
        /// The coupon code to redeem.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// An ID of an existing discount for a coupon that was already redeemed.
        /// </summary>
        [JsonProperty("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// Details to determine how long the discount should be applied for.
        /// </summary>
        [JsonProperty("discount_end")]
        public InvoiceScheduleDetailsAmendmentDiscountActionAddDiscountEndOptions DiscountEnd { get; set; }

        /// <summary>
        /// The index, starting at 0, at which to position the new discount. When not supplied,
        /// Stripe defaults to appending the discount to the end of the <c>discounts</c> array.
        /// </summary>
        [JsonProperty("index")]
        public long? Index { get; set; }

        /// <summary>
        /// The promotion code to redeem.
        /// </summary>
        [JsonProperty("promotion_code")]
        public string PromotionCode { get; set; }
    }
}
