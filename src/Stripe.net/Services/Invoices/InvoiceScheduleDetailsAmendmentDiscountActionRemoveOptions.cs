// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceScheduleDetailsAmendmentDiscountActionRemoveOptions : INestedOptions
    {
        /// <summary>
        /// The coupon code to remove from the <c>discounts</c> array.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// The ID of a discount to remove from the <c>discounts</c> array.
        /// </summary>
        [JsonProperty("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// The ID of a promotion code to remove from the <c>discounts</c> array.
        /// </summary>
        [JsonProperty("promotion_code")]
        public string PromotionCode { get; set; }
    }
}
