// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceUpcomingLinesScheduleDetailsAmendmentDiscountActionSetOptions : INestedOptions
    {
        /// <summary>
        /// The coupon code to replace the <c>discounts</c> array with.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// An ID of an existing discount to replace the <c>discounts</c> array with.
        /// </summary>
        [JsonProperty("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// An ID of an existing promotion code to replace the <c>discounts</c> array with.
        /// </summary>
        [JsonProperty("promotion_code")]
        public string PromotionCode { get; set; }
    }
}
